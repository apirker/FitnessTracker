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
    /// <summary>
    /// Backend service endpoint for interacting with endurance training bounded-context.
    /// </summary>
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

        /// <summary>
        /// API method to start a training.
        /// </summary>
        /// <returns>Status information.</returns>
        [HttpPost("start")]
        public async Task<string> Start()
        {
            Debug.WriteLine("Start of the training ...");

            trainingService.StartTraining(enduranceDataService);
            return "Start training";
        }

        /// <summary>
        /// API method to stop a training.
        /// </summary>
        /// <returns>Status information.</returns>
        [HttpPost("stop")]
        public async Task<string> Stop()
        {
            var result = JsonConvert.SerializeObject(trainingService.StopTraining());
            Debug.WriteLine($"Stop of the training with {result} ...");

            return result;
        }

        /// <summary>
        /// API method to save a training.
        /// </summary>
        /// <returns>Status information.</returns>
        [HttpPost("save")]
        public async Task<string> Save()
        {
            Debug.WriteLine("Saving the training ...");

            trainingService.SaveTraining();
            return "Save training";
        }

        /// <summary>
        /// API method to return all trainings.
        /// </summary>
        /// <returns>List of data transfer objects for trainings.</returns>
        [HttpGet]
        public async Task<List<DtoTraining>> GetAll()
        {
            var trainings = repository.GetAll();
            Debug.WriteLine($"Found {trainings.Count} training ...");

            return trainings.Select(t => new DtoTraining(
                t.Laps.Select(l => new DtoLap(l.DistanceInKm, l.Duration.Ticks)).ToList(),
                t.GpsCoordinates.Select(g => new DtoGpsCoordinate( g.Latitude, g.Longitude)).ToList(),
                new DtoHeartRate(t.HeartRate.Pulses, t.HeartRate.Avergage),
                t.TrainingsEffect)).ToList();
        }
    }
}
