using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Unity;

namespace SportsCompany.FitnessTracker.DesktopClient
{
    public class MainWindowViewModel
    {
        [Dependency(nameof(UiCommands.StartHiitUiCommand))]
        public ICommand StartHiitUiCommand { get; set; }

        [Dependency(nameof(UiCommands.StartRunningUiCommand))]
        public ICommand StartRunningUiCommand { get; set; }
    }
}
