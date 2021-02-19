using SportsCompany.FitnessTracker.Endurance.Contracts;
using System;
using System.Windows;
using System.Windows.Input;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity.UiCommands
{
    /// <summary>
    /// Ui Command to open the stop the last endurance activity.
    /// </summary>
    class StopActivityUiCommand : ICommand
    {
        private readonly ITrainingService trainingService;

        public StopActivityUiCommand(ITrainingService trainingService)
        {
            this.trainingService = trainingService;
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
                if (viewModel == null)
                    return;

                viewModel.State = "Stopped";

                var result = trainingService.StopTraining();

                viewModel.Distance = result.Distance;
                viewModel.Duration = result.Duration;
                viewModel.TrainingEffect = result.TrainingEffect;
            }
            catch(Exception)
            {
                MessageBox.Show("Something went wrong on stoping the activity.");
            }
}
    }
}
