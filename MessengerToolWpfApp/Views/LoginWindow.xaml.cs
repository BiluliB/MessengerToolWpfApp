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
            var viewModel = DataContext as LoginViewModel;
            this.Loaded += LoginWindow_Loaded;
            viewModel.OnLoginSuccess = () =>
            {
                MessageBox.Show("Login erfolgreich");
                var MessengerWindow = new MessengerWindow(); // Ersetze dies durch dein Hauptfenster
                MessengerWindow.Show();
                this.Close();
            };

            
        }

        private void LoginWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Stelle sicher, dass das ViewModel als DataContext gesetzt ist
            if (DataContext is LoginViewModel viewModel)
            {
                txtPassword.PasswordChanged += (s, args) =>
                {
                    viewModel.Password = txtPassword.Password;
                };
            }
        }
    }

}