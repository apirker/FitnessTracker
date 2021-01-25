using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Hiit.Contracts.AntiCorruption
{
    public class HeartRateDto
    {
        public HeartRateDto(List<(double, int)> pulses)
        {
            Pulses = pulses;
        }

        public List<(double, int)> Pulses { get; }
    }
}
