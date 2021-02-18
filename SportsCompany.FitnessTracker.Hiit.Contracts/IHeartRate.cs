using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Hiit.Contracts
{
    /// <summary>
    /// This interface defines the visible data for heart rates.
    /// </summary>
    public interface IHeartRate
    {
        /// <summary>
        /// List of heart beats.
        /// </summary>
        List<(double, int)> Pulses { get; }
    }
}
