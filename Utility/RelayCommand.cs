using System;
using System.Windows.Input;
namespace Utility
{
    public class RelayCommand : ICommand
    {
        Action<object> _execMethod;
        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action<object> _exec)
        {
            _execMethod = _exec;
        }
        public bool CanExecute(object parameter)
        {
            if (_execMethod != null)
                return true;
            else
                return false;
        }

        public void Execute(object parameter)
        {
            _execMethod(parameter);
        }
    }
}
