using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace modellli
{
    internal class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void SetProrerty<T>(ref T member, T value, [CallerMemberName] string property = "")// обощение
        {
            if (Object.Equals(member, value))return;
            member = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        protected virtual void OnPropertyChanged (string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
