namespace SportsCompany.FitnessTracker.Hiit.Contracts
{
    public interface IExercise
    {
        string ExerciseName { get; }
        int DurationInSec { get; }
    }
}
