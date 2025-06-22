using System.Drawing;

using Prowl.Surface;
using Prowl.Surface.Events;
using Prowl.Surface.Input;

var mainWindow = Window.Create(new()
{
    Title = "Hello World",
    BackgroundColor = Color.Black,
    StartPosition = WindowStartPosition.CenterScreen,
});

Icon icon = new Icon(2, 2);

icon.Buffer[0] = new Rgba32(255, 255, 255, 255);
icon.Buffer[1] = new Rgba32(0, 0, 0, 255);
icon.Buffer[2] = new Rgba32(0, 0, 0, 255);
icon.Buffer[3] = new Rgba32(255, 255, 255, 255);

mainWindow.SetIcon(icon);

mainWindow.Opacity = 0.5f;

Console.WriteLine("Press escape to close the Window");

while (true)
{
    while (Window.PollEvent(out WindowEvent ev))
    {
        if (ev is CloseEvent)
        {
            mainWindow.Close();
        }
    }
}
