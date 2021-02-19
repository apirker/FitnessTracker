using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Unity;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceMain
{
    /// <summary>
    /// View model of the main view of the endurance user interface part.
    /// </summary>
    class EnduranceMainViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Collection of all endurance activities which where recorded.
        /// </summary>
        public ObservableCollection<EnduranceViewModel> EnduranceItems { get; } = new ObservableCollection<EnduranceViewModel>();

        /// <summary>
        /// Ui command to open a new endurance activity view.
        /// </summary>
        [Dependency(nameof(UiCommands.OpenNewEnduranceUiCommand))]
        public ICommand OpenNewEnduranceUiCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(v));
        }
    }
}
