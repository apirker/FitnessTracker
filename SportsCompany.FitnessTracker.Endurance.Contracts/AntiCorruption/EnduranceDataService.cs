using SportsCompany.FitnessTracker.Peripherals.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace SportsCompany.FitnessTracker.Endurance.Contracts.AntiCorruption
{
    /// <summary>
    /// This class provides an anti-corruption wrapper for endurance implementation to protected the bounded-context.
    /// </summary>
    public class EnduranceDataService
    {
        private readonly IPeripheralService peripheralService;

        /// <summary>
        /// Constructor of endurance data service.
        /// </summary>
        /// <param name="peripheralService">Peripheral service.</param>
        public EnduranceDataService(IPeripheralService peripheralService)
        {
            this.peripheralService = peripheralService;
        }

        /// <summary>
        /// Starts an activity on the peripheral.
        /// </summary>
        public void StartActivitiy()
        {
            peripheralService.StartActivity();
        }

        /// <summary>
        /// Stops an activity on the peripheral.
        /// </summary>
        public void StopActivity()
        {
            peripheralService.StopActivity();
        }

        /// <summary>
        /// Gets the next raw lap data from the peripheral.
        /// </summary>
        /// <returns>Raw lap data.</returns>
        public RawLapDto GetNextRawLap()
        {
            (double distance, int ticks) = peripheralService.GetNextLapData();
            return new RawLapDto(distance, ticks);
        }

        /// <summary>
        /// Gets the heart rate from the peripheral.
        /// </summary>
        /// <returns>List of pulse objects.</returns>
        public IList<(double, RawPulseDto)> GetHeartRate()
        {
            var heartRateData = peripheralService.GetHeartRate();
            return heartRateData.Select(h => (h.Item1, new RawPulseDto(h.Item2))).ToList();
        }
    }
}
