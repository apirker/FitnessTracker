using SportsCompany.FitnessTracker.Endurance.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SportsCompany.FitnessTracker.Endurance.BoundedContext
{
    /// <summary>
    /// Value-object for heart rates.
    /// </summary>
    class HeartRate : IHeartRate
    {
        private List<(double, int)> pulses = new List<(double, int)>();

        /// <summary>
        /// Adds a list of pulses to the value-object, and returns a new value-object.
        /// </summary>
        /// <param name="pulses">Pulses to be added.</param>
        /// <returns>New value-object.</returns>
        internal HeartRate AddPulses(List<(double, int)> pulses)
        {
            var newRate = new HeartRate();
            this.pulses.AddRange(pulses);
            newRate.pulses = this.pulses;

            return newRate;
        }

        /// <summary>
        /// Maximum pulse.
        /// </summary>
        internal int Max => pulses.Select(i => i.Item2).Max();

        /// <summary>
        /// Minimum pulse.
        /// </summary>
        internal int Min => pulses.Select(i => i.Item2).Min();

        /// <summary>
        /// List of all pulses.
        /// </summary>
        public List<(double, int)> Pulses => pulses;

        /// <summary>
        /// Average heart beat.
        /// </summary>
        public double Avergage => pulses.Select(i => i.Item2).Average();
    }
}
