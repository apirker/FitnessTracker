using System;

namespace SportsCompany.FitnessTracker.Endurance.Contracts.AntiCorruption
{
    public class RawLapDto
    {
        public RawLapDto(double distance, int ticksDuration)
        {
            LapDistance = distance;
            LapTime = new TimeSpan(ticksDuration);
        }


        public double LapDistance { get; }
        public TimeSpan LapTime { get; }
    }
}
