using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SportsCompany.FitnessTracker.Endurance.Contracts;
using SportsCompany.FitnessTracker.Endurance.Contracts.AntiCorruption;
using SportsCompany.FitnessTracker.Endurance.WebApi.Dtos;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Unity;

namespace SportsCompany.FitnessTracker.Endurance.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrainingController : Controller
    {
        private readonly EnduranceDataService enduranceDataService;
        private readonly ITrainingService trainingService;
        private readonly ITrainingRepository repository;

        public TrainingController(IUnityContainer unityContainer)
        {
            enduranceDataService = unityContainer.Resolve<EnduranceDataService>();
            trainingService = unityContainer.Resolve<ITrainingService>();
            repository = unityContainer.Resolve<ITrainingRepository>();
        }

        [HttpPost("start")]
        public async Task<string> Start()
        {
            Debug.WriteLine("Start of the training ...");

            trainingService.StartTraining(enduranceDataService);
            return "Start training";
        }

        [HttpPost("stop")]
        public async Task<string> Stop()
        {
            var result = JsonConvert.SerializeObject(trainingService.StopTraining());
            Debug.WriteLine($"Stop of the training with {result} ...");

            return result;
        }

        [HttpPost("save")]
        public async Task<string> Save()
        {
            Debug.WriteLine("Saving the training ...");

            trainingService.SaveTraining();
            return "Save training";
        }

        [HttpGet]
        public async Task<List<DtoTraining>> GetAll()
        {
            var trainings = repository.GetAll();
            Debug.WriteLine($"Found {trainings.Count} training ...");

            return trainings.Select(t => new DtoTraining()
            {
                Laps = t.Laps.Select(l => new DtoLap()
                {
                    DistanceInKm = l.DistanceInKm,
                    Duration = l.Duration.Ticks
                }).ToList(),
                GpsCoordinates = t.GpsCoordinates.Select(g =>
                new DtoGpsCoordinate
                {
                    Latitude = g.Latitude,
                    Longitude = g.Longitude
                }).ToList(),
                HeartRate = new DtoHeartRate
                {
                    Pulses = t.HeartRate.Pulses,
                    Avergage = t.HeartRate.Avergage
                },
                TrainingsEffect = t.TrainingsEffect
            }
            ).ToList();
        }
    }
}
