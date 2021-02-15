using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Endurance.WebApi.Dtos
{
    public record DtoHeartRate(List<(double, int)> Pulses, double Avergage);
}
