using SportsCompany.FitnessTracker.UI.Hiit.HiitEditor.UiCommands;
using System;
using System.Windows;
using System.Windows.Input;
using Unity;
using Unity.Lifetime;

namespace SportsCompany.FitnessTracker.UI.Hiit.HiitEditor
{
    /// <summary>
    /// Interaction logic for HiitEditorView.xaml
    /// </summary>
    public partial class HiitEditorView : Window, IHiitEditorView
    {
        private readonly IUnityContainer unityContainer;

        public HiitEditorView(IUnityContainer unityContainer)
        {
            InitializeComponent();

            this.unityContainer = unityContainer.CreateChildContainer();

            this.unityContainer.RegisterInstance(this, new ContainerControlledLifetimeManager());
            this.unityContainer.RegisterType<HiitEditorViewModel>(new ContainerControlledLifetimeManager());
            this.unityContainer.RegisterType<ICommand, AddRoundUiCommand>(nameof(AddRoundUiCommand));
            this.unityContainer.RegisterType<ICommand, SaveUiCommand>(nameof(SaveUiCommand));

            DataContext = this.unityContainer.Resolve<HiitEditorViewModel>();
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
