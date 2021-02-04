using SportsCompany.FitnessTracker.Endurance.Contracts;
using Unity;
using Unity.Lifetime;

namespace SportsCompany.FitnessTracker.Endurance.BoundedContext
{
    public static class EnduranceBoundedContextInitializer
    {
        public static void Init(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<ITrainingService, TrainingService>(new ContainerControlledLifetimeManager());
        }
    }
}
