// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Threading;

using Prowl.Surface.Input;
using Prowl.Surface.Platforms;
using Prowl.Surface.Platforms.Wayland;
using Prowl.Surface.Platforms.Win32;
using Prowl.Surface.Platforms.X11;
using Prowl.Surface.Threading.Events;

namespace Prowl.Surface.Threading;

/// <summary>
/// The dispatcher provides the infrastructure to manage objects with thread affinity.
/// </summary>
public abstract partial class Dispatcher
{
    private bool _hasShutdownStarted;
    private bool _hasShutdownFinished;
    private readonly IdleEvent _idleEvent;

    /// <summary>
    /// Shared synchronization context for a dispatcher
    /// </summary>
    protected readonly DispatcherSynchronizationContext DispatcherSynchronizationContext;

    // We use a fast static instance for the current dispatcher
    // We check that we are on the same thread otherwise we override it
    [ThreadStatic]
    internal static Dispatcher? TlsCurrentDispatcher;

    // internal list storing all dispatchers
    private static readonly List<WeakReference<Dispatcher>> Dispatchers = new();

    /// <summary>
    /// Set to true to allow per platform debugging
    /// </summary>
    internal bool DebugInternal;

    /// <summary>
    /// The writer used to log debug messages
    /// </summary>
    internal Action<string?>? DebugOutputInternal;


    /// <summary>
    /// Creates a new dispatcher from a thread.
    /// </summary>
    protected internal Dispatcher(Thread thread)
    {
        Thread = thread;
        _taskScheduler = new DispatcherTaskScheduler(this);
        _queue = new ConcurrentQueue<DispatcherJob>();
        _frames = new List<DispatcherFrame>();

        DispatcherSynchronizationContext = new DispatcherSynchronizationContext(this);

        // Pre-allocate events
        _idleEvent = new IdleEvent();
        _defaultUnhandledExceptionFilterEvent = new UnhandledExceptionFilterEvent();
        _defaultUnhandledExceptionEvent = new UnhandledExceptionEvent();

        // Make sure that the TLS dispatcher is set
        TlsCurrentDispatcher = this;

        Events = new DispatcherEventHub(this);

        DebugOutputInternal = Console.Out.WriteLine;
    }

    /// <summary>
    /// Gets the event hub for this dispatcher.
    /// </summary>
    public DispatcherEventHub Events { get; }

    /// <summary>
    /// Gets the current dispatcher.
    /// </summary>
    /// <value>The current dispatcher.</value>
    /// <remarks>
    /// The current dispatcher is attached to the current thread.
    /// </remarks>
    public static Dispatcher Current => TlsCurrentDispatcher ?? FromThread(Thread.CurrentThread);

    /// <summary>
    /// Gets the dispatcher from the specified thread or create one if not it does not exist.
    /// </summary>
    /// <param name="thread">The thread.</param>
    /// <returns>Dispatcher.</returns>
    public static Dispatcher FromThread(Thread thread)
    {
        Dispatcher? dispatcher = null;
        lock (Dispatchers)
        {
            for (int i = 0; i < Dispatchers.Count; i++)
            {
                var weakref = Dispatchers[i];
                if (weakref.TryGetTarget(out dispatcher))
                {
                    if (dispatcher.Thread == thread)
                    {
                        break;
                    }
                    else
                    {
                        dispatcher = null;
                    }
                }
                else
                {
                    Dispatchers.RemoveAt(i);
                    i--;
                }
            }

            if (dispatcher == null)
            {
                dispatcher = CreateDispatcher(thread);
                Dispatchers.Add(new WeakReference<Dispatcher>(dispatcher));
            }
        }
        return dispatcher;
    }

    private static Dispatcher CreateDispatcher(Thread thread)
    {
        switch (WindowPlatform.GetBestPlatform())
        {
            case PlatformType.Win32:
                return new Win32Dispatcher(thread);
            case PlatformType.Wayland:
                return new WaylandDispatcher(thread);
            case PlatformType.X11:
                return new X11Dispatcher(thread);
        }

        throw new PlatformNotSupportedException();
    }

    /// <summary>
    /// Gets the thread this dispatcher is attached to.
    /// </summary>
    public Thread Thread { get; }

    /// <summary>
    /// Gets a boolean indicating if the shutdown has started.
    /// </summary>
    public bool HasShutdownStarted => _hasShutdownStarted;

    /// <summary>
    /// Gets a boolean indicating if the shutdown has finished.
    /// </summary>
    public bool HasShutdownFinished => _hasShutdownFinished;

    /// <summary>
    /// Gets or sets a boolean indicating whether the dispatcher can output debug information via <see cref="DebugOutput"/>.
    /// </summary>
    public bool EnableDebug
    {
        get
        {
            VerifyAccess();
            return DebugInternal;
        }
        set
        {
            VerifyAccess();
            DebugInternal = value;
        }
    }

    /// <summary>
    /// Gets or sets the debug output when <see cref="EnableDebug"/> is <c>true</c>.
    /// </summary>
    public Action<string?>? DebugOutput
    {
        get
        {
            VerifyAccess();
            return DebugOutputInternal;
        }
        set
        {
            VerifyAccess();
            DebugOutputInternal = value;
        }
    }

    /// <summary>
    /// Checks that the current thread owns this dispatcher.
    /// </summary>
    /// <returns><c>true</c> if the current thread owns this dispatcher, <c>false</c> otherwise.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool CheckAccess()
    {
        return Thread == Thread.CurrentThread;
    }

    /// <summary>
    /// Verifies that the current thread owns this dispatcher or throw an exception if not.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VerifyAccess()
    {
        if (!CheckAccess())
        {
            ThrowInvalidAccess();
        }
    }

    /// <summary>
    /// Shutdown this dispatcher.
    /// </summary>
    /// <remarks>
    /// Once a dispatcher has been shutdown, it cannot be used anymore.
    /// </remarks>
    public void Shutdown()
    {
        VerifyAccess();

        PostQuitToMessageLoop();

        Events.OnDispatcherEvent(ShutdownEvent.ShutdownStarted);
        _hasShutdownStarted = true;
    }

    /// <summary>
    /// Run the dispatching loop for all Window events associated to this thread.
    /// </summary>
    /// <exception cref="InvalidOperationException">If there is already a loop running.</exception>
    public void Run()
    {
        VerifyAccess();
        if (_frames.Count != 0)
        {
            throw new InvalidOperationException("Cannot call run while the dispatcher is already running.");
        }
        try
        {
            PushFrameImpl(new DispatcherFrame(this));

            Events.OnDispatcherEvent(ShutdownEvent.ShutdownFinished);
            _hasShutdownFinished = true;
        }
        finally
        {
            _queue.Clear();
            ResetImpl();
        }
    }

    /// <summary>
    /// Push the specified loop frame to this dispatcher. The dispatcher must be running via <see cref="Dispatcher.Run"/>.
    /// </summary>
    /// <param name="frame"></param>
    public void PushFrame(DispatcherFrame frame)
    {
        VerifyAccess();
        VerifyRunning();
        PushFrameImpl(frame);
    }

    private void PushFrameImpl(DispatcherFrame frame)
    {
        if (_hasShutdownStarted)
        {
            throw new InvalidOperationException("Can't push a new frame. The shutdown has been already started");
        }

        if (frame.Dispatcher != this)
        {
            throw new InvalidOperationException("Dispatcher frame is not attached to this dispatcher");
        }

        var frameCount = _frames.Count;
        _frames.Add(frame);
        try
        {
            frame.EnterInternal();

            bool blockOnWait = false; // First loop step is not blocking to let the idle run at least once
            while (!_hasShutdownStarted && frame.Continue)
            {
                // If any frame already running are asking to shutdown, we need to close this running frame as well
                // For example, a modal window pushed with WindowModalFrame should force the exit of the frame and any subsequent frame
                for (int i = 0; i < frameCount; i++)
                {
                    if (!_frames[i].Continue)
                    {
                        frame.Continue = false;
                        break;
                    }
                }

                if (!frame.Continue)
                {
                    break;
                }

                WaitAndDispatchMessage(blockOnWait);

                // Handle idle
                // Reset the state of the idle
                _idleEvent.SkipWaitForNextMessage = false;
                _idleEvent.Handled = false;

                // Make sure that idle is being filtered/handled exception
                try
                {
                    Events.OnDispatcherEvent(_idleEvent);
                }
                catch (Exception ex) when (FilterException(ex))
                {
                    if (!HandleException(ex))
                    {
                        // If we have an unhandled exception pass it back to the frame (outside of the wndproc)
                        // to properly flow it back to the render loop
                        frame.CaptureException(ExceptionDispatchInfo.Capture(ex));
                    }
                }

                blockOnWait = !_idleEvent.Handled || !_idleEvent.SkipWaitForNextMessage;
            }
        }
        finally
        {
            Debug.Assert(_frames.Count > 0);
            _frames.RemoveAt(_frames.Count - 1);
            frame.LeaveInternal();
        }
    }

    internal DispatcherFrame? CurrentFrame => _frames.Count > 0 ? _frames[_frames.Count - 1] : null;

    internal abstract void WaitAndDispatchMessage(bool blockOnWait);

    internal abstract void CreateOrResetTimer(DispatcherTimer timer, int millis);

    internal abstract void DestroyTimer(DispatcherTimer timer);

    internal abstract void PostQuitToMessageLoop();

    internal abstract void ResetImpl();

    internal abstract ScreenManager ScreenManager { get; }

    internal abstract InputManager InputManager { get; }

    [DoesNotReturn]
    private static void ThrowInvalidAccess()
    {
        throw new InvalidOperationException("Invalid Access from this thread. This object must be accessed from the UI main Thread");
    }
}
