using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace modellli
{
    internal class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private Action _execute;
        private Func<bool>_canExecute;
        public RelayCommand (Action execute)=>_execute = execute;
        public RelayCommand (Action execute, Func<bool>canExecute) 
        {
            _execute = execute;
            _canExecute = canExecute;
        }
        public void OnCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }
        public bool CanExecute(object? parameter)
        {
            if (_canExecute != null)
            {
                return _canExecute();
            }
            if(_execute != null)
            return true;
            return false;
        }

        public void Execute(object? parameter)
        {
            if(_execute!= null)
            {
                _execute(); 
            }
        }
    }
    internal class RelayCommand <T>: ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private Action<T> _execute;
        private Func<T,bool> _canExecute;
        public RelayCommand(Action<T> execute) => _execute = execute;
        public RelayCommand(Action<T> execute, Func<T,bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }
        public void OnCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }
        public bool CanExecute(object? parameter)
        {
            if (_canExecute != null)
            {
                T param = (T)parameter;
                return _canExecute(param);
            }
            if (_execute != null)
                return true;
            return false;
        }

        public void Execute(object? parameter)
        {
            if (_execute != null)
            {
                _execute((T)parameter);
            }
        }
    }
}
