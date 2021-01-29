using SportsCompany.FitnessTracker.Hiit.Contracts;
using SportsCompany.FitnessTracker.Hiit.Contracts.AntiCorruption;

namespace SportsCompany.FitnessTracker.Hiit.BoundedContext
{
    class TrainingExecutor : ITrainingExecutor
    {
        private readonly ITrainingRepository trainingRepository;
        private readonly HiitDataService hiitDataService;

        public TrainingExecutor(ITrainingRepository trainingRepository, HiitDataService hiitDataService)
        {
            this.trainingRepository = trainingRepository;
            this.hiitDataService = hiitDataService;
        }
        public void Start(string name)
        {
            var training = (Training) trainingRepository.FindTrainingByName(name);
            training.Start(hiitDataService);
        }

        public void Stop(string name)
        {
            var training = (Training)trainingRepository.FindTrainingByName(name);
            training.Stop(hiitDataService);

            trainingRepository.Update(training);
        }
    }
}
