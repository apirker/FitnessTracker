using SportsCompany.FitnessTracker.Endurance.Contracts;
using SportsCompany.FitnessTracker.Endurance.Contracts.AntiCorruption;
using System;
using System.Windows.Input;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity.UiCommands
{
    class StartActivityUiCommand : ICommand
    {
        private readonly ITrainingService trainingService;
        private readonly EnduranceDataService enduranceDataService;

        public StartActivityUiCommand(ITrainingService trainingService, EnduranceDataService enduranceDataService)
        {
            this.trainingService = trainingService;
            this.enduranceDataService = enduranceDataService;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var viewModel = parameter as EnduranceActivityViewModel;
            if (viewModel is null)
                return;

            viewModel.State = "Running...";

            trainingService.StartTraining(enduranceDataService);
        }
    }
}
