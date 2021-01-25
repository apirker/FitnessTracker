﻿using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Hiit.Contracts
{
    public interface ITraining
    {
        string Name { get; }

        IHeartRate HeartRate { get; }

        int PauseInSecBetweenRounds { get; }

        IList<IRound> Rounds { get; }


    }
}
