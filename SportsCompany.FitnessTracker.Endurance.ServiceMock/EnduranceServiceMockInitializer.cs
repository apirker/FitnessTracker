﻿using SportsCompany.FitnessTracker.Endurance.Contracts;
using Unity;

namespace SportsCompany.FitnessTracker.Endurance.ServiceMock
{
    public static class EnduranceServiceMockInitializer
    {
        public static void Init(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<ITrainingRepository, TrainingRepositoryMock>();
            unityContainer.RegisterType<ITrainingService, TrainingServiceMock>();
        }
    }
}