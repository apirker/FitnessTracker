namespace SportsCompany.FitnessTracker.Hiit.Contracts
{
    /// <summary>
    /// Service interface to plan HIIT trainigs.
    /// </summary>
    public interface ITrainingPlanner
    {
        /// <summary>
        /// Creates a new training for the provided name.
        /// </summary>
        /// <param name="name">Name of the training.</param>
        /// <returns>A new training instance.</returns>
        ITraining NewTraining(string name);

        /// <summary>
        /// Adds a round to the training.
        /// </summary>
        void AddRound();

        /// <summary>
        /// Removes a round from the training.
        /// </summary>
        /// <param name="round">Round to be removed.</param>
        void RemoveRound(IRound round);

        /// <summary>
        /// Set the time between individual rounds.
        /// </summary>
        /// <param name="value">Pause in seconds between rounds.</param>
        void SetPauseBetweenRounds(int value);

        /// <summary>
        /// Set the pause between exercises for a given round.
        /// </summary>
        /// <param name="round">Round number.</param>
        /// <param name="value">Pause in seconds.</param>
        void SetPauseBetweenExercises(int round, int value);
        
        /// <summary>
        /// Adds an exercise to a given round.
        /// </summary>
        /// <param name="round">Round number.</param>
        /// <param name="name">Name of the exercise.</param>
        /// <param name="duration">Duration of the exercise.</param>
        void AddExercise(int round, string name, int duration);

        /// <summary>
        /// Removes the exercise from the training.
        /// </summary>
        /// <param name="round">Round number.</param>
        /// <param name="exercise">Exercise to be removed.</param>
        void RemoveExercise(int round, IExercise exercise);
    }
}
