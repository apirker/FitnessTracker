using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Endurance.Contracts
{
    public interface ITraining
    {
        List<ILap> Laps { get; }
        List<IGpsCoordinate> GpsCoordinates { get; }
        IHeartRate HeartRate { get; }
        double TrainingsEffect { get; }
    }
}
