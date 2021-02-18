using SportsCompany.FitnessTracker.Peripherals.Contracts;
using Unity;

namespace SportsCompany.FitnessTracker.Peripherals.BoundedContext
{
    /// <summary>
    /// Static class to initialize the peripheral bounded context.
    /// </summary>
    public static class PeripheralBoundedContextInitializer
    {
        /// <summary>
        /// Initialize the functionality of the bounded context to the IOC container.
        /// </summary>
        /// <param name="unityContainer">IoC container.</param>
        public static void Init(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<IPeripheralService, PeripheralService>();
        }
    }
}
