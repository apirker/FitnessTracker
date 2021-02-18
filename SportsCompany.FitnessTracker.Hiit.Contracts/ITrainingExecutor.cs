namespace SportsCompany.FitnessTracker.Hiit.Contracts
{
    /// <summary>
    /// Service interface to start and stop trainings.
    /// </summary>
    public interface ITrainingExecutor
    {
        /// <summary>
        /// Starts a training with a given name.
        /// </summary>
        /// <param name="name">Name of the training.</param>
        void Start(string name);

        /// <summary>
        /// Stops a training with a given name.
        /// </summary>
        /// <param name="name">Name of the training.</param>
        void Stop(string name);
    }
}
