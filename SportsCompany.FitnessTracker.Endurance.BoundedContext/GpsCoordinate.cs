using SportsCompany.FitnessTracker.Endurance.Contracts;

namespace SportsCompany.FitnessTracker.Endurance.BoundedContext
{
    /// <summary>
    /// Value-object for GPS coordinate.
    /// </summary>
    class GpsCoordinate : IGpsCoordinate
    {
        public GpsCoordinate(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        /// <summary>
        /// Latitude of the coordinate.
        /// </summary>
        public double Latitude { get; }

        /// <summary>
        /// Longitude of the coordinate.
        /// </summary>
        public double Longitude { get; }
    }
}
