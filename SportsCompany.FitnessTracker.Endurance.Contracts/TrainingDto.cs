using System;

namespace SportsCompany.FitnessTracker.Endurance.Contracts
{
    public class TrainingDto
    {
        public TrainingDto(double distance, TimeSpan duration, double trainingEffect, TypeDto type)
        {
            Distance = distance;
            Duration = duration;
            TrainingEffect = trainingEffect;
            Type = type;
        }

        public double Distance { get; }

        public TimeSpan Duration { get; }

        public double TrainingEffect { get; }

        public TypeDto Type { get; }
    }
}