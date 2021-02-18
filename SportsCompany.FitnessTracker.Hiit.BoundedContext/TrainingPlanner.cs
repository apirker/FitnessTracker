using SportsCompany.FitnessTracker.Hiit.Contracts;
using System;

namespace SportsCompany.FitnessTracker.Hiit.BoundedContext
{
    /// <summary>
    /// This class implements the service to plan trainings.
    /// </summary>
    class TrainingPlanner : ITrainingPlanner
    {
        private Training training;

        /// <summary>
        /// Adds an exercise to a given round.
        /// </summary>
        /// <param name="round">Round number.</param>
        /// <param name="name">Name of the exercise.</param>
        /// <param name="duration">Duration of the exercise.</param>
        public void AddExercise(int round, string name, int duration)
        {
            ThrowIfTrainingNotCreated();
            training.AddExercise(round, name, duration);
        }

        /// <summary>
        /// Removes the exercise from the training.
        /// </summary>
        /// <param name="round">Round number.</param>
        /// <param name="exercise">Exercise to be removed.</param>
        public void RemoveExercise(int round, IExercise exercise)
        {
            ThrowIfTrainingNotCreated();
            training.RemoveExercise(round, exercise);
        }

        /// <summary>
        /// Adds a round to the training.
        /// </summary>
        public void AddRound()
        {
            ThrowIfTrainingNotCreated();
            training.AddRound();
        }

        /// <summary>
        /// Removes a round from the training.
        /// </summary>
        /// <param name="round">Round to be removed.</param>
        public void RemoveRound(IRound round)
        {
            ThrowIfTrainingNotCreated();
            training.RemoveRound(round);
        }

        /// <summary>
        /// Set the pause between exercises for a given round.
        /// </summary>
        /// <param name="round">Round number.</param>
        /// <param name="value">Pause in seconds.</param>
        public void SetPauseBetweenExercises(int round, int value)
        {
            ThrowIfTrainingNotCreated();
            training.SetPauseBetweenExercises(round, value);
        }

        /// <summary>
        /// Set the time between individual rounds.
        /// </summary>
        /// <param name="value">Pause in seconds between rounds.</param>
        public void SetPauseBetweenRounds(int value)
        {
            ThrowIfTrainingNotCreated();
            training.SetPauseBetweenRounds(value);
        }

        /// <summary>
        /// Creates a new training for the provided name.
        /// </summary>
        /// <param name="name">Name of the training.</param>
        /// <returns>A new training instance.</returns>
        public ITraining NewTraining(string name)
        {
            training = new Training(name);
            return training;
        }

        private void ThrowIfTrainingNotCreated()
        {
            if (training == null)
                throw new InvalidOperationException();
        }
    }
}
