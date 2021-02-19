using System.ComponentModel;

namespace SportsCompany.FitnessTracker.UI.Hiit.HiitEditor
{
    /// <summary>
    /// View model of an individual exercise.
    /// </summary>
    class ExerciseViewModel : INotifyPropertyChanged
    {
        private string name;

        /// <summary>
        /// Name of the exercise.
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

        private int duration;

        /// <summary>
        /// Duration in sec. of the exercise.
        /// </summary>
        public int Duration
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

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(v));
        }
    }
}
