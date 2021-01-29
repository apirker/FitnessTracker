using System.ComponentModel;

namespace SportsCompany.FitnessTracker.UI.Hiit.HiitEditor
{
    class ExerciseViewModel : INotifyPropertyChanged
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

        private int duration;
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
