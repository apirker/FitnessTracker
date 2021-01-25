﻿using SportsCompany.FitnessTracker.Endurance.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsCompany.FitnessTracker.Endurance.WinEnvironment
{
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
