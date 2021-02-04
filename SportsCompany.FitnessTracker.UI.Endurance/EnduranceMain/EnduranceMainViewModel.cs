using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Unity;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceMain
{
    class EnduranceMainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<EnduranceViewModel> EnduranceItems { get; } = new ObservableCollection<EnduranceViewModel>();

        [Dependency(nameof(UiCommands.OpenNewEnduranceUiCommand))]
        public ICommand OpenNewEnduranceUiCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(v));
        }
    }
}
