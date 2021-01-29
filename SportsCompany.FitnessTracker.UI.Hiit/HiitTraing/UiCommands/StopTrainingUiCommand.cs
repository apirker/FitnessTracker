using SportsCompany.FitnessTracker.Hiit.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SportsCompany.FitnessTracker.UI.Hiit.HiitTraing.UiCommands
{
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

        public void Execute(object parameter)
        {
            var viewModel = parameter as HiitTrainViewModel;
            if (viewModel == null)
                return;

            trainingExecutor.Stop(viewModel.Name);

            var training = trainingRepository.FindTrainingByName(viewModel.Name);
            viewModel.Duration = training.LastDuration;


        }
    }
}
