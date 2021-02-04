using System;
using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Peripherals.BoundedContext
{
    class Peripheral
    {
        private readonly Random random = new Random();
        public List<(double, int)> GetHeartRate()
        {
            return new List<(double, int)>()
            {
                (random.Next(),random.Next(0,200)),
                (random.Next(),random.Next(0,200)),
                (random.Next(),random.Next(0,200))
            };
        }

        public (double, int) GetNextLapData()
        {
            return (1, random.Next());
        }

        public void StartActivity()
        {
        }

        public void StopActivity()
        {
        }
    }
}
