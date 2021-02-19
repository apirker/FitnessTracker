using System;
using System.Windows;
using System.Windows.Input;

namespace SportsCompany.FitnessTracker.UI.Hiit.HiitEditor.UiCommands
{
    /// <summary>
    /// Ui command to add a round to a HIIT workout.
    /// </summary>
    class AddRoundUiCommand : ICommand
    {
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
            var viewModel = parameter as HiitEditorViewModel;
            if (viewModel == null)
                return;

            try
            {
                var roundViewModel = new RoundViewModel();
                roundViewModel.RoundNumber = viewModel.Rounds.Count + 1;

                var roundSpecification = viewModel.RoundSpecification;
                var exercises = roundSpecification.Split(';');

                foreach (var exercise in exercises)
                {
                    var exerciseStrings = exercise.Split(':');

                    var name = exerciseStrings[0];
                    var duration = int.Parse(exerciseStrings[1]);

                    var exerciseViewModel = new ExerciseViewModel()
                    {
                        Name = name,
                        Duration = duration
                    };

                    roundViewModel.Exercises.Add(exerciseViewModel);
                }

                viewModel.Rounds.Add(roundViewModel);
            }
            catch
            {
                MessageBox.Show("Rounds specification: {Exercise name 1}:{Duration as integer 1};{Exercise name 2}:{Duration as integer 2};...");
            }
        }

    }
}
