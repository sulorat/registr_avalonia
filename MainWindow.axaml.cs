using Avalonia.Controls;
using System.Linq;

namespace reg
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void TextBox_KeyUp(object? sender, Avalonia.Input.KeyEventArgs e)
        {
            if (Phone.Text.Length >= 7)
                IN.IsVisible = true;
        }
    }
}