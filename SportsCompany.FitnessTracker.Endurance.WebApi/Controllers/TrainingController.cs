using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SportsCompany.FitnessTracker.Endurance.Contracts;
using SportsCompany.FitnessTracker.Endurance.Contracts.AntiCorruption;
using System;
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

        public TrainingController(IUnityContainer unityContainer)
        {
            enduranceDataService = unityContainer.Resolve<EnduranceDataService>();
            trainingService = unityContainer.Resolve<ITrainingService>();
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
            return "Save training";
        }
    }
}
