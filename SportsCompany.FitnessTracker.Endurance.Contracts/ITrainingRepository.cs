using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Endurance.Contracts
{
    /// <summary>
    /// This interface abstracts the access to databases within the endurance bounded-context.
    /// </summary>
    public interface ITrainingRepository
    {
        /// <summary>
        /// Adds a training to the database.
        /// </summary>
        /// <param name="training">Training.</param>
        void Add(ITraining training);

        /// <summary>
        /// Updates a training in the database.
        /// </summary>
        /// <param name="training">Training.</param>
        void Update(ITraining training);

        /// <summary>
        /// Deletes a training from the database.
        /// </summary>
        /// <param name="training">Training.</param>
        void Delete(ITraining training);

        /// <summary>
        /// Returns all trainings from the database.
        /// </summary>
        /// <returns>Collection of all trainings within the database.</returns>
        IList<ITraining> GetAll();
    }
}
