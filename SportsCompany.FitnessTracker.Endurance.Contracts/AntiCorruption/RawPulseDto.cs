namespace SportsCompany.FitnessTracker.Endurance.Contracts.AntiCorruption
{
    /// <summary>
    /// Data transfer object for pulses.
    /// </summary>
    public class RawPulseDto
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="pulse">Pulse of the DTO.</param>
        public RawPulseDto(int pulse)
        {
            Pulse = pulse;
        }

        /// <summary>
        /// Pulse of the data transfer object.
        /// </summary>
        public int Pulse { get; }
    }
}
