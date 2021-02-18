using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Hiit.Contracts.AntiCorruption
{
    /// <summary>
    /// Data transfer object for heart rates from the peripheral.
    /// </summary>
    public class HeartRateDto
    {
        public HeartRateDto(List<(double, int)> pulses)
        {
            Pulses = pulses;
        }

        /// <summary>
        /// List of pulses.
        /// </summary>
        public List<(double, int)> Pulses { get; }
    }
}
