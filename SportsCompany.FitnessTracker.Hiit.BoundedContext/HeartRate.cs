using SportsCompany.FitnessTracker.Hiit.Contracts;
using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Hiit.BoundedContext
{
    class HeartRate : IHeartRate
    {   
        public HeartRate(List<(double, int)> pulses)
        {
            Pulses = pulses;
        }

        public List<(double, int)> Pulses { get; }

    }
}
