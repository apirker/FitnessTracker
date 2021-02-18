using SportsCompany.FitnessTracker.Endurance.Contracts;
using SportsCompany.FitnessTracker.Endurance.Contracts.AntiCorruption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SportsCompany.FitnessTracker.Endurance.BoundedContext
{
    /// <summary>
    /// Aggregate for training in the endurance sub-domain.
    /// </summary>
    class Training : ITraining
    {
        public Training(Type type)
        {
            this.type = type;
        }

        private const int trainingsReadIntervalMs = 2 * 1000;

        private List<Lap> laps;
        private List<GpsCoordinate> gpsCoordinates;
        private HeartRate heartRate;
        private Type type;

        private CancellationTokenSource cancellation;

        /// <summary>
        /// Starts the training
        /// </summary>
        /// <param name="enduranceDataService">Service to communicate with the peripheral.</param>
        /// <param name="gpsService">Service to get GPS coordinates from the environment.</param>
        public void Start(EnduranceDataService enduranceDataService, IGpsService gpsService)
        {
            cancellation = new CancellationTokenSource();
            Task.Factory.StartNew(() =>
                {
                    laps = new List<Lap>();
                    heartRate = new HeartRate();

                    enduranceDataService.StartActivitiy();
                    gpsService.StartTracking();

                    while (!cancellation.Token.IsCancellationRequested)
                    {
                        Thread.Sleep(trainingsReadIntervalMs);

                        var nextLapDto = enduranceDataService.GetNextRawLap();
                        var nextHeartRate = enduranceDataService.GetHeartRate();

                        var lap = new Lap(nextLapDto.LapDistance, nextLapDto.LapTime);

                        laps.Add(lap);
                        heartRate = heartRate.AddPulses(nextHeartRate.Select(h => (h.Item1, h.Item2.Pulse)).ToList());
                    }

                    enduranceDataService.StopActivity();
                    gpsService.StopTracking();

                    gpsCoordinates = gpsService.GetCoordinates().Select(c => new GpsCoordinate(c.Item1, c.Item2)).ToList();
                }
            );
        }

        /// <summary>
        /// Stops the training.
        /// </summary>
        public void Stop()
        {
            cancellation.Cancel();
        }

        /// <summary>
        /// Total distance of the training.
        /// </summary>
        internal double Distance => laps.Sum(l => l.DistanceInKm);

        /// <summary>
        /// Total duration of the training.
        /// </summary>
        internal TimeSpan Duration => new TimeSpan(laps.Sum(l => l.Duration.Ticks));

        /// <summary>
        /// Training effect for the athelete.
        /// </summary>
        public double TrainingsEffect {

            get{
                if (type == Type.Running)
                    return Distance * (heartRate.Max - heartRate.Min) / Duration.Ticks;
                else 
                    return Distance * heartRate.Max / Duration.Ticks;
            }
        }

        /// <summary>
        /// Type of the training.
        /// </summary>
        internal Type Type => type;

        /// <summary>
        /// Collection of the laps of this training.
        /// </summary>
        public List<ILap> Laps => laps.Select(l => l as ILap).ToList();

        /// <summary>
        /// Heart rate of this training.
        /// </summary>
        public IHeartRate HeartRate => heartRate;

        /// <summary>
        /// GPS coordinates associated with this training.
        /// </summary>
        public List<IGpsCoordinate> GpsCoordinates => gpsCoordinates.Select(g => g as IGpsCoordinate).ToList();
    }
}
