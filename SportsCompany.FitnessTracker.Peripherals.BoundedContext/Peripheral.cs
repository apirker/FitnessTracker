using System;
using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Peripherals.BoundedContext
{
    /// <summary>
    /// Mock implementation of a real peripheral.
    /// </summary>
    class Peripheral
    {
        private readonly Random random = new Random();

        /// <summary>
        /// Returns random heart rate values.
        /// </summary>
        /// <returns></returns>
        public List<(double, int)> GetHeartRate()
        {
            return new List<(double, int)>()
            {
                (random.Next(),random.Next(0,200)),
                (random.Next(),random.Next(0,200)),
                (random.Next(),random.Next(0,200))
            };
        }

        /// <summary>
        /// Returns random lap data.
        /// </summary>
        /// <returns></returns>
        public (double, int) GetNextLapData()
        {
            return (1, random.Next());
        }

        /// <summary>
        /// Starts an activity.
        /// </summary>
        public void StartActivity()
        {
        }

        /// <summary>
        /// Stops an activity.
        /// </summary>
        public void StopActivity()
        {
        }
    }
}
