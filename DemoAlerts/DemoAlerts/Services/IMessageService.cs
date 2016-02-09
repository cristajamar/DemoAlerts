using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAlerts.Services
{
    interface IMessageService
    {
        Task MostrarAlerta(string message);
    }
}
