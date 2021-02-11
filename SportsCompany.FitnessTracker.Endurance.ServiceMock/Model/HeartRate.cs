using SportsCompany.FitnessTracker.Endurance.Contracts;
using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Endurance.WebApi.Dtos
{
    public class HeartRate : IHeartRate
    {
        public List<(double, int)> Pulses { get; set; }

        public double Avergage { get; set; }
    }
}
