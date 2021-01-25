namespace SportsCompany.FitnessTracker.Hiit.Contracts
{
    public interface ITrainingExecutor
    {
        void Start(string name);

        void Stop(string name);
    }
}
