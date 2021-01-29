using SportsCompany.FitnessTracker.UI.Hiit.HiitMain;
using System;
using Unity;

namespace SportsCompany.FitnessTracker.UI.Hiit
{
    public class UiHiitInitializer
    {
        public static void Init(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<IHiitMainView, HiitMainView>();
        }
    }
}
