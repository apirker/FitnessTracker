using SportsCompany.FitnessTracker.UI.Endurance.EnduranceMain;
using Unity;

namespace SportsCompany.FitnessTracker.UI.Endurance
{
    public static class UiEnduranceInitializer
    {
        public static void Init(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<IEnduranceMainView, EnduranceMainView>();
        }
    }
}
