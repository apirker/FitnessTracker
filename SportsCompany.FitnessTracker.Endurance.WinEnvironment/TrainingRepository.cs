using SportsCompany.FitnessTracker.Endurance.Contracts;
using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Endurance.WinEnvironment
{
    class TrainingRepository : ITrainingRepository
    {
        private IList<ITraining> repository = new List<ITraining>();

        public void Add(ITraining training)
        {
            if (!repository.Contains(training))
                repository.Add(training);
        }

        public void Delete(ITraining training)
        {
            if (repository.Contains(training))
                repository.Remove(training);
        }

        public IList<ITraining> GetAll()
        {
            return repository;
        }

        public void Update(ITraining training)
        {
        }
    }
}
