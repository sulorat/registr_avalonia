using System.Runtime.InteropServices.JavaScript;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace reg;

public partial class Window1 : Window
{
    public Window1()
    {
        
        InitializeComponent();
    }


    private void Cancel_OnClick(object? sender, RoutedEventArgs e)
    {
        MainWindow mainwin = new MainWindow();
        
        mainwin.Show();
        
        Close();
    }
}