using SportsCompany.FitnessTracker.UI.Endurance.EnduranceMain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Unity;

namespace SportsCompany.FitnessTracker.DesktopClient.UiCommands
{
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

        public void Execute(object parameter)
        {
            unityContainer.Resolve<IEnduranceMainView>().Show();
        }
    }
}
