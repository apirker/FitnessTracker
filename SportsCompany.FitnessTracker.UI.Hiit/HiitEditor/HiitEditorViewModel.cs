using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Unity;

namespace SportsCompany.FitnessTracker.UI.Hiit.HiitEditor
{
    class HiitEditorViewModel : INotifyPropertyChanged
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

        private string roundSpecification;
        public string RoundSpecification
        {
            get
            {
                return roundSpecification;
            }
            set
            {
                if (value == roundSpecification) return;

                roundSpecification = value;
                OnPropertyChanged(nameof(RoundSpecification));
            }
        }

        public ObservableCollection<RoundViewModel> Rounds { get; } = new ObservableCollection<RoundViewModel>();

        [Dependency(nameof(UiCommands.AddRoundUiCommand))]
        public ICommand AddRoundUiCommand { get; set; }

        [Dependency(nameof(UiCommands.SaveUiCommand))]
        public ICommand SaveUiCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(v));
        }
    }
}
