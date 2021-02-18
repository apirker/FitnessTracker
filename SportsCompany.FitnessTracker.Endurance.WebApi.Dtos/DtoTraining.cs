using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Endurance.WebApi.Dtos
{
    /// <summary>
    /// Data transfer object for trainings.
    /// </summary>
    public record DtoTraining(List<DtoLap> Laps, List<DtoGpsCoordinate> GpsCoordinates, DtoHeartRate HeartRate, double TrainingsEffect);
}
