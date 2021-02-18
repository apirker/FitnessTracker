using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Hiit.Contracts
{
    /// <summary>
    /// This port interface abstracts the way to perist HIIT trainings for the bounded-context.
    /// </summary>
    public interface ITrainingRepository
    {
        /// <summary>
        /// Add a training.
        /// </summary>
        /// <param name="training">Training.</param>
        void Add(ITraining training);

        /// <summary>
        /// Updates a training.
        /// </summary>
        /// <param name="training">Training.</param>
        void Update(ITraining training);

        /// <summary>
        /// Deletes a training.
        /// </summary>
        /// <param name="training">Training.</param>
        void Delete(ITraining training);

        /// <summary>
        /// Find a training for a given name.
        /// </summary>
        /// <param name="name">Name of the training.</param>
        ITraining FindTrainingByName(string name);

        /// <summary>
        /// Returns all trainings.
        /// </summary>
        IList<ITraining> GetAll();
    }
}
