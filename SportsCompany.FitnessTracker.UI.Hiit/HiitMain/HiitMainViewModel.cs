using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Unity;

namespace SportsCompany.FitnessTracker.UI.Hiit.HiitMain
{
    /// <summary>
    /// View model of the main view of the HIIT user interface part.
    /// </summary>
    class HiitMainViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Collection of trainings which the user created.
        /// </summary>
        public ObservableCollection<HiitTrainingViewModel> Trainings { get; } = new ObservableCollection<HiitTrainingViewModel>();

        private HiitTrainingViewModel selectedTraining;

        /// <summary>
        /// Training which the user selected in the list.
        /// </summary>
        public HiitTrainingViewModel SelectedTraining
        {
            get
            {
                return selectedTraining;
            }
            set
            {
                if (selectedTraining == value) return;

                selectedTraining = value;
                OnPropertyChanged(nameof(SelectedTraining));
            }
        }

        /// <summary>
        /// Ui command to open a selected training for performing the workout.
        /// </summary>
        [Dependency(nameof(UiCommands.OpenSelectedTrainingCommand))]
        public ICommand OpenSelectedTrainingCommand { get; set; }

        /// <summary>
        /// Ui command to open the view to create a new training.
        /// </summary>
        [Dependency(nameof(UiCommands.OpenCreateNewTrainingCommand))]
        public ICommand OpenCreateNewTrainingCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(v));
        }
    }
}
