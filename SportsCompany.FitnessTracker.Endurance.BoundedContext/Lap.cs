using SportsCompany.FitnessTracker.Endurance.Contracts;
using System;

namespace SportsCompany.FitnessTracker.Endurance.BoundedContext
{
    /// <summary>
    /// Value-object for a lap.
    /// </summary>
    class Lap : ILap
    {
        public Lap(double distanceInKm, TimeSpan duration)
        {
            if (distanceInKm > 1)
                throw new InvalidOperationException("Laps must be smaller than 1km!");

            DistanceInKm = distanceInKm;
            Duration = duration;
        }

        /// <summary>
        /// Distance in kilometers of the lap.
        /// </summary>
        public double DistanceInKm { get; }

        /// <summary>
        /// Duration of the lap to complete.
        /// </summary>
        public TimeSpan Duration { get; }
    }
}
