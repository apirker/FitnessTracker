﻿using SportsCompany.FitnessTracker.Endurance.Contracts;
using System;
using System.Windows.Input;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity.UiCommands
{
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

        public void Execute(object parameter)
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
    }
}