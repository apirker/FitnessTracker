using SportsCompany.FitnessTracker.Endurance.Contracts;
using Unity;
using Unity.Lifetime;

namespace SportsCompany.FitnessTracker.Endurance.WinEnvironment
{
    public class EnduranceWinInitializer
    {
        public static void Init(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<ITrainingRepository, TrainingRepository>(new ContainerControlledLifetimeManager());
            unityContainer.RegisterType<IGpsService, GpsService>();
        }
    }
}
