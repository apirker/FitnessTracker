using System;
using System.ComponentModel;
using System.Windows.Input;
using Unity;

namespace SportsCompany.FitnessTracker.UI.Hiit.HiitTraing
{
    class HiitTrainViewModel : INotifyPropertyChanged
    {
        private string name;
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

        [Dependency(nameof(StartTrainingUiCommand))]
        public ICommand StartTrainingUiCommand { get; set; }

        [Dependency(nameof(StopTrainingUiCommand))]
        public ICommand StopTrainingUiCommand { get; set; }

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
