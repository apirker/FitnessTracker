using SportsCompany.FitnessTracker.Endurance.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using Unity.Lifetime;

namespace SportsCompany.FitnessTracker.Endurance.WinEnvironment
{
    public class Initializer
    {
        public static void Init(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<ITrainingRepository, TrainingRepository>(new ContainerControlledLifetimeManager());
            unityContainer.RegisterType<IGpsService, GpsService>();
        }
    }
}
