using System;
using System.ComponentModel;
using System.Windows.Input;
using Unity;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity
{
    class EnduranceActivityViewModel : INotifyPropertyChanged
    {
        private string state;
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                if (state == value) return;

                state = value;
                OnPropertyChanged(nameof(State));
            }
        }

        private double distance;
        public double Distance
        {
            get
            {
                return distance;
            }
            set
            {
                if (distance == value) return;

                distance = value;
                OnPropertyChanged(nameof(Distance));
            }
        }

        private TimeSpan duration;
        public TimeSpan Duration
        {
            get
            {
                return duration;
            }
            set
            {
                if (duration == value) return;

                duration = value;
                OnPropertyChanged(nameof(Duration));
            }
        }

        private double trainingEffect;
        public double TrainingEffect
        {
            get
            {
                return trainingEffect;
            }
            set
            {
                if (trainingEffect == value) return;

                trainingEffect = value;
                OnPropertyChanged(nameof(TrainingEffect));
            }
        }

        [Dependency(nameof(UiCommands.StartActivityUiCommand))]
        public ICommand StartActivityUiCommand { get; set; }

        [Dependency(nameof(UiCommands.StopActivityUiCommand))]
        public ICommand StopActivityUiCommand { get; set; }

        [Dependency(nameof(UiCommands.SaveActivityUiCommand))]
        public ICommand SaveActivityUiCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(v));
        }
    }
}
