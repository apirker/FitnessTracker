using SportsCompany.FitnessTracker.Peripherals.Contracts;
using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Peripherals.BoundedContext
{
    /// <summary>
    /// This class implements the peripheral application services.
    /// </summary>
    class PeripheralService : IPeripheralService
    {
        private readonly Peripheral peripheral = new Peripheral();

        /// <summary>
        /// Returns the next heart rate from the peripheral.
        /// </summary>
        public List<(double, int)> GetHeartRate()
        {
            return peripheral.GetHeartRate();
        }

        /// <summary>
        /// Returns the next lap data from the peripheral.
        /// </summary>
        public (double, int) GetNextLapData()
        {
            return peripheral.GetNextLapData();
        }

        /// <summary>
        /// Starts activity on the peripheral.
        /// </summary>
        public void StartActivity()
        {
            peripheral.StartActivity();
        }

        /// <summary>
        /// Stops the activity on the peripheral.
        /// </summary>
        public void StopActivity()
        {
            peripheral.StopActivity();
        }
    }
}
