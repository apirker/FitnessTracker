using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Endurance.Contracts
{
    public interface IHeartRate
    {
        List<(double, int)> Pulses { get; }

        double Avergage { get; }
    }
}
