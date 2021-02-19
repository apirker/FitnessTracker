using System.Windows.Input;
using Unity;

namespace SportsCompany.FitnessTracker.DesktopClient
{
    /// <summary>
    /// Main view model of the first window.
    /// </summary>
    public class MainWindowViewModel
    {
        /// <summary>
        /// Ui command to open the HIIT area.
        /// </summary>
        [Dependency(nameof(UiCommands.StartHiitUiCommand))]
        public ICommand StartHiitUiCommand { get; set; }

        /// <summary>
        /// Ui command to open the running.
        /// </summary>
        [Dependency(nameof(UiCommands.StartRunningUiCommand))]
        public ICommand StartRunningUiCommand { get; set; }
    }
}
