using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Endurance.WebApi.Dtos
{
    /// <summary>
    /// Data transfer object for heart rates.
    /// </summary>
    public record DtoHeartRate(List<(double, int)> Pulses, double Avergage);
}
