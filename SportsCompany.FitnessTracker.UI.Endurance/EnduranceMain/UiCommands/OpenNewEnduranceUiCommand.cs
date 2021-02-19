using SportsCompany.FitnessTracker.Endurance.Contracts;
using SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity;
using System;
using System.Windows;
using System.Windows.Input;
using Unity;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceMain.UiCommands
{
    /// <summary>
    /// Ui Command to open a new endurance activity.
    /// </summary>
    class OpenNewEnduranceUiCommand : ICommand
    {
        private readonly IUnityContainer unityContainer;

        public OpenNewEnduranceUiCommand(IUnityContainer unityContainer)
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
                var view = unityContainer.Resolve<IEnduranceActivityView>();
                view.ViewClosed += View_ViewClosed;
                view.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong on opening the activity.");
            }
        }

        private void View_ViewClosed(object sender, EventArgs e)
        {
            var view = sender as IEnduranceActivityView;
            if (view == null)
                return;

            view.ViewClosed -= View_ViewClosed;

            var viewModel = unityContainer.Resolve<EnduranceMainViewModel>();
            viewModel.EnduranceItems.Clear();

            try
            {
                var trainingRepository = unityContainer.Resolve<ITrainingRepository>();
                var trainings = trainingRepository.GetAll();

                foreach (var training in trainings)
                {
                    var enduranceViewModel = new EnduranceViewModel()
                    {
                        Laps = training.Laps.Count,
                        Average = training.HeartRate.Avergage,
                        TrainingEffect = training.TrainingsEffect
                    };

                    viewModel.EnduranceItems.Add(enduranceViewModel);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong on getting activities.");
            }
}
    }
}
