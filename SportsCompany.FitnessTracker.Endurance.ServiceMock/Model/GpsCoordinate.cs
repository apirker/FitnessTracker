using SportsCompany.FitnessTracker.Endurance.Contracts;

namespace SportsCompany.FitnessTracker.Endurance.ServiceMock.Model
{
    /// <summary>
    /// Service model for returning GPS coordinates.
    /// </summary>
    public class GpsCoordinate : IGpsCoordinate
    {
        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}
