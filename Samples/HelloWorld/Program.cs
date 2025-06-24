using System.Drawing;
using System.Reflection;

using Prowl.Surface;
using Prowl.Surface.Events;
using Prowl.Surface.Input;

CircularBuffer<int> testBuffer = new CircularBuffer<int>(5);

testBuffer.Enqueue(1);
testBuffer.Enqueue(2);
testBuffer.Enqueue(3);
testBuffer.Enqueue(4);
testBuffer.Enqueue(5);
testBuffer.Enqueue(6);

testBuffer.TryDequeue(out int v);
testBuffer.TryDequeue(out v);
testBuffer.TryDequeue(out v);
testBuffer.TryDequeue(out v);
testBuffer.TryDequeue(out v);

Icon icon = new Icon(2, 2);

icon.Buffer[0] = new Rgba32(255, 255, 255, 255);
icon.Buffer[1] = new Rgba32(0, 0, 0, 255);
icon.Buffer[2] = new Rgba32(0, 0, 0, 255);
icon.Buffer[3] = new Rgba32(255, 255, 255, 255);


var mainWindow = Platform.CreateWindow(new()
{
    Title = "Hello World",
    StartPosition = WindowStartPosition.CenterScreen,
    Size = new(900, 800),
    Position = new(1920 / 2, 1080 / 2)
});


var secondWindow = Platform.CreateWindow(new()
{
    Title = "Hello World",
    StartPosition = WindowStartPosition.CenterScreen,
    Size = new(900, 800),
    Position = new(1920 / 2, 1080 / 2)
});


var childWindow = Platform.CreateWindow(new()
{
    Kind = WindowKind.Child,
    Parent = mainWindow,
    Size = new(250, 250),
    Position = new(-100, -100)
});

mainWindow.SetIcon(icon);

Console.WriteLine("Press escape to close the Window");

Thread th = new Thread(() =>
{
    while (!mainWindow.IsDisposed || !childWindow.IsDisposed || !secondWindow.IsDisposed)
    {
        while (Prowl.Surface.EventHandler.PollEvents(out WindowEvent ev))
        {
            if (ev.Kind == WindowEventKind.Close)
                ev.Window.Close();
        }
    }
});

th.Start();

while (!mainWindow.IsDisposed)
{
    Console.WriteLine("Change window variable:");

    try
    {
        ParseInput(Console.ReadLine());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}


void ParseInput(string? input)
{
    if (input == null)
        return;

    if (input.Contains('='))
        SetProperty(input);
    else
        LogProperty(input);
}


void SetProperty(string input)
{
    string[] split = input.Split('=', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

    if (split.Length != 2)
    {
        Console.WriteLine($"Malformed input: {input}");
        return;
    }

    string variable = split[0];
    string value = split[1];

    PropertyInfo? prop = typeof(Window).GetProperty(variable);

    if (prop != null)
    {
        ParseProperty(prop, mainWindow, value);
    }
    else
    {
        Console.WriteLine($"Could not find property with name: {variable}");
    }

    Console.WriteLine($"Changed variable: {variable} to {value}");
}


void ParseProperty(PropertyInfo prop, Window window, string value)
{
    if (prop.PropertyType == typeof(bool))
        prop.SetValue(window, value == "true");

    if (prop.PropertyType.IsAssignableTo(typeof(Enum)))
        prop.SetValue(window, Enum.Parse(prop.PropertyType, value));

    if (prop.PropertyType == typeof(Size))
    {
        string[] values = value.Split(',');

        if (values.Length != 2)
        {
            Console.WriteLine("Incorrect number of args for Size value");
            return;
        }

        prop.SetValue(window, new Size(int.Parse(values[0]), int.Parse(values[1])));
    }

    if (prop.PropertyType == typeof(Point))
    {
        string[] values = value.Split(',');

        if (values.Length != 2)
        {
            Console.WriteLine("Incorrect number of args for Point value");
            return;
        }

        prop.SetValue(window, new Point(int.Parse(values[0]), int.Parse(values[1])));
    }

    if (prop.PropertyType == typeof(float))
        prop.SetValue(window, float.Parse(value));

    if (prop.PropertyType == typeof(string))
        prop.SetValue(window, value);

    // Console.WriteLine($"Could not set property with type: {prop.PropertyType.Name}");
}


void LogProperty(string input)
{
    PropertyInfo? prop = typeof(Window).GetProperty(input);

    if (prop != null)
    {
        Console.WriteLine($"{input}: {prop.GetValue(mainWindow)}");
    }
}
