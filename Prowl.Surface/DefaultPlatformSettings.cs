using System;

using Prowl.Surface.Input;
using Prowl.Surface.Metadata;

using Prowl.Vector;

namespace Prowl.Surface.Platform;

/// <summary>
/// A default implementation of <see cref="IPlatformSettings"/> for platforms.
/// </summary>
[PrivateApi]
public class DefaultPlatformSettings : IPlatformSettings
{
    public virtual Vector2 GetTapSize(PointerType type)
    {
        return type switch
        {
            PointerType.Touch => new(10, 10),
            _ => new(4, 4),
        };
    }
    public virtual Vector2 GetDoubleTapSize(PointerType type)
    {
        return type switch
        {
            PointerType.Touch => new(16, 16),
            _ => new(4, 4),
        };
    }
    public virtual TimeSpan GetDoubleTapTime(PointerType type) => TimeSpan.FromMilliseconds(500);

    public virtual TimeSpan HoldWaitDuration => TimeSpan.FromMilliseconds(300);

    //public PlatformHotkeyConfiguration HotkeyConfiguration =>
    //    AvaloniaLocator.Current.GetRequiredService<PlatformHotkeyConfiguration>();

    public virtual PlatformColorValues GetColorValues()
    {
        return new PlatformColorValues
        {
            ThemeVariant = PlatformThemeVariant.Light
        };
    }

    public virtual event EventHandler<PlatformColorValues>? ColorValuesChanged;

    protected void OnColorValuesChanged(PlatformColorValues colorValues)
    {
        ColorValuesChanged?.Invoke(this, colorValues);
    }
}
