using System;

namespace SportsCompany.FitnessTracker.Endurance.Contracts
{
    public interface ILap
    {
        double DistanceInKm { get; }
        TimeSpan Duration { get; }
    }
}
