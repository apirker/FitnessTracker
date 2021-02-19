using SportsCompany.FitnessTracker.DesktopClient.UiCommands;
using SportsCompany.FitnessTracker.Endurance.BoundedContext;
using SportsCompany.FitnessTracker.Endurance.ServiceMock;
using SportsCompany.FitnessTracker.Endurance.WinEnvironment;
using SportsCompany.FitnessTracker.Hiit.BoundedContext;
using SportsCompany.FitnessTracker.Hiit.WinEnvironment;
using SportsCompany.FitnessTracker.Peripherals.BoundedContext;
using SportsCompany.FitnessTracker.UI.Endurance;
using SportsCompany.FitnessTracker.UI.Hiit;
using System.Windows;
using System.Windows.Input;
using Unity;
using Unity.Lifetime;

namespace SportsCompany.FitnessTracker.DesktopClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly UnityContainer unityContainer;

        public MainWindow()
        {
            InitializeComponent();

            unityContainer = new UnityContainer();

            UiHiitInitializer.Init(unityContainer);
            HiitBoundedContextInitializer.Init(unityContainer);
            HiitWinInitializer.Init(unityContainer);

            UiEnduranceInitializer.Init(unityContainer);

            var useServiceImplementation = false;
            if (useServiceImplementation)
            {
                EnduranceServiceMockInitializer.Init(unityContainer);
            }
            else
            {
                EnduranceBoundedContextInitializer.Init(unityContainer);
                EnduranceWinInitializer.Init(unityContainer);
            }
            
            PeripheralBoundedContextInitializer.Init(unityContainer);

            unityContainer.RegisterType<MainWindowViewModel>(new ContainerControlledLifetimeManager());

            unityContainer.RegisterType<ICommand, StartRunningUiCommand>(nameof(StartRunningUiCommand));
            unityContainer.RegisterType<ICommand, StartHiitUiCommand>(nameof(StartHiitUiCommand));

            DataContext = unityContainer.Resolve<MainWindowViewModel>();
        }
    }
}
