using SportsCompany.FitnessTracker.Endurance.Contracts;
using Unity;

namespace SportsCompany.FitnessTracker.Endurance.ServiceMock
{
    /// <summary>
    /// Static class to initialize the service communication layer with the backend.
    /// </summary>
    public static class EnduranceServiceMockInitializer
    {
        /// <summary>
        /// Initializes the dependencies to communicate with the backend service.
        /// </summary>
        /// <param name="unityContainer"></param>
        public static void Init(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<ITrainingRepository, TrainingServiceMock>();
            unityContainer.RegisterType<ITrainingService, TrainingServiceMock>();
        }
    }
}
