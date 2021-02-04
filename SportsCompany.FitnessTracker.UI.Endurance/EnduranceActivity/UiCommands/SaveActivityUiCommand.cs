using SportsCompany.FitnessTracker.Endurance.Contracts;
using System;
using System.Windows.Input;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity.UiCommands
{
    class SaveActivityUiCommand : ICommand
    {
        private readonly IEnduranceActivityView view;
        private readonly ITrainingService trainingService;

        public SaveActivityUiCommand(IEnduranceActivityView view, ITrainingService trainingService)
        {
            this.view = view;
            this.trainingService = trainingService;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            trainingService.SaveTraining();
            view.Close();
        }
    }
}
