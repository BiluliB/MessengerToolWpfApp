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
        public ICommand OpenRegisterCommand { get; }
        public Action CloseAction { get; set; } // Aktion zum Schließen des Fensters

        public LoginViewModel()
        {
            OpenRegisterCommand = new RelayCommand(OpenRegisterWindow);
        }

        private void OpenRegisterWindow()
        {
            var registerWindow = new RegisterWindow();
            registerWindow.Show();

            CloseAction?.Invoke(); // Schließt das Login-Fenster
        }
    }

}
