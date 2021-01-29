using System;
using System.ComponentModel;

namespace SportsCompany.FitnessTracker.UI.Hiit.HiitMain
{
    public class HiitTrainingViewModel : INotifyPropertyChanged
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
                if (value == name) return;

                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private int numberOfRounds;
        public int NumberOfRounds
        {
            get
            {
                return numberOfRounds;
            }
            set
            {
                if (value == numberOfRounds) return;

                numberOfRounds = value;
                OnPropertyChanged(nameof(NumberOfRounds));
            }
        }

        private TimeSpan? lastDuration;
        public TimeSpan? LastDuration
        {
            get
            {
                return lastDuration;
            }
            set
            {
                if (lastDuration == value) return;

                lastDuration = value;
                OnPropertyChanged(nameof(LastDuration));
            }
        }

        public override string ToString()
        {

            return LastDuration == null
                ? $"{Name} with {NumberOfRounds} rounds."
                : $"{Name} with {NumberOfRounds} rounds. Last duration was: {LastDuration}";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(v));
        }
    }
}
