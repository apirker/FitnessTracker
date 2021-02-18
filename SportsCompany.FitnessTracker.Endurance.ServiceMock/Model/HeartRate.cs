using SportsCompany.FitnessTracker.Endurance.Contracts;
using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Endurance.ServiceMock.Model
{
    /// <summary>
    /// Service model for returning heart rates.
    /// </summary>
    public class HeartRate : IHeartRate
    {
        public List<(double, int)> Pulses { get; set; }

        public double Avergage { get; set; }
    }
}
