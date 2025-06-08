using System.Drawing;

using Prowl.Surface;
using Prowl.Surface.Events;
using Prowl.Surface.Input;
using Prowl.Surface.Threading;

var mainWindow = Window.Create(new()
{
    Title = "Hello World",
    BackgroundColor = Color.Black,
    StartPosition = WindowStartPosition.CenterScreen,
});

Console.WriteLine("Press escape to close the Window");

mainWindow.Events.Frame += (window, evt) =>
{
    if (evt.ChangeKind == FrameChangeKind.ThemeChanged)
    {
        // Update the background color if the theme changed
        window.BackgroundColor = Color.White;
    }
};

mainWindow.Events.Keyboard += (_, evt) =>
{
    if (evt.Key == Key.Escape)
    {
        mainWindow.Close();
        evt.Handled = true;
    }
};

Dispatcher.Current.Run();
