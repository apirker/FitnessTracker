using SportsCompany.FitnessTracker.Hiit.Contracts;
using SportsCompany.FitnessTracker.Hiit.Contracts.AntiCorruption;

namespace SportsCompany.FitnessTracker.Hiit.BoundedContext
{
    /// <summary>
    /// This class implements the service to execute HIIT trainings.
    /// </summary>
    class TrainingExecutor : ITrainingExecutor
    {
        private readonly ITrainingRepository trainingRepository;
        private readonly HiitDataService hiitDataService;

        public TrainingExecutor(ITrainingRepository trainingRepository, HiitDataService hiitDataService)
        {
            this.trainingRepository = trainingRepository;
            this.hiitDataService = hiitDataService;
        }

        /// <summary>
        /// Starts a training with a given name.
        /// </summary>
        /// <param name="name">Name of the training.</param>
        public void Start(string name)
        {
            var training = (Training) trainingRepository.FindTrainingByName(name);
            training.Start(hiitDataService);
        }

        /// <summary>
        /// Stops a training with a given name.
        /// </summary>
        /// <param name="name">Name of the training.</param>
        public void Stop(string name)
        {
            var training = (Training)trainingRepository.FindTrainingByName(name);
            training.Stop(hiitDataService);

            trainingRepository.Update(training);
        }
    }
}
