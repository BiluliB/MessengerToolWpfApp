using MessengerToolWpfApp.ViewModels;
using System.Windows;

namespace MessengerToolWpfApp.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            DataContext = new LoginViewModel()
            {
                CloseAction = new Action(this.Close)
            };
        }
    }
}