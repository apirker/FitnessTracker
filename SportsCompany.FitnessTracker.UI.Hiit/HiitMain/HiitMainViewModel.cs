using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Unity;

namespace SportsCompany.FitnessTracker.UI.Hiit.HiitMain
{
    class HiitMainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<HiitTrainingViewModel> Trainings { get; } = new ObservableCollection<HiitTrainingViewModel>();

        private HiitTrainingViewModel selectedTraining;
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


        [Dependency(nameof(UiCommands.OpenSelectedTrainingCommand))]
        public ICommand OpenSelectedTrainingCommand { get; set; }

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
