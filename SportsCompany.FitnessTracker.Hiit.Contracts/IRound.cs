using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Hiit.Contracts
{
    public interface IRound
    {
        IList<IExercise> Exercises { get; }

        int PauseInSecBetweenExercises { get; }
    }
}
