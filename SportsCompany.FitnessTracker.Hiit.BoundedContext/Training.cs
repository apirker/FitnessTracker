using SportsCompany.FitnessTracker.Hiit.Contracts;
using SportsCompany.FitnessTracker.Hiit.Contracts.AntiCorruption;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SportsCompany.FitnessTracker.Hiit.BoundedContext
{
    /// <summary>
    /// This class implements the training aggregate from the HIIT bounded-context.
    /// </summary>
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

        /// <summary>
        /// Name of the training.
        /// </summary>
        public string Name => name;

        /// <summary>
        /// Heart rate of the last training.
        /// </summary>
        public IHeartRate HeartRate => heartRate;

        /// <summary>
        /// Pause between individual rounds of the training.
        /// </summary>
        public int PauseInSecBetweenRounds => pauseInSecBetweenRounds;

        /// <summary>
        /// List of rounds which comprise the training.
        /// </summary>
        public IList<IRound> Rounds => rounds.Select(r => r as IRound).ToList();

        /// <summary>
        /// Last duration of the training.
        /// </summary>
        public TimeSpan? LastDuration { get; private set; }

        /// <summary>
        /// Add round to the training.
        /// </summary>
        internal void AddRound()
        {
            rounds.Add(new Round());
        }

        /// <summary>
        /// Removes a round from the training.
        /// </summary>
        internal void RemoveRound(IRound round)
        {
            rounds.Remove((Round)round);
        }

        /// <summary>
        /// Sets the pause between the rounds.
        /// </summary>
        internal void SetPauseBetweenRounds(int value)
        {
            if (value <= 0)
                throw new InvalidOperationException();

            pauseInSecBetweenRounds = value;
        }

        /// <summary>
        /// Sets the pause between exercises for a given round.
        /// </summary>
        internal void SetPauseBetweenExercises(int round, int value)
        {
            rounds[round].SetPauseInSecBetweenExercises(value);
        }

        /// <summary>
        /// Adds an exercise to a round.
        /// </summary>
        internal void AddExercise(int round, string name, int duration)
        {
            rounds[round].AddExercise(new Exercise(name, duration));
        }

        /// <summary>
        /// Removes an exercise from a round. 
        /// </summary>
        internal void RemoveExercise(int round, IExercise exercise)
        {
            rounds[round].RemoveExercise(exercise);
        }

        /// <summary>
        /// Starts the HIIT training.
        /// </summary>
        internal void Start(HiitDataService hiitDataService)
        {
            hiitDataService.StartActivity();
            stopWatch.Start();
        }

        /// <summary>
        /// Stops the HIIT training.
        /// </summary>
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
