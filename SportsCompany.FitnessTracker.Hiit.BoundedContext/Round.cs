using SportsCompany.FitnessTracker.Hiit.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SportsCompany.FitnessTracker.Hiit.BoundedContext
{
    /// <summary>
    /// This class implements the round entity from the HIIT bounded-context.
    /// </summary>
    class Round : IRound
    {
        private IList<Exercise> exercises = new List<Exercise>();
        private int pauseInSecBetweenExercises;

        /// <summary>
        /// List of exercises which comprises a round.
        /// </summary>
        public IList<IExercise> Exercises => exercises.Select(e => e as IExercise).ToList();

        /// <summary>
        /// Pause between the exercises in seconds.
        /// </summary>
        public int PauseInSecBetweenExercises => pauseInSecBetweenExercises;

        /// <summary>
        /// Adds an exercise to a round.
        /// </summary>
        internal void AddExercise(Exercise exercise)
        {
            exercises.Add(exercise);
        }

        /// <summary>
        /// Removes an exercise from a round.
        /// </summary>
        internal void RemoveExercise(IExercise exercise)
        {
            exercises.Remove((Exercise)exercise);
        }

        /// <summary>
        /// Sets the pause between exercises for this round.
        /// </summary>
        internal void SetPauseInSecBetweenExercises(int value)
        {
            if (value <= 0)
                throw new InvalidOperationException();

            pauseInSecBetweenExercises = value;
        }
    }
}
