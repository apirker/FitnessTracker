namespace SportsCompany.FitnessTracker.Hiit.Contracts
{
    /// <summary>
    /// This interface defines the visible data for exercises.
    /// </summary>
    public interface IExercise
    {
        /// <summary>
        /// Name of the exercise.
        /// </summary>
        string ExerciseName { get; }

        /// <summary>
        /// Duration of the exercise in seconds.
        /// </summary>
        int DurationInSec { get; }
    }
}
