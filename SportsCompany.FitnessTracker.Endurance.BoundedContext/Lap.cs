using SportsCompany.FitnessTracker.Endurance.Contracts;
using System;

namespace SportsCompany.FitnessTracker.Endurance.BoundedContext
{
    class Lap : ILap
    {
        public Lap(double distanceInKm, TimeSpan duration)
        {
            if (distanceInKm > 1)
                throw new InvalidOperationException("Laps must be smaller than 1km!");

            DistanceInKm = distanceInKm;
            Duration = duration;
        }

        public double DistanceInKm { get; }
        public TimeSpan Duration { get; }
    }
}
