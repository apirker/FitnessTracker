using SportsCompany.FitnessTracker.Hiit.Contracts;

namespace SportsCompany.FitnessTracker.Hiit.BoundedContext
{
    /// <summary>
    /// This class implements the exercise entity from the HIIT bounded-context.
    /// </summary>
    class Exercise : IExercise
    {
        private readonly string exerciseName;
        private readonly int durationInSec;

        public Exercise(string exerciseName, int durationInSec)
        {
            this.exerciseName = exerciseName;
            this.durationInSec = durationInSec;
        }

        /// <summary>
        /// Name of the exercise.
        /// </summary>
        public string ExerciseName => exerciseName;

        /// <summary>
        /// Duration of the exercise in seconds.
        /// </summary>
        public int DurationInSec => durationInSec;
    }
}
