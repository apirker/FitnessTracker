using SportsCompany.FitnessTracker.Hiit.Contracts;
using Unity;

namespace SportsCompany.FitnessTracker.Hiit.BoundedContext
{
    public static class HiitBoundedContextInitializer
    {
        public static void Init(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<ITrainingPlanner, TrainingPlanner>();
            unityContainer.RegisterType<ITrainingExecutor, TrainingExecutor>();

        }
    }
}
