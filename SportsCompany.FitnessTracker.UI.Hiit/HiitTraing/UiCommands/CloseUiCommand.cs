using System;
using System.Windows;
using System.Windows.Input;

namespace SportsCompany.FitnessTracker.UI.Hiit.HiitTraing.UiCommands
{
    class CloseUiCommand : ICommand
    {
        private readonly IHiitTrainView view;

        public CloseUiCommand(IHiitTrainView view)
        {
            this.view = view;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            try
            {
                view.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong on closing the activity.");
            }
        }
    }
}
