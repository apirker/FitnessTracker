using SportsCompany.FitnessTracker.Endurance.Contracts;
using SportsCompany.FitnessTracker.Endurance.Contracts.AntiCorruption;
using System;
using System.Windows;
using System.Windows.Input;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity.UiCommands
{
    /// <summary>
    /// Ui Command to start a new endurance activity within the domain.
    /// </summary>
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

        /// <summary>
        /// Command execution.
        /// </summary>
        public void Execute(object parameter)
        {
            try
            {
                var viewModel = parameter as EnduranceActivityViewModel;
                if (viewModel is null)
                    return;

                viewModel.State = "Running...";

                trainingService.StartTraining(enduranceDataService);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong on starting the activity.");
            }
        }
    }
}
