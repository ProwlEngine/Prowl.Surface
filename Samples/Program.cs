﻿using Prowl.Surface;
using Prowl.Surface.Controls.Platform.Surfaces;
using Prowl.Surface.Controls.Primitives.PopupPositioning;
using Prowl.Surface.Input.Raw;
using Prowl.Surface.Platform;
using Prowl.Surface.Platform.Storage;
using Prowl.Surface.Threading;

using Prowl.Vector;

using SkiaSharp;

namespace Demo;

public class Program
{
    private static IWindowImpl window = null!;
    private static SKSurface? canvas;
    private static SKColor? draw_color;
    private static Vector2? cursor_position;
    private static bool show_diagnostics = false;
    private static SKRect? anchor_rect;

    private static SKColor[] touch_colors = [SKColors.Yellow, SKColors.Blue, SKColors.Brown, SKColors.Purple, SKColors.Pink, SKColors.White, SKColors.Orange, SKColors.Black, SKColors.Coral, SKColors.Gray];

    private static string? open_file;
    private static string? open_folder;
    private static string? save_file;

    private static void Main()
    {
        // Create a native window
        window = AvaloniaGlobals.GetRequiredService<IWindowingPlatform>().CreateWindow();
        window.Resize(new Vector2(1024, 768));
        window.SetTitle("Prowl.Surface Demo");

        // When the window is closed, stop our message loop
        var _mainLoopCancellationTokenSource = new CancellationTokenSource();
        window.Closed = () => _mainLoopCancellationTokenSource?.Cancel();

        // On resize, destroy our canvas so a new one will get created with the proper size
        window.Resized = (s, r) => { canvas?.Dispose(); canvas = null; };

        // Redraw if moved to update diagnostics
        window.PositionChanged = (p) => Invalidate();

        // Handle painting the window
        window.Paint = DoPaint;

        // Handle input
        window.Input = HandleInput;

        // Show the window
        window.Show(true, false);

        // Begin the message loop
        Dispatcher.UIThread.MainLoop(_mainLoopCancellationTokenSource.Token);
    }

    private static SKSurface GetCanvas()
    {
        if (canvas is not null)
            return canvas;

        var screen = window.ClientSize * window.RenderScaling;
        var info = new SKImageInfo((int)screen.x, (int)screen.y);

        canvas = SKSurface.Create(info);
        canvas.Canvas.Clear(SKColors.CornflowerBlue);

        return canvas;
    }

    public static SKColorType ToSkColorType(PixelFormat fmt)
    {
        if (fmt == PixelFormat.Rgb565)
            return SKColorType.Rgb565;
        if (fmt == PixelFormat.Bgra8888)
            return SKColorType.Bgra8888;
        if (fmt == PixelFormat.Rgba8888)
            return SKColorType.Rgba8888;
        throw new ArgumentException("Unknown pixel format: " + fmt);
    }

    private static void DoPaint(Rect bounds)
    {
        // Get the framebuffer for the window
        var skia_framebuffer = window.Surfaces.OfType<IFramebufferPlatformSurface>().First();

        using var framebuffer = skia_framebuffer.Lock();

        var framebufferImageInfo = new SKImageInfo(framebuffer.Size.Width, framebuffer.Size.Height,
            ToSkColorType(framebuffer.Format), framebuffer.Format == PixelFormat.Rgb565 ? SKAlphaType.Opaque : SKAlphaType.Premul);

        // Wrap the framebuffer in a Skia canvas
        using var surface = SKSurface.Create(framebufferImageInfo, framebuffer.Address, framebuffer.RowBytes);

        // Draw our stored canvas onto the window
        surface.Canvas.DrawSurface(GetCanvas(), SKPoint.Empty);

        if (show_diagnostics)
            OutputDiagnostics(surface.Canvas);
        else
            ShowInfo(surface.Canvas);

        if (anchor_rect.HasValue)
            surface.Canvas.DrawRect(anchor_rect.Value, new SKPaint { Color = SKColors.White, IsStroke = true });
    }

    private static void HandleInput(RawInputEventArgs obj)
    {
        // Touch must be first since RawTouchEventArgs subclasses RawPointerEventArgs
        if (obj is RawTouchEventArgs touch)
            HandleTouchInput(touch);
        else if (obj is RawPointerEventArgs pointer)
            HandleMouseInput(pointer);
        else if (obj is RawKeyEventArgs key)
            HandleKeyboardInput(key);
    }

    private static void HandleMouseInput(RawPointerEventArgs e)
    {
        var x = Scale((int)e.Position.x);
        var y = Scale((int)e.Position.y);

        if (e.Type == RawPointerEventType.LeftButtonDown)
            draw_color = SKColors.Red;
        else if (e.Type == RawPointerEventType.RightButtonDown)
            draw_color = SKColors.Green;
        else if (e.Type == RawPointerEventType.LeftButtonUp || e.Type == RawPointerEventType.RightButtonUp)
            draw_color = null;
        else if (e.Type == RawPointerEventType.Move && draw_color.HasValue)
        {
            var radius = Scale(5);
            var paint = new SKPaint { Color = draw_color.Value, IsStroke = false };
            GetCanvas().Canvas.DrawCircle(x, y, radius, paint);
        }

        if (e.Type == RawPointerEventType.LeaveWindow)
            cursor_position = null;
        else if (e.Type == RawPointerEventType.Move)
            cursor_position = e.Position;

        Invalidate();
    }

    private static async void HandleKeyboardInput(RawKeyEventArgs e)
    {
        // Use F1 key to toggle diagnostics
        if (e.Type == RawKeyEventType.KeyDown && e.Key == Prowl.Surface.Input.Key.F1)
        {
            show_diagnostics = !show_diagnostics;
            e.Handled = true;
        }

        // Use P to trigger a popup
        if (e.Type == RawKeyEventType.KeyDown && e.Key == Prowl.Surface.Input.Key.P)
        {
            anchor_rect = new SKRect(300, 300, 301, 301);

            var popup = window.CreatePopup();
            var ppp = new PopupPositionerParameters
            {
                AnchorRectangle = new Rect(300, 300, 301, 301),
                Anchor = PopupAnchor.TopLeft,
                Gravity = PopupGravity.BottomRight,
                Size = new Vector2(200, 200),
                ConstraintAdjustment = PopupPositionerConstraintAdjustment.None,
            };

            popup.PopupPositioner.Update(ppp);
            popup.Show(true, true);

            e.Handled = true;
        }

        if (window.TryGetFeature(typeof(IStorageProvider)) is IStorageProvider storageProvider)
        {
            // Use F9 key to open a File Open dialog
            if (e.Type == RawKeyEventType.KeyDown && e.Key == Prowl.Surface.Input.Key.F9)
            {
                var result = await storageProvider.OpenFilePickerAsync(new FilePickerOpenOptions { });
                open_file = result?.FirstOrDefault()?.Name;
                e.Handled = true;
            }

            // Use F10 key to open a Folder Open dialog
            if (e.Type == RawKeyEventType.KeyDown && e.Key == Prowl.Surface.Input.Key.F10)
            {
                var result = await storageProvider.OpenFolderPickerAsync(new FolderPickerOpenOptions { });
                open_folder = result?.FirstOrDefault()?.Name;
                e.Handled = true;
            }

            // Use F12 key to open a File Save dialog (F11 is a system key on Mac?)
            if (e.Type == RawKeyEventType.KeyDown && e.Key == Prowl.Surface.Input.Key.F12)
            {
                var result = await storageProvider.SaveFilePickerAsync(new FilePickerSaveOptions { });
                save_file = result?.Name;
                e.Handled = true;
            }

        }

        Invalidate();
    }

    private static void HandleTouchInput(RawTouchEventArgs e)
    {
        var x = Scale((int)e.Position.x);
        var y = Scale((int)e.Position.y);

        if (e.Type == RawPointerEventType.TouchUpdate)
        {
            var radius = Scale(5);
            var color = touch_colors[e.RawPointerId % 10];
            var paint = new SKPaint { Color = color, IsStroke = false };
            GetCanvas().Canvas.DrawCircle(x, y, radius, paint);
            Invalidate();
        }
    }

    private static void Invalidate() => window.Invalidate(new Rect(Vector2.zero, window.ClientSize));

    private static void ShowInfo(SKCanvas canvas)
    {
        var paint = new SKPaint { Color = SKColors.Black, IsAntialias = true, TextSize = Scale(16), SubpixelText = true, Typeface = SKTypeface.FromFamilyName(SKTypeface.Default.FamilyName, SKFontStyleWeight.SemiBold, SKFontStyleWidth.Normal, SKFontStyleSlant.Upright) };

        int x = Scale(10);
        var y = 0;
        var line_height = Scale(25);

        canvas.DrawText("F1: Show Diagnostics", x, y += line_height, paint);
        canvas.DrawText("F9: Open File Picker", x, y += line_height, paint);
        canvas.DrawText("F10: Open Folder Picker", x, y += line_height, paint);
        canvas.DrawText("F12: Open File Saver", x, y += line_height, paint);
        canvas.DrawText("P: Open Popup", x, y += line_height, paint);
    }

    private static void OutputDiagnostics(SKCanvas canvas)
    {
        var paint = new SKPaint { Color = SKColors.Black, IsAntialias = true, TextSize = Scale(16), SubpixelText = true, Typeface = SKTypeface.FromFamilyName(SKTypeface.Default.FamilyName, SKFontStyleWeight.SemiBold, SKFontStyleWidth.Normal, SKFontStyleSlant.Upright) };

        int x = Scale(10);
        var y = 0;
        var line_height = Scale(25);

        canvas.DrawText($"ClientSize - {window.ClientSize}", x, y += line_height, paint);
        canvas.DrawText($"DesktopScaling - {window.DesktopScaling}", x, y += line_height, paint);
        canvas.DrawText($"ExtendedMargins - {window.ExtendedMargins}", x, y += line_height, paint);
        canvas.DrawText($"FrameSize - {window.FrameSize}", x, y += line_height, paint);
        canvas.DrawText($"IsClientAreaExtendedToDecorations - {window.IsClientAreaExtendedToDecorations}", x, y += line_height, paint);
        canvas.DrawText($"MaxAutoSizeHint - {window.MaxAutoSizeHint}", x, y += line_height, paint);
        canvas.DrawText($"NeedsManagedDecorations - {window.NeedsManagedDecorations}", x, y += line_height, paint);
        canvas.DrawText($"OffScreenMargin - {window.OffScreenMargin}", x, y += line_height, paint);
        canvas.DrawText($"Position - {window.Position}", x, y += line_height, paint);
        canvas.DrawText($"RenderScaling - {window.RenderScaling}", x, y += line_height, paint);
        canvas.DrawText($"TransparencyLevel - {window.TransparencyLevel}", x, y += line_height, paint);
        canvas.DrawText($"WindowState - {window.WindowState}", x, y += line_height, paint);

        y += line_height;

        if (cursor_position.HasValue)
            canvas.DrawText($"Cursor Position - {cursor_position}", x, y += line_height, paint);
        if (open_file is not null)
            canvas.DrawText($"Open File - {open_file}", x, y += line_height, paint);
        if (open_folder is not null)
            canvas.DrawText($"Open Folder - {open_folder}", x, y += line_height, paint);
        if (save_file is not null)
            canvas.DrawText($"Save File - {save_file}", x, y += line_height, paint);
    }

    private static int Scale(int value) => (int)(value * window.RenderScaling);
}
