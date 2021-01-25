namespace SportsCompany.FitnessTracker.Endurance.Contracts.AntiCorruption
{
    public class RawPulseDto
    {
        public RawPulseDto(int pulse)
        {
            Pulse = pulse;
        }

        public int Pulse { get; }
    }
}
