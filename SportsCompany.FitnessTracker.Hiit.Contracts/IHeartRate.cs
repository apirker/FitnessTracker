using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Hiit.Contracts
{
    public interface IHeartRate
    {
        List<(double, int)> Pulses { get; }
    }
}
