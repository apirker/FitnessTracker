using SportsCompany.FitnessTracker.Endurance.Contracts;
using SportsCompany.FitnessTracker.Endurance.Contracts.AntiCorruption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SportsCompany.FitnessTracker.Endurance.BoundedContext
{
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

        public void Stop()
        {
            cancellation.Cancel();
        }

        internal double Distance => laps.Sum(l => l.DistanceInKm);

        internal TimeSpan Duration => new TimeSpan(laps.Sum(l => l.Duration.Ticks));

        internal double TrainingsEffect {

            get{
                if (type == Type.Running)
                    return Distance * (heartRate.Max - heartRate.Min) / Duration.Ticks;
                else 
                    return Distance * heartRate.Max / Duration.Ticks;
            }
        }

        internal Type Type => type;

        public IList<ILap> Laps => (IList<ILap>) laps;

        public IHeartRate HeartRate => heartRate;

        public IList<IGpsCoordinate> GpsCoordinates => (IList<IGpsCoordinate>) gpsCoordinates;
    }
}
