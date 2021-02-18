namespace SportsCompany.FitnessTracker.Endurance.ServiceMock.Dtos
{
    /// <summary>
    /// Data transfer object from backend for laps
    /// </summary>
    public class DtoLap
    {
        public double DistanceInKm { get; set; }

        public long Duration { get; set; }
    }
}
