using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAlerts.Services
{
    public class MessageService : IMessageService
    {
        public async Task MostrarAlerta(string message)
        {
            await App.Current.MainPage.DisplayAlert("DemoAlerts",message,"OK");
        }
    }
}
