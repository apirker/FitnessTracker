using SportsCompany.FitnessTracker.Endurance.Contracts;
using Unity;

namespace SportsCompany.FitnessTracker.Endurance.BoundedContext
{
    public class Initializer
    {
        public static void Init(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<ITrainingService, TrainingService>();
        }
    }
}
