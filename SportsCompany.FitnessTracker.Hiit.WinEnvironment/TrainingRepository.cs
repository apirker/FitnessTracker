using SportsCompany.FitnessTracker.Hiit.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SportsCompany.FitnessTracker.Hiit.WinEnvironment
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

        public ITraining FindTrainingByName(string name)
        {
            return repository.FirstOrDefault(t => t.Name == name);
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
