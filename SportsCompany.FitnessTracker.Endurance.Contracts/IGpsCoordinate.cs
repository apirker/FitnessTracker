namespace SportsCompany.FitnessTracker.Endurance.Contracts
{
    /// <summary>
    /// This interface defines the visible data for GPS coordinates.
    /// </summary>
    public interface IGpsCoordinate
    {
        /// <summary>
        /// Latitude of the coordinate.
        /// </summary>
        double Latitude { get; }

        /// <summary>
        /// Longitude of the coordinate.
        /// </summary>
        double Longitude { get; }
    }
}
