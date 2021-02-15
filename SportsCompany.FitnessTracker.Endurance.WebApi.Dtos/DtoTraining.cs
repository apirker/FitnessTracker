using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Endurance.WebApi.Dtos
{
    public record DtoTraining(List<DtoLap> Laps, List<DtoGpsCoordinate> GpsCoordinates, DtoHeartRate HeartRate, double TrainingsEffect);
}
