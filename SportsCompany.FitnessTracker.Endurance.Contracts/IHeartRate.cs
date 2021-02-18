using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Endurance.Contracts
{
    /// <summary>
    /// This interface defines the visible data for heart rate.
    /// </summary>
    public interface IHeartRate
    {
        /// <summary>
        /// Collection of heartbeats.
        /// </summary>
        List<(double, int)> Pulses { get; }

        /// <summary>
        /// Average heart rate.
        /// </summary>
        double Avergage { get; }
    }
}
