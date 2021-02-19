using SportsCompany.FitnessTracker.Hiit.Contracts;
using System;
using System.Windows;
using System.Windows.Input;

namespace SportsCompany.FitnessTracker.UI.Hiit.HiitTraing.UiCommands
{
    /// <summary>
    /// Ui command to stop the HIIT training.
    /// </summary>
    class StopTrainingUiCommand : ICommand
    {
        private readonly ITrainingExecutor trainingExecutor;
        private readonly ITrainingRepository trainingRepository;

        public StopTrainingUiCommand(ITrainingExecutor trainingExecutor, ITrainingRepository trainingRepository)
        {
            this.trainingExecutor = trainingExecutor;
            this.trainingRepository = trainingRepository;
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
            var viewModel = parameter as HiitTrainViewModel;
            if (viewModel == null)
                return;

            trainingExecutor.Stop(viewModel.Name);

            var training = trainingRepository.FindTrainingByName(viewModel.Name);
            viewModel.Duration = training.LastDuration;
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong on stoping the activity.");
            }

        }
    }
}
