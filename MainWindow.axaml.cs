using Avalonia.Controls;
using System.Linq;
using System.Net.Mime;
using Avalonia.Interactivity;

namespace reg
{
    public partial class MainWindow : Window
    {
        private Number _number = new Number();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = _number;
        }
        
        private class Number
        {
            public string phone_number { get; set; }
        }

        private void TextBox_KeyUp(object? sender, Avalonia.Input.KeyEventArgs e)
        {
            if (Phone.Text.Length >= 7)
                IN.IsVisible = true;
        }

        private void ToSecWindow(object? sender, RoutedEventArgs e)
        {
            var _win1 = new Window1()
            {
                DataContext = _number
            };
            _win1.Show();
        }
    }
}