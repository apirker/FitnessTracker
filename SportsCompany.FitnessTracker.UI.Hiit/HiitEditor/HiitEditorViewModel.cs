using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Unity;

namespace SportsCompany.FitnessTracker.UI.Hiit.HiitEditor
{
    /// <summary>
    /// View model for creating a new HIIT workout.
    /// </summary>
    class HiitEditorViewModel : INotifyPropertyChanged
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
                if (name == value) return;

                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private string roundSpecification;

        /// <summary>
        /// Input string to specify the next round of the HIIT workout.
        /// </summary>
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

        /// <summary>
        /// Collection of all rounds which are part of the HIIT workout.
        /// </summary>
        public ObservableCollection<RoundViewModel> Rounds { get; } = new ObservableCollection<RoundViewModel>();

        /// <summary>
        /// Ui command to add a round to the HIIT workout.
        /// </summary>
        [Dependency(nameof(UiCommands.AddRoundUiCommand))]
        public ICommand AddRoundUiCommand { get; set; }

        /// <summary>
        /// Ui command to save the HIIT workout.
        /// </summary>
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
