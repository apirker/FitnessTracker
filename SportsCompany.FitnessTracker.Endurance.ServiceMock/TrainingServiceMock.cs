using Newtonsoft.Json;
using SportsCompany.FitnessTracker.Endurance.Contracts;
using SportsCompany.FitnessTracker.Endurance.Contracts.AntiCorruption;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SportsCompany.FitnessTracker.Endurance.ServiceMock
{
    class TrainingServiceMock : ITrainingService
    {
        private string baseUrl = "https://localhost:44349";
        private HttpClient client = new HttpClient();

        public void SaveTraining()
        {
            client.PostAsync($"{baseUrl}/Training/save", null).GetAwaiter().GetResult();
        }

        public void StartTraining(EnduranceDataService enduranceDataService)
        {
            client.PostAsync($"{baseUrl}/Training/start", null).GetAwaiter().GetResult();
        }

        public TrainingDto StopTraining()
        {
            var httpResult = client.PostAsync($"{baseUrl}/Training/stop", null).GetAwaiter().GetResult();
            return DeserializeResponse<TrainingDto>(httpResult).GetAwaiter().GetResult();
        }

        private async Task<TResponsePayload> DeserializeResponse<TResponsePayload>(HttpResponseMessage responseMessage)
        {
            var stringResponse = await responseMessage.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TResponsePayload>(stringResponse);
        }
    }
}
