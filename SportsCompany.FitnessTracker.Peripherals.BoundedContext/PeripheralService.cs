using SportsCompany.FitnessTracker.Peripherals.Contracts;
using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Peripherals.BoundedContext
{
    class PeripheralService : IPeripheralService
    {
        private readonly Peripheral peripheral = new Peripheral();

        public List<(double, int)> GetHeartRate()
        {
            return peripheral.GetHeartRate();
        }

        public (double, int) GetNextLapData()
        {
            return peripheral.GetNextLapData();
        }

        public void StartActivity()
        {
            peripheral.StartActivity();
        }

        public void StopActivity()
        {
            peripheral.StopActivity();
        }
    }
}
