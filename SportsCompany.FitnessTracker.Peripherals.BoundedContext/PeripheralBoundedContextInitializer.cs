using SportsCompany.FitnessTracker.Peripherals.Contracts;
using Unity;

namespace SportsCompany.FitnessTracker.Peripherals.BoundedContext
{
    public static class PeripheralBoundedContextInitializer
    {
        public static void Init(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<IPeripheralService, PeripheralService>();
        }
    }
}
