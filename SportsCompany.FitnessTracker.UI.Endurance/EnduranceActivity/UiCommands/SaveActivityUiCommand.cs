using SportsCompany.FitnessTracker.Endurance.Contracts;
using System;
using System.Windows;
using System.Windows.Input;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity.UiCommands
{
    /// <summary>
    /// Ui Command to to save the last endurance activity.
    /// </summary>
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

        /// <summary>
        /// Command execution.
        /// </summary>
        public void Execute(object parameter)
        {
            try
            {
                trainingService.SaveTraining();
                view.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Something went wrong on saving the activity.");
            }
        }
    }
}
