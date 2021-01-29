using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace SportsCompany.FitnessTracker.UI.Hiit.HiitEditor
{
    class RoundViewModel : INotifyPropertyChanged
    {
        private int roundNumber;
        public int RoundNumber
        {
            get
            {
                return roundNumber;
            }
            set
            {
                if (roundNumber == value) return;

                roundNumber = value;
                OnPropertyChanged(nameof(RoundNumber));
            }
        }

        public ObservableCollection<ExerciseViewModel> Exercises { get; } = new ObservableCollection<ExerciseViewModel>();

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(v));
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append($"{roundNumber}. Round: ");

            foreach(var exercise in Exercises)
                stringBuilder.Append($"{exercise.Name} for {exercise.Duration}s, ");
            
            return stringBuilder.ToString();
        }
    }
}
