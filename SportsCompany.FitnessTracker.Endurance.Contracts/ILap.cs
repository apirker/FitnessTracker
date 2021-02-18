using System;

namespace SportsCompany.FitnessTracker.Endurance.Contracts
{
    /// <summary>
    /// This interface defines the visible data for a lap.
    /// </summary>
    public interface ILap
    {
        /// <summary>
        /// Distance in kilometer of the lap.
        /// </summary>
        double DistanceInKm { get; }

        /// <summary>
        /// Duration which it took to complete the lap.
        /// </summary>
        TimeSpan Duration { get; }
    }
}
