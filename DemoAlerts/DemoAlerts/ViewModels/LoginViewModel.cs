using DemoAlerts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace DemoAlerts.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private string _email;

        

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
                Notify("Email");
            }
        }

        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
                Notify("Password");
            }
        }

        public ICommand LoginCmd { get; set; }

        private IMessageService _messageService;

        public LoginViewModel()
        {
            LoginCmd = new Command(Login);

            _messageService = DependencyService.Get<IMessageService>();
        }

        private void Login()
        {
            if (Email == "adm" && Password=="123")
            {
                //TODO: Ira a la  vista Principal
            }
            else
            {
                //TODO: Mostrara mensaje de Error
                _messageService.MostrarAlerta("Email y/o contraseña invalidos");

            }
        }
    }
}
