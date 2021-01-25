using SportsCompany.FitnessTracker.Endurance.Contracts.AntiCorruption;

namespace SportsCompany.FitnessTracker.Endurance.Contracts
{
    public interface ITrainingService
    {
        void StartTraining(EnduranceDataService enduranceDataService);
        TrainingDto StopTraining();

        void SaveTraining();
    }
}
