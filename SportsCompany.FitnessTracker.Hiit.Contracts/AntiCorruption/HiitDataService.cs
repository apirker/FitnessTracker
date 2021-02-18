using SportsCompany.FitnessTracker.Peripherals.Contracts;

namespace SportsCompany.FitnessTracker.Hiit.Contracts.AntiCorruption
{
    /// <summary>
    /// Anti-corruption service to protect the bounded-context from the peripheral bounded-context.
    /// </summary>
    public class HiitDataService
    {
        private readonly IPeripheralService peripheralService;

        public HiitDataService(IPeripheralService peripheralService)
        {
            this.peripheralService = peripheralService;
        }

        /// <summary>
        /// Starts the activity.
        /// </summary>
        public void StartActivity()
        {
            peripheralService.StartActivity();
        }

        /// <summary>
        /// Stops the activity.
        /// </summary>
        public void StopActivity()
        {
            peripheralService.StopActivity();
        }

        /// <summary>
        /// Get the heart rate from the peripheral.
        /// </summary>
        /// <returns>Heart rate data transfer object.</returns>
        public HeartRateDto GetHeartRate()
        {
            return new HeartRateDto(peripheralService.GetHeartRate());
        }

    }
}
