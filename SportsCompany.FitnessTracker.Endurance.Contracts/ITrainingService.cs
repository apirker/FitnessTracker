using SportsCompany.FitnessTracker.Endurance.Contracts.AntiCorruption;

namespace SportsCompany.FitnessTracker.Endurance.Contracts
{
    /// <summary>
    /// This interface abstracts the access to the bounded-context from an applications point of view.
    /// </summary>
    public interface ITrainingService
    {
        /// <summary>
        /// Starts a new training.
        /// </summary>
        /// <param name="enduranceDataService">Anti-corruption service to communicate with the peripheral.</param>
        void StartTraining(EnduranceDataService enduranceDataService);

        /// <summary>
        /// Stops the training.
        /// </summary>
        /// <returns>Data transfer object containing all information about the completed training.</returns>
        TrainingDto StopTraining();

        /// <summary>
        /// Save the last training to the database.
        /// </summary>
        void SaveTraining();
    }
}
