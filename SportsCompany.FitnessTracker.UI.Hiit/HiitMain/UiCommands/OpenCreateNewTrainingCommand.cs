﻿using SportsCompany.FitnessTracker.Hiit.Contracts;
using SportsCompany.FitnessTracker.UI.Hiit.HiitEditor;
using System;
using System.Windows.Input;
using Unity;

namespace SportsCompany.FitnessTracker.UI.Hiit.HiitMain.UiCommands
{
    class OpenCreateNewTrainingCommand : ICommand
    {
        private readonly IUnityContainer unityContainer;

        public OpenCreateNewTrainingCommand(IUnityContainer unityContainer)
        {
            this.unityContainer = unityContainer;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var view = unityContainer.Resolve<IHiitEditorView>();
            view.ViewClosed += View_ViewClosed;
            view.Show();
        }

        private void View_ViewClosed(object sender, EventArgs e)
        {
            var view = (IHiitEditorView)sender;
            view.ViewClosed -= View_ViewClosed;

            var trainingRepository = unityContainer.Resolve<ITrainingRepository>();
            var viewModel = unityContainer.Resolve<HiitMainViewModel>();

            viewModel.Trainings.Clear();

            var trainings = trainingRepository.GetAll();
            foreach(var training in trainings)
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
