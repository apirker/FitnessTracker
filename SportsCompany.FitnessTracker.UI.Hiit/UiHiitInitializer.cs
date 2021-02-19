using SportsCompany.FitnessTracker.UI.Hiit.HiitMain;
using Unity;

namespace SportsCompany.FitnessTracker.UI.Hiit
{
    /// <summary>
    /// Static class to initialize the HIIT user interface parts.
    /// </summary>
    public class UiHiitInitializer
    {
        public static void Init(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<IHiitMainView, HiitMainView>();
        }
    }
}
