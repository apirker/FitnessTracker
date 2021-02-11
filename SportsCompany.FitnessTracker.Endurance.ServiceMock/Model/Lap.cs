using SportsCompany.FitnessTracker.Endurance.Contracts;
using System;

namespace SportsCompany.FitnessTracker.Endurance.WebApi.Dtos
{
    public class Lap : ILap
    {
        public double DistanceInKm { get; set; }

        public TimeSpan Duration { get; set; }
    }
}
