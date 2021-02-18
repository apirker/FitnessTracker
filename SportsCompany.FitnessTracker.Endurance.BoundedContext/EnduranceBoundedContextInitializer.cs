using SportsCompany.FitnessTracker.Endurance.Contracts;
using Unity;
using Unity.Lifetime;

namespace SportsCompany.FitnessTracker.Endurance.BoundedContext
{
    /// <summary>
    /// Static class for initializing the endurance bounded-context.
    /// </summary>
    public static class EnduranceBoundedContextInitializer
    {
        /// <summary>
        /// Initialization of the bounded context.
        /// </summary>
        /// <param name="unityContainer">IoC container.</param>
        public static void Init(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<ITrainingService, TrainingService>(new ContainerControlledLifetimeManager());
        }
    }
}
