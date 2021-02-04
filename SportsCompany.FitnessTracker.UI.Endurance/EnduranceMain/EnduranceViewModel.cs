using System;
using System.ComponentModel;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceMain
{
    class EnduranceViewModel : INotifyPropertyChanged
    {
        private int laps;
        public int Laps
        {
            get
            {
                return laps;
            }
            set
            {
                if (laps == value) return;

                laps = value;
                OnPropertyChanged(nameof(Laps));
            }
        }

        private double average;
        public double Average
        {
            get
            {
                return average;
            }
            set
            {
                if (average == value) return;

                average = value;
                OnPropertyChanged(nameof(Average));
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

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(v));
        }

        public override string ToString()
        {
            return $"Average heart rate {average} for {laps} laps with training effect is {TrainingEffect}";
        }
    }
}
