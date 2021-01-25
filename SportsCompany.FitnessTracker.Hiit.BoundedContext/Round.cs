using SportsCompany.FitnessTracker.Hiit.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SportsCompany.FitnessTracker.Hiit.BoundedContext
{
    class Round : IRound
    {
        private IList<Exercise> exercises = new List<Exercise>();
        private int pauseInSecBetweenExercises;

        public IList<IExercise> Exercises => exercises.Select(e => e as IExercise).ToList();
        public int PauseInSecBetweenExercises => pauseInSecBetweenExercises;

        internal void AddExercise(Exercise exercise)
        {
            exercises.Add(exercise);
        }

        internal void RemoveExercise(IExercise exercise)
        {
            exercises.Remove((Exercise)exercise);
        }

        internal void SetPauseInSecBetweenExercises(int value)
        {
            if (value <= 0)
                throw new InvalidOperationException();

            pauseInSecBetweenExercises = value;
        }
    }
}
