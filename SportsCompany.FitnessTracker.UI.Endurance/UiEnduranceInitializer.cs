using SportsCompany.FitnessTracker.UI.Endurance.EnduranceMain;
using Unity;

namespace SportsCompany.FitnessTracker.UI.Endurance
{
    /// <summary>
    /// Static class to initialize the endurance user interface parts.
    /// </summary>
    public static class UiEnduranceInitializer
    {
        public static void Init(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<IEnduranceMainView, EnduranceMainView>();
        }
    }
}
