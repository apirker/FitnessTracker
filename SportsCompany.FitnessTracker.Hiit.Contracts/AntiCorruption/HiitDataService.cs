using SportsCompany.FitnessTracker.Peripherals.Contracts;

namespace SportsCompany.FitnessTracker.Hiit.Contracts.AntiCorruption
{
    public class HiitDataService
    {
        private readonly IPeripheralService peripheralService;

        public HiitDataService(IPeripheralService peripheralService)
        {
            this.peripheralService = peripheralService;
        }

        public void StartActivity()
        {
            peripheralService.StartActivity();
        }

        public void StopActivity()
        {
            peripheralService.StopActivity();
        }

        public HeartRateDto GetHeartRate()
        {
            return new HeartRateDto(peripheralService.GetHeartRate());
        }

    }
}
