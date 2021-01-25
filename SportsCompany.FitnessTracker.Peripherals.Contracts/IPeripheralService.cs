using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Peripherals.Contracts
{
    public interface IPeripheralService
    {
        void StartActivity();
        void StopActivity();

        (double, int) GetNextLapData();
        List<(double, int)> GetHeartRate();
    }
}
