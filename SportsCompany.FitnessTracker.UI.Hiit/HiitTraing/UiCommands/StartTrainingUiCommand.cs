﻿using SportsCompany.FitnessTracker.Hiit.Contracts;
using System;
using System.Windows;
using System.Windows.Input;

namespace SportsCompany.FitnessTracker.UI.Hiit.HiitTraing.UiCommands
{
    class StartTrainingUiCommand : ICommand
    {
        private readonly ITrainingExecutor trainingExecutor;

        public StartTrainingUiCommand(ITrainingExecutor trainingExecutor)
        {
            this.trainingExecutor = trainingExecutor;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            try
            {
                var viewModel = parameter as HiitTrainViewModel;
                if (viewModel == null)
                    return;

                trainingExecutor.Start(viewModel.Name);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong on starting the activity.");
            }
        }
    }
}
