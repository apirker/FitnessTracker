using SportsCompany.FitnessTracker.Endurance.Contracts;
using SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity;
using SportsCompany.FitnessTracker.UI.Endurance.EnduranceMain.UiCommands;
using System.Windows;
using System.Windows.Input;
using Unity;
using Unity.Lifetime;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceMain
{
    /// <summary>
    /// Interaction logic for EnduranceMainView.xaml
    /// </summary>
    public partial class EnduranceMainView : Window, IEnduranceMainView
    {
        private readonly IUnityContainer unityContainer;

        public EnduranceMainView(IUnityContainer unityContainer)
        {
            InitializeComponent();

            this.unityContainer = unityContainer.CreateChildContainer();

            this.unityContainer.RegisterInstance(this as IEnduranceMainView, new ContainerControlledLifetimeManager());
            this.unityContainer.RegisterType<EnduranceMainViewModel>(new ContainerControlledLifetimeManager());
            this.unityContainer.RegisterType<IEnduranceActivityView, EnduranceActivityView>();
            this.unityContainer.RegisterType<ICommand, OpenNewEnduranceUiCommand>(nameof(OpenNewEnduranceUiCommand));

            DataContext = this.unityContainer.Resolve<EnduranceMainViewModel>();

            var viewModel = this.unityContainer.Resolve<EnduranceMainViewModel>();
            viewModel.EnduranceItems.Clear();

            var trainingRepository = unityContainer.Resolve<ITrainingRepository>();
            var trainings = trainingRepository.GetAll();

            foreach (var training in trainings)
            {
                var enduranceViewModel = new EnduranceViewModel()
                {
                    Laps = training.Laps.Count,
                    Average = training.HeartRate.Avergage,
                    TrainingEffect = training.TrainingsEffect
                };

                viewModel.EnduranceItems.Add(enduranceViewModel);
            }
        }
    }
}
