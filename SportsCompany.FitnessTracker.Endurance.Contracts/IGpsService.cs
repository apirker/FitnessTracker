using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Endurance.Contracts
{
    /// <summary>
    /// This interface is a port to define how the bounded-context wants to read GPS coordinates in an environment.
    /// </summary>
    public interface IGpsService
    {
        /// <summary>
        /// Starts GPS tracking.
        /// </summary>
        void StartTracking();

        /// <summary>
        /// Stops GPS tracking.
        /// </summary>
        void StopTracking();

        /// <summary>
        /// Returns a list of coordinates.
        /// </summary>
        /// <returns></returns>
        IList<(double, double)> GetCoordinates();
    }
}
