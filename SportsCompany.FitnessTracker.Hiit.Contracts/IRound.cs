using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Hiit.Contracts
{
    /// <summary>
    /// This interface defines the visible data for rounds.
    /// </summary>
    public interface IRound
    {
        /// <summary>
        /// List of exercises which comprises a round.
        /// </summary>
        IList<IExercise> Exercises { get; }

        /// <summary>
        /// Pause between the exercises in seconds.
        /// </summary>
        int PauseInSecBetweenExercises { get; }
    }
}
