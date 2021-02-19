using SportsCompany.FitnessTracker.Hiit.Contracts;
using SportsCompany.FitnessTracker.UI.Hiit.HiitTraing;
using System;
using System.Windows;
using System.Windows.Input;
using Unity;

namespace SportsCompany.FitnessTracker.UI.Hiit.HiitMain.UiCommands
{
    /// <summary>
    /// Ui command to start the selected HIIT workout in a new view.
    /// </summary>
    class OpenSelectedTrainingCommand : ICommand
    {
        private readonly IUnityContainer unityContainer;

        public OpenSelectedTrainingCommand(IUnityContainer unityContainer)
        {
            this.unityContainer = unityContainer;
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
                var viewModel = parameter as HiitMainViewModel;
                if (viewModel == null || viewModel.SelectedTraining == null)
                    return;

                var view = unityContainer.Resolve<IHiitTrainView>();
                view.ViewClosed += View_ViewClosed;
                view.Show(viewModel.SelectedTraining.Name);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong on opening the selected activity.");
            }
        }

        private void View_ViewClosed(object sender, EventArgs e)
        {
            var view = (IHiitTrainView)sender;
            view.ViewClosed -= View_ViewClosed;

            var trainingRepository = unityContainer.Resolve<ITrainingRepository>();
            var viewModel = unityContainer.Resolve<HiitMainViewModel>();

            viewModel.Trainings.Clear();

            var trainings = trainingRepository.GetAll();
            foreach (var training in trainings)
            {
                var trainingViewModel = new HiitTrainingViewModel()
                {
                    Name = training.Name,
                    NumberOfRounds = training.Rounds.Count,
                    LastDuration = training.LastDuration
                };

                viewModel.Trainings.Add(trainingViewModel);
            }
        }
    }
}
