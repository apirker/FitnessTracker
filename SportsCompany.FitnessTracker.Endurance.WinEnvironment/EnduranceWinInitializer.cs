using SportsCompany.FitnessTracker.Endurance.Contracts;
using Unity;
using Unity.Lifetime;

namespace SportsCompany.FitnessTracker.Endurance.WinEnvironment
{
    /// <summary>
    /// Static class to initialize the endurance windows environment.
    /// </summary>
    public class EnduranceWinInitializer
    {
        /// <summary>
        /// Initialization of the windows environment for the endurance bouned context.
        /// </summary>
        /// <param name="unityContainer">IoC container.</param>
        public static void Init(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<ITrainingRepository, TrainingRepository>(new ContainerControlledLifetimeManager());
            unityContainer.RegisterType<IGpsService, GpsService>();
        }
    }
}
