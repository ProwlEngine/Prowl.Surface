using System.Drawing;
using System.Runtime.InteropServices;

namespace Prowl.Surface;

/// <summary>
/// A RGBA Pixel value.
/// </summary>
/// <param name="R">The red component.</param>
/// <param name="G">The green component.</param>
/// <param name="B">The blue component.</param>
/// <param name="A">The alpha component.</param>
[StructLayout(LayoutKind.Sequential)]
public record struct Rgba32(byte R, byte G, byte B, byte A)
{
    /// <summary>
    /// Creates a new <see cref="Rgba32"/> struct from color information.
    /// </summary>
    /// <param name="color">Source <see cref="Color"/> data.</param>
    public static implicit operator Rgba32(Color color) => new(color.R, color.G, color.B, color.A);
}
