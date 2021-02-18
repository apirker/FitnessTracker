using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Endurance.ServiceMock.Dtos
{
    /// <summary>
    /// Data transfer object from backend for heart rates
    /// </summary>
    public class DtoHeartRate
    {
        public List<(double, int)> Pulses { get; set; }

        public double Avergage { get; set; }
    }
}
