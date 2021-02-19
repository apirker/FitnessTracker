using System;
using System.ComponentModel;
using System.Windows.Input;
using Unity;

namespace SportsCompany.FitnessTracker.UI.Hiit.HiitTraing
{
    /// <summary>
    /// View model for the HIIT training while its in progress.
    /// </summary>
    class HiitTrainViewModel : INotifyPropertyChanged
    {
        private string name;

        /// <summary>
        /// Name of the HIIT training.
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name == value) return;

                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private TimeSpan? duration;

        /// <summary>
        /// Duration of the training.
        /// </summary>
        public TimeSpan? Duration
        {
            get
            {
                return duration;
            }
            set
            {
                if (value == duration) return;

                duration = value;
                OnPropertyChanged(nameof(Duration));
            }
        }

        /// <summary>
        /// Ui command to start the HIIT training.
        /// </summary>
        [Dependency(nameof(StartTrainingUiCommand))]
        public ICommand StartTrainingUiCommand { get; set; }

        /// <summary>
        /// Ui command to stop the HIIT training.
        /// </summary>
        [Dependency(nameof(StopTrainingUiCommand))]
        public ICommand StopTrainingUiCommand { get; set; }

        /// <summary>
        /// Ui command to close the training view.
        /// </summary>
        [Dependency(nameof(CloseUiCommand))]
        public ICommand CloseUiCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(v));
        }
    }
}
