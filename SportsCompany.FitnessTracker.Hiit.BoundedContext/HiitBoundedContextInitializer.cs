using SportsCompany.FitnessTracker.Hiit.Contracts;
using Unity;

namespace SportsCompany.FitnessTracker.Hiit.BoundedContext
{
    /// <summary>
    /// Static class to initialize the HIIT bounded-context.
    /// </summary>
    public static class HiitBoundedContextInitializer
    {
        /// <summary>
        /// Initialization of the dependencies within the HIIT bounded-context.
        /// </summary>
        /// <param name="unityContainer">IoC container.</param>
        public static void Init(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<ITrainingPlanner, TrainingPlanner>();
            unityContainer.RegisterType<ITrainingExecutor, TrainingExecutor>();

        }
    }
}
