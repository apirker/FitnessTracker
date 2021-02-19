using SportsCompany.FitnessTracker.Hiit.Contracts;
using System;
using System.Windows;
using System.Windows.Input;

namespace SportsCompany.FitnessTracker.UI.Hiit.HiitEditor.UiCommands
{
    /// <summary>
    /// Ui command to save the created HIIT workout.
    /// </summary>
    class SaveUiCommand : ICommand
    {
        private readonly ITrainingPlanner trainingPlanner;
        private readonly ITrainingRepository trainingRepository;
        private readonly IHiitEditorView hiitEditorView;

        public SaveUiCommand(ITrainingPlanner trainingPlanner, ITrainingRepository trainingRepository, IHiitEditorView hiitEditorView)
        {
            this.trainingPlanner = trainingPlanner;
            this.trainingRepository = trainingRepository;
            this.hiitEditorView = hiitEditorView;
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
                var viewModel = parameter as HiitEditorViewModel;
                if (viewModel == null)
                    return;

                var training = trainingPlanner.NewTraining(viewModel.Name);

                foreach (var round in viewModel.Rounds)
                {
                    trainingPlanner.AddRound();

                    foreach (var exercise in round.Exercises)
                        trainingPlanner.AddExercise(round.RoundNumber - 1, exercise.Name, exercise.Duration);
                }

                trainingRepository.Add(training);
                hiitEditorView.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong on saving the activity.");
            }
        }
    }
}
