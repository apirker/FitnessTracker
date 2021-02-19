using System;
using System.ComponentModel;

namespace SportsCompany.FitnessTracker.UI.Hiit.HiitMain
{
    /// <summary>
    /// View model of an individual HIIT training.
    /// </summary>
    public class HiitTrainingViewModel : INotifyPropertyChanged
    {
        private string name;

        /// <summary>
        /// Name of the HIIT workout.
        /// </summary>
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

        /// <summary>
        /// Number of rounds which this HIIT workout comprises.
        /// </summary>
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
        
        /// <summary>
        /// Last duration the athlete needed to completed the workout.
        /// </summary>
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
