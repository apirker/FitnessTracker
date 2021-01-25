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
                (random.Next(),random.Next()),
                (random.Next(),random.Next()),
                (random.Next(),random.Next())
            };
        }

        public (double, int) GetNextLapData()
        {
            return (random.Next(), random.Next());
        }

        public void StartActivity()
        {
        }

        public void StopActivity()
        {
        }
    }
}
