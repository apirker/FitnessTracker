using SportsCompany.FitnessTracker.Endurance.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SportsCompany.FitnessTracker.Endurance.BoundedContext
{
    class HeartRate : IHeartRate
    {
        private List<(double, int)> pulses = new List<(double, int)>();

        internal HeartRate AddPulses(List<(double, int)> pulses)
        {
            var newRate = new HeartRate();
            this.pulses.AddRange(pulses);
            newRate.pulses = this.pulses;

            return newRate;
        }

        internal int Max => pulses.Select(i => i.Item2).Max();

        internal int Min => pulses.Select(i => i.Item2).Min();

        public List<(double, int)> Pulses => pulses;

        public double Avergage => pulses.Select(i => i.Item2).Average();
    }
}
