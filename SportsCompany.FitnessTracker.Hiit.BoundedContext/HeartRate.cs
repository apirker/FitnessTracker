using SportsCompany.FitnessTracker.Hiit.Contracts;
using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Hiit.BoundedContext
{
    /// <summary>
    /// This class implements the heart rate value object from the HIIT bounded-context.
    /// </summary>
    class HeartRate : IHeartRate
    {   
        public HeartRate(List<(double, int)> pulses)
        {
            Pulses = pulses;
        }

        /// <summary>
        /// List of heart beats.
        /// </summary>
        public List<(double, int)> Pulses { get; }

    }
}
