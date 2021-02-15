using SportsCompany.FitnessTracker.Endurance.Contracts;

namespace SportsCompany.FitnessTracker.Endurance.ServiceMock.Model
{
    public class GpsCoordinate : IGpsCoordinate
    {
        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}
