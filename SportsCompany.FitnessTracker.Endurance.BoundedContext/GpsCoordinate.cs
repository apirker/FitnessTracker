using SportsCompany.FitnessTracker.Endurance.Contracts;

namespace SportsCompany.FitnessTracker.Endurance.BoundedContext
{
    class GpsCoordinate : IGpsCoordinate
    {
        public GpsCoordinate(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public double Latitude { get; }
        public double Longitude { get; }
    }
}
