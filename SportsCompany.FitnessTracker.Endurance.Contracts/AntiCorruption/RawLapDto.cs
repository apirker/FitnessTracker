using System;

namespace SportsCompany.FitnessTracker.Endurance.Contracts.AntiCorruption
{
    /// <summary>
    /// Data transfer object for raw lap data.
    /// </summary>
    public class RawLapDto
    {
        /// <summary>
        /// Constructor of the data transfer object.
        /// </summary>
        /// <param name="distance">Distance of the lap.</param>
        /// <param name="ticksDuration">Duration in tickes of the lap.</param>
        public RawLapDto(double distance, int ticksDuration)
        {
            LapDistance = distance;
            LapTime = new TimeSpan(ticksDuration);
        }

        /// <summary>
        /// Distance of the lap.
        /// </summary>
        public double LapDistance { get; }

        /// <summary>
        /// Time for the lap as TimeSpan.
        /// </summary>
        public TimeSpan LapTime { get; }
    }
}
