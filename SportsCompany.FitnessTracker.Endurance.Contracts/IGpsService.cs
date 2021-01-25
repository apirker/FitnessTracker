using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Endurance.Contracts
{
    public interface IGpsService
    {
        void StartTracking();
        void StopTracking();
        IList<(double, double)> GetCoordinates();
    }
}
