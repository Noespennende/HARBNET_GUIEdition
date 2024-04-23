using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppe8.HarbNet.GuiEdition.ViewModel
{
     public partial class ShipViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;

        void onPropertyChanged(String name) =>
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));

        
    }
}
