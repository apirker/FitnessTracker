using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Endurance.Contracts
{
    public interface ITraining
    {
        IList<ILap> Laps { get; }
        IList<IGpsCoordinate> GpsCoordinates { get; }
        IHeartRate HeartRate { get; }
    }
}
