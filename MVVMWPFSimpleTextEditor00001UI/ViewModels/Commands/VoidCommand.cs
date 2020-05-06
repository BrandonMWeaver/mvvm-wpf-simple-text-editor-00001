using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMWPFSimpleTextEditor00001UI.ViewModels.Commands
{
    class VoidCommand : ICommand
    {
        private readonly Action _function;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public VoidCommand(Action function)
        {
            this._function = function;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this._function.Invoke();
        }
    }
}
