using SportsCompany.FitnessTracker.Hiit.Contracts;
using Unity;
using Unity.Lifetime;

namespace SportsCompany.FitnessTracker.Hiit.WinEnvironment
{
    public static class HiitWinInitializer
    {
        public static void Init(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<ITrainingRepository, TrainingRepository>(new ContainerControlledLifetimeManager());
        }
    }
}
