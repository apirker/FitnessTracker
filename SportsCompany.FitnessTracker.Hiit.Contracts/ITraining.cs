using System;
using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Hiit.Contracts
{
    /// <summary>
    /// This interface defines the visible data for trainings in the HIIT sub-domain.
    /// </summary>
    public interface ITraining
    {
        /// <summary>
        /// Name of the training.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Last duration of the training.
        /// </summary>
        TimeSpan? LastDuration { get; }

        /// <summary>
        /// Heart rate of the last training.
        /// </summary>
        IHeartRate HeartRate { get; }

        /// <summary>
        /// Pause between individual rounds of the training.
        /// </summary>
        int PauseInSecBetweenRounds { get; }

        /// <summary>
        /// List of rounds which comprise the training.
        /// </summary>
        IList<IRound> Rounds { get; }
    }
}
