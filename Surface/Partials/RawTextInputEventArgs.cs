namespace Prowl.Surface.Input.Raw;

public partial class RawTextInputEventArgs
{
    public RawTextInputEventArgs(
        IKeyboardDevice device,
        ulong timestamp,
        IInputRoot root,
        string text,
        RawInputModifiers modifiers)
        : base(device, timestamp, root)
    {
        Text = text;
        Modifiers = modifiers;
    }

    public RawInputModifiers Modifiers { get; set; }
}
