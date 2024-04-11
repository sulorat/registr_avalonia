using Avalonia.Controls;
using System.Linq;

namespace reg
{
    public partial class MainWindow : Window
    {
        Window1 win1 = new Window1();
        Window2 win2 = new Window2();   
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (password_sign_up.Text == "admin" || password_sign_up.Text == "ADMIN")
            {
                win1.Show();
                //добавить из визибле для кнопки 
                Hide();
            }   
            else
            {
                win1.Show();
                Hide();
            }


        }
    }
}