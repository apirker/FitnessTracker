using SportsCompany.FitnessTracker.UI.Endurance.EnduranceMain;
using System;
using System.Windows.Input;
using Unity;

namespace SportsCompany.FitnessTracker.DesktopClient.UiCommands
{
    /// <summary>
    /// Ui Command to open the running UI.
    /// </summary>
    class StartRunningUiCommand : ICommand
    {
        private readonly IUnityContainer unityContainer;

        public StartRunningUiCommand(IUnityContainer unityContainer)
        {
            this.unityContainer = unityContainer;
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
            unityContainer.Resolve<IEnduranceMainView>().Show();
        }
    }
}
