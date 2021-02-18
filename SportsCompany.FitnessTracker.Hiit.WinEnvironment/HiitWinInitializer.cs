using SportsCompany.FitnessTracker.Hiit.Contracts;
using Unity;
using Unity.Lifetime;

namespace SportsCompany.FitnessTracker.Hiit.WinEnvironment
{
    /// <summary>
    /// Static class to initialize the HIIT windows environment.
    /// </summary>
    public static class HiitWinInitializer
    {
        /// <summary>
        /// Initializes the HIIT windows environment within the IoC container.
        /// </summary>
        /// <param name="unityContainer">IoC container.</param>
        public static void Init(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<ITrainingRepository, TrainingRepository>(new ContainerControlledLifetimeManager());
        }
    }
}
