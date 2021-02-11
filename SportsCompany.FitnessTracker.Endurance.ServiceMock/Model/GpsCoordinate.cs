using SportsCompany.FitnessTracker.Endurance.Contracts;

namespace SportsCompany.FitnessTracker.Endurance.WebApi.Dtos
{
    public class GpsCoordinate : IGpsCoordinate
    {
        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}
