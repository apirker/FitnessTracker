using SportsCompany.FitnessTracker.Peripherals.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace SportsCompany.FitnessTracker.Endurance.Contracts.AntiCorruption
{
    public class EnduranceDataService
    {
        private readonly IPeripheralService peripheralService;

        public EnduranceDataService(IPeripheralService peripheralService)
        {
            this.peripheralService = peripheralService;
        }

        public void StartActivitiy()
        {
            peripheralService.StartActivity();
        }

        public void StopActivity()
        {
            peripheralService.StopActivity();
        }

        public RawLapDto GetNextRawLap()
        {
            (double distance, int ticks) = peripheralService.GetNextLapData();
            return new RawLapDto(distance, ticks);
        }

        public IList<(double, RawPulseDto)> GetHeartRate()
        {
            var heartRateData = peripheralService.GetHeartRate();
            return heartRateData.Select(h => (h.Item1, new RawPulseDto(h.Item2))).ToList();
        }
    }
}
