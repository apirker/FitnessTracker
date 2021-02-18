using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Endurance.ServiceMock.Dtos
{
    /// <summary>
    /// Data transfer object from backend for trainings.
    /// </summary>
    public class DtoTraining
    {
        public List<DtoLap> Laps { get; set; }

        public List<DtoGpsCoordinate> GpsCoordinates { get; set; }

        public DtoHeartRate HeartRate { get; set; }

        public double TrainingsEffect { get; set; }
    }
}
