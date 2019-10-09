using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using labo3_interface.ViewModel;

namespace labo3_interface.Command
{
    class OpenCommand : ICommand
    {
        private MainViewModel mainViewModel;
        public OpenCommand(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return mainViewModel.CanUpdate;
        }

        public void Execute(object parameter)
        {
            mainViewModel.OpenWindow(parameter);
        }
    }
}

