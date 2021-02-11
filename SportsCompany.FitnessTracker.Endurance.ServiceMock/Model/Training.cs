﻿using SportsCompany.FitnessTracker.Endurance.Contracts;
using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Endurance.WebApi.Dtos
{
    public class Training : ITraining
    {
        public List<ILap> Laps { get; set; }

        public List<IGpsCoordinate> GpsCoordinates { get; set; }

        public IHeartRate HeartRate { get; set; }

        public double TrainingsEffect { get; set; }
    }
}