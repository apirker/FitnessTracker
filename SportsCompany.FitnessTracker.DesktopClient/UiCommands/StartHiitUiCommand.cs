using SportsCompany.FitnessTracker.UI.Hiit.HiitMain;
using System;
using System.Windows.Input;

namespace SportsCompany.FitnessTracker.DesktopClient.UiCommands
{
    /// <summary>
    /// Ui Command to open the HIIT UI.
    /// </summary>
    class StartHiitUiCommand : ICommand
    {
        private readonly IHiitMainView hiitMainView;

        public StartHiitUiCommand(IHiitMainView hiitMainView)
        {
            this.hiitMainView = hiitMainView;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Command execution.
        /// </summary>
        public void Execute(object parameter)
        {
            hiitMainView.Show();
        }
    }
}
