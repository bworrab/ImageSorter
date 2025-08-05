namespace ImageSorter;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = this;
    }
}