namespace Prowl.Surface;

public readonly partial struct PixelPoint
{
    public System.Drawing.Point ToDrawingPoint() => new System.Drawing.Point(X, Y);
}
