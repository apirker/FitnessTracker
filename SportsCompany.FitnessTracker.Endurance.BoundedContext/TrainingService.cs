using SportsCompany.FitnessTracker.Endurance.Contracts;
using SportsCompany.FitnessTracker.Endurance.Contracts.AntiCorruption;

namespace SportsCompany.FitnessTracker.Endurance.BoundedContext
{
    /// <summary>
    /// Application service to interact with training aggregate.
    /// </summary>
    class TrainingService : ITrainingService
    {
        public TrainingService(ITrainingRepository trainingRepository, IGpsService gpsService)
        {
            this.trainingRepository = trainingRepository;
            this.gpsService = gpsService;
        }

        private Training training;
        
        private readonly ITrainingRepository trainingRepository;
        private readonly IGpsService gpsService;

        /// <summary>
        /// Starts a new training.
        /// </summary>
        /// <param name="enduranceDataService">Service to communicate with the peripheral.</param>
        public void StartTraining(EnduranceDataService enduranceDataService)
        {
            training = new Training(Type.Running);
            training.Start(enduranceDataService, gpsService);
        }

        /// <summary>
        /// Stops the current training.
        /// </summary>
        /// <returns>A summary of the training.</returns>
        public TrainingDto StopTraining()
        {
            training.Stop();

            var type = training.Type == Type.Biking
                ? TypeDto.Biking
                : TypeDto.Running;

            return new TrainingDto(training.Distance, training.Duration, training.TrainingsEffect, type);
        }

        /// <summary>
        /// Saves the last training.
        /// </summary>
        public void SaveTraining()
        {
            trainingRepository.Add(training);
        }
    }
}
