using SportsCompany.FitnessTracker.Hiit.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace SportsCompany.FitnessTracker.Hiit.WinEnvironment
{
    /// <summary>
    /// In-memory repository for HIIT trainings.
    /// </summary>
    class TrainingRepository : ITrainingRepository
    {
        private IList<ITraining> repository = new List<ITraining>();

        /// <summary>
        /// Add a training.
        /// </summary>
        /// <param name="training">Training.</param>
        public void Add(ITraining training)
        {
            if (!repository.Contains(training))
                repository.Add(training);
        }

        /// <summary>
        /// Deletes a training.
        /// </summary>
        /// <param name="training">Training.</param>
        public void Delete(ITraining training)
        {
            if (repository.Contains(training))
                repository.Remove(training);
        }

        /// <summary>
        /// Find a training for a given name.
        /// </summary>
        /// <param name="name">Name of the training.</param>
        public ITraining FindTrainingByName(string name)
        {
            return repository.FirstOrDefault(t => t.Name == name);
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
