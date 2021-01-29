using SportsCompany.FitnessTracker.Hiit.Contracts;
using SportsCompany.FitnessTracker.Hiit.Contracts.AntiCorruption;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SportsCompany.FitnessTracker.Hiit.BoundedContext
{
    class Training : ITraining
    {
        private Stopwatch stopWatch = new Stopwatch();

        private string name;
        private IList<Round> rounds = new List<Round>();
        private HeartRate heartRate;
        private int pauseInSecBetweenRounds;

        public Training(string name)
        {
            this.name = name;
        }

        public string Name => name;

        public IHeartRate HeartRate => heartRate;

        public int PauseInSecBetweenRounds => pauseInSecBetweenRounds;

        public IList<IRound> Rounds => rounds.Select(r => r as IRound).ToList();

        public TimeSpan? LastDuration { get; private set; }

        internal void AddRound()
        {
            rounds.Add(new Round());
        }

        internal void RemoveRound(IRound round)
        {
            rounds.Remove((Round)round);
        }

        internal void SetPauseBetweenRounds(int value)
        {
            if (value <= 0)
                throw new InvalidOperationException();

            pauseInSecBetweenRounds = value;
        }

        internal void SetPauseBetweenExercises(int round, int value)
        {
            rounds[round].SetPauseInSecBetweenExercises(value);
        }
        internal void AddExercise(int round, string name, int duration)
        {
            rounds[round].AddExercise(new Exercise(name, duration));
        }

        internal void RemoveExercise(int round, IExercise exercise)
        {
            rounds[round].RemoveExercise(exercise);
        }

        internal void Start(HiitDataService hiitDataService)
        {
            hiitDataService.StartActivity();
            stopWatch.Start();
        }

        internal void Stop(HiitDataService hiitDataService)
        {
            hiitDataService.StopActivity();
            stopWatch.Stop();

            LastDuration = stopWatch.Elapsed;

            var heartRateDto = hiitDataService.GetHeartRate();
            heartRate = new HeartRate(heartRateDto.Pulses);
        }
    }
}
