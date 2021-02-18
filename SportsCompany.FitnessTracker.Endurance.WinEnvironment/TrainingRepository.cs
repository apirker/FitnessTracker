using SportsCompany.FitnessTracker.Endurance.Contracts;
using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Endurance.WinEnvironment
{
    /// <summary>
    /// In-memory implementation of the training repository.
    /// </summary>
    class TrainingRepository : ITrainingRepository
    {
        private IList<ITraining> repository = new List<ITraining>();

        /// <summary>
        /// Adds a training to the list.
        /// </summary>
        /// <param name="training">Training.</param>
        public void Add(ITraining training)
        {
            if (!repository.Contains(training))
                repository.Add(training);
        }

        /// <summary>
        /// Removes a training from the list.
        /// </summary>
        /// <param name="training">Training.</param>
        public void Delete(ITraining training)
        {
            if (repository.Contains(training))
                repository.Remove(training);
        }

        /// <summary>
        /// Returns all trainings.
        /// </summary>
        /// <returns></returns>
        public IList<ITraining> GetAll()
        {
            return repository;
        }

        /// <summary>
        /// Updates a training.
        /// </summary>
        /// <param name="training">Training.</param>
        public void Update(ITraining training)
        {
        }
    }
}
