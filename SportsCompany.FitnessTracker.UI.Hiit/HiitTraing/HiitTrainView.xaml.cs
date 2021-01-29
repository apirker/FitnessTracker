using SportsCompany.FitnessTracker.Hiit.Contracts;
using SportsCompany.FitnessTracker.UI.Hiit.HiitTraing.UiCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Unity;
using Unity.Lifetime;

namespace SportsCompany.FitnessTracker.UI.Hiit.HiitTraing
{
    /// <summary>
    /// Interaction logic for HiitTrainView.xaml
    /// </summary>
    public partial class HiitTrainView : Window, IHiitTrainView
    {
        private readonly IUnityContainer unityContainer;

        public HiitTrainView(IUnityContainer unityContainer)
        {
            InitializeComponent();

            this.unityContainer = unityContainer.CreateChildContainer();

            this.unityContainer.RegisterInstance(this, new ContainerControlledLifetimeManager());
            this.unityContainer.RegisterType<HiitTrainViewModel>(new ContainerControlledLifetimeManager());
            this.unityContainer.RegisterType<ICommand, StartTrainingUiCommand>(nameof(StartTrainingUiCommand));
            this.unityContainer.RegisterType<ICommand, StopTrainingUiCommand>(nameof(StopTrainingUiCommand));
            this.unityContainer.RegisterType<ICommand, CloseUiCommand>(nameof(CloseUiCommand));

            DataContext = this.unityContainer.Resolve<HiitTrainViewModel>();
        }

        public event EventHandler ViewClosed;

        public void Show(string name)
        {
            var viewModel = unityContainer.Resolve<HiitTrainViewModel>();
            viewModel.Name = name;

            Show();
        }

        public new void Close()
        {
            base.Close();

            unityContainer.Dispose();

            if (ViewClosed != null)
                ViewClosed(this, EventArgs.Empty);
        }
    }
}
