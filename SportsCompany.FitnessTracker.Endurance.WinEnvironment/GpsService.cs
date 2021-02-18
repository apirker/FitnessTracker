using SportsCompany.FitnessTracker.Endurance.Contracts;
using System;
using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Endurance.WinEnvironment
{
    /// <summary>
    /// Mock implementation of the GPS service.
    /// </summary>
    class GpsService : IGpsService
    {
        public IList<(double, double)> GetCoordinates()
        {
            var random = new Random();
            return new List<(double, double)>()
            {
                (random.NextDouble(), random.NextDouble()),
                (random.NextDouble(), random.NextDouble()),
                (random.NextDouble(), random.NextDouble())
            };
        }

        public void StartTracking()
        {
        }

        public void StopTracking()
        {
        }
    }
}
