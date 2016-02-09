using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoAlerts.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void Notify ([CallerMemberName] string propertyName=null)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this,new PropertyChangedEventArgs(propertyName));
        }
    }
}
