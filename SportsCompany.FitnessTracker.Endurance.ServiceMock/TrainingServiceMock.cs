﻿using Newtonsoft.Json;
using SportsCompany.FitnessTracker.Endurance.Contracts;
using SportsCompany.FitnessTracker.Endurance.Contracts.AntiCorruption;
using SportsCompany.FitnessTracker.Endurance.WebApi.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SportsCompany.FitnessTracker.Endurance.ServiceMock
{
    class TrainingServiceMock : ITrainingService, ITrainingRepository
    {
        private string baseUrl = "https://localhost:44349";
        private HttpClient client = new HttpClient();

        public void Add(ITraining training)
        {
            throw new NotImplementedException();
        }

        public void Delete(ITraining training)
        {
            throw new NotImplementedException();
        }

        public IList<ITraining> GetAll()
        {
            var httpResult = client.GetAsync($"{baseUrl}/Training").GetAwaiter().GetResult();
            var trainingDtos = DeserializeResponse<IList<DtoTraining>>(httpResult).GetAwaiter().GetResult();

            return trainingDtos.Select(t => new Training()
            {
                Laps = t.Laps.Select(l => new Lap()
                {
                    DistanceInKm = l.DistanceInKm,
                    Duration = new TimeSpan(l.Duration)
                } as ILap).ToList(),
                GpsCoordinates = t.GpsCoordinates.Select(g => new GpsCoordinate
                {
                    Latitude = g.Latitude,
                    Longitude = g.Longitude
                } as IGpsCoordinate).ToList(),
                HeartRate = new HeartRate
                {
                    Pulses = t.HeartRate.Pulses,
                    Avergage = t.HeartRate.Avergage
                },
                TrainingsEffect = t.TrainingsEffect
            } as ITraining).ToList();
        }

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

        public void Update(ITraining training)
        {
            throw new NotImplementedException();
        }

        private async Task<TResponsePayload> DeserializeResponse<TResponsePayload>(HttpResponseMessage responseMessage)
        {
            var stringResponse = await responseMessage.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TResponsePayload>(stringResponse);
        }
    }
}
