using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Endurance.ServiceMock.Dtos
{
    public class DtoHeartRate
    {
        public List<(double, int)> Pulses { get; set; }

        public double Avergage { get; set; }
    }
}
