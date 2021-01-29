using SportsCompany.FitnessTracker.UI.Hiit.HiitEditor;
using SportsCompany.FitnessTracker.UI.Hiit.HiitMain.UiCommands;
using SportsCompany.FitnessTracker.UI.Hiit.HiitTraing;
using System.Windows;
using System.Windows.Input;
using Unity;
using Unity.Lifetime;

namespace SportsCompany.FitnessTracker.UI.Hiit.HiitMain
{
    /// <summary>
    /// Interaction logic for HiitMainView.xaml
    /// </summary>
    public partial class HiitMainView : Window, IHiitMainView
    {
        private readonly IUnityContainer unityContainer;

        public HiitMainView(IUnityContainer unityContainer)
        {
            InitializeComponent();

            this.unityContainer = unityContainer.CreateChildContainer();
            this.unityContainer.RegisterType<HiitTrainingViewModel>();
            this.unityContainer.RegisterType<HiitMainViewModel>(new ContainerControlledLifetimeManager());
            this.unityContainer.RegisterType<ICommand, OpenCreateNewTrainingCommand>(nameof(OpenCreateNewTrainingCommand));
            this.unityContainer.RegisterType<ICommand, OpenSelectedTrainingCommand>(nameof(OpenSelectedTrainingCommand));
            
            this.unityContainer.RegisterType<IHiitEditorView, HiitEditorView>();
            this.unityContainer.RegisterType<IHiitTrainView, HiitTrainView>();

            DataContext = this.unityContainer.Resolve<HiitMainViewModel>();
        }
    }
}
