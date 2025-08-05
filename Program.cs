namespace ImageSorter;
using System;
using Avalonia;

internal sealed class Program
{
    [STAThread]
    public static void Main(string[] args) => AppBuilder
        .Configure<App>()
        .UsePlatformDetect()
        .LogToTrace()
        .StartWithClassicDesktopLifetime(args);
}