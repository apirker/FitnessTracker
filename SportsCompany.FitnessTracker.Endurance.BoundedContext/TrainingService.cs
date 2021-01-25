using SportsCompany.FitnessTracker.Endurance.Contracts;
using SportsCompany.FitnessTracker.Endurance.Contracts.AntiCorruption;

namespace SportsCompany.FitnessTracker.Endurance.BoundedContext
{
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

        public void StartTraining(EnduranceDataService enduranceDataService)
        {
            training = new Training(Type.Running);
            training.Start(enduranceDataService, gpsService);
        }

        public TrainingDto StopTraining()
        {
            training.Stop();

            var type = training.Type == Type.Biking
                ? TypeDto.Biking
                : TypeDto.Running;

            return new TrainingDto(training.Distance, training.Duration, training.TrainingsEffect, type);
        }

        public void SaveTraining()
        {
            trainingRepository.Add(training);
        }
    }
}
