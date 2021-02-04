using SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity.UiCommands;
using System;
using System.Windows;
using System.Windows.Input;
using Unity;
using Unity.Lifetime;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity
{
    /// <summary>
    /// Interaction logic for EnduranceActivityView.xaml
    /// </summary>
    public partial class EnduranceActivityView : Window, IEnduranceActivityView
    {
        private readonly IUnityContainer unityContainer;

        public EnduranceActivityView(IUnityContainer unityContainer)
        {
            InitializeComponent();

            this.unityContainer = unityContainer.CreateChildContainer();

            this.unityContainer.RegisterInstance(this as IEnduranceActivityView, new ContainerControlledLifetimeManager());
            this.unityContainer.RegisterType<EnduranceActivityViewModel>(new ContainerControlledLifetimeManager());
            
            this.unityContainer.RegisterType<ICommand, StartActivityUiCommand>(nameof(StartActivityUiCommand));
            this.unityContainer.RegisterType<ICommand, StopActivityUiCommand>(nameof(StopActivityUiCommand));
            this.unityContainer.RegisterType<ICommand, SaveActivityUiCommand>(nameof(SaveActivityUiCommand));

            DataContext = this.unityContainer.Resolve<EnduranceActivityViewModel>();
        }

        public event EventHandler ViewClosed;

        public new void Close()
        {
            base.Close();

            unityContainer.Dispose();

            if (ViewClosed != null)
                ViewClosed(this, EventArgs.Empty);
        }
    }
}
