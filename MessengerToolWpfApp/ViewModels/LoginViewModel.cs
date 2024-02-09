using MessengerToolWpfApp.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MessengerToolWpfApp.Views;

namespace MessengerToolWpfApp.ViewModels
{
    public class LoginViewModel
    {

        private readonly LoginService _loginService = new LoginService();

        public string Username { get; set; }
        public string Password { get; set; }

        public ICommand OpenRegisterCommand { get; }


        public ICommand LoginCommand { get; }

        public Action OnLoginSuccess { get; set; } // Aktion, die nach dem erfolgreichen Anmelden ausgeführt wird

        public Action CloseAction { get; set; } // Aktion zum Schließen des Fensters

        public LoginViewModel()
        {
            OpenRegisterCommand = new RelayCommand(OpenRegisterWindow);
            LoginCommand = new RelayCommand(async () => await LoginAsync());
        }

        private void OpenRegisterWindow()
        {
            var registerWindow = new RegisterWindow();
            registerWindow.Show();

            CloseAction?.Invoke();
        }

        private void Login()
        {
            var chatWindow = new MessengerWindow();
            chatWindow.Show();

            CloseAction?.Invoke();
        }

        private async Task LoginAsync()
        {
            try
            {
                var token = await _loginService.LoginAsync(Username, Password);
                // Token speichern und zum Hauptfenster navigieren
                OnLoginSuccess?.Invoke();
            }
            catch (Exception ex)
            {
                // Fehlerbehandlung, z.B. Anzeigen einer Fehlermeldung
            }
        }
    }
}


