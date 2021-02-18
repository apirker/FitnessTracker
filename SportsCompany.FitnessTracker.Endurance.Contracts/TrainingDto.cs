using System;

namespace SportsCompany.FitnessTracker.Endurance.Contracts
{
    /// <summary>
    /// Data transfer object for trainings.
    /// </summary>
    public class TrainingDto
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="distance">Completed distance.</param>
        /// <param name="duration">Duration of the training.</param>
        /// <param name="trainingEffect">Training effect of the training.</param>
        /// <param name="type">Type of the training.</param>
        public TrainingDto(double distance, TimeSpan duration, double trainingEffect, TypeDto type)
        {
            Distance = distance;
            Duration = duration;
            TrainingEffect = trainingEffect;
            Type = type;
        }

        /// <summary>
        /// Completed distance.
        /// </summary>
        public double Distance { get; }

        /// <summary>
        /// Duration of the training.
        /// </summary>
        public TimeSpan Duration { get; }

        /// <summary>
        /// Training effect of the training.
        /// </summary>
        public double TrainingEffect { get; }

        /// <summary>
        /// Type of the training.
        /// </summary>
        public TypeDto Type { get; }
    }
}