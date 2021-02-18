using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Endurance.Contracts
{
    /// <summary>
    /// This interface defines the visible data for endurance trainings.
    /// </summary>
    public interface ITraining
    {
        /// <summary>
        /// Collection of laps completed within this training.
        /// </summary>
        List<ILap> Laps { get; }

        /// <summary>
        /// Collection of GPS coordinates for maps within this training.
        /// </summary>
        List<IGpsCoordinate> GpsCoordinates { get; }

        /// <summary>
        /// Heart rate recordings of this training.
        /// </summary>
        IHeartRate HeartRate { get; }

        /// <summary>
        /// Training effect for the athlete.
        /// </summary>
        double TrainingsEffect { get; }
    }
}
