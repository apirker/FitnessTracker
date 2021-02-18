using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Peripherals.Contracts
{
    /// <summary>
    /// Service interface to talk to the peripheral.
    /// </summary>
    public interface IPeripheralService
    {
        /// <summary>
        /// Starts activity on the peripheral.
        /// </summary>
        void StartActivity();

        /// <summary>
        /// Stops the activity on the peripheral.
        /// </summary>
        void StopActivity();

        /// <summary>
        /// Returns the next lap data from the peripheral.
        /// </summary>
        (double, int) GetNextLapData();

        /// <summary>
        /// Returns the next heart rate from the peripheral.
        /// </summary>
        List<(double, int)> GetHeartRate();
    }
}
