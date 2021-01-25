using SportsCompany.FitnessTracker.Hiit.Contracts;

namespace SportsCompany.FitnessTracker.Hiit.BoundedContext
{
    class Exercise : IExercise
    {
        private readonly string exerciseName;
        private readonly int durationInSec;

        public Exercise(string exerciseName, int durationInSec)
        {
            this.exerciseName = exerciseName;
            this.durationInSec = durationInSec;
        }

        public string ExerciseName => exerciseName;
        public int DurationInSec => durationInSec;
    }
}
