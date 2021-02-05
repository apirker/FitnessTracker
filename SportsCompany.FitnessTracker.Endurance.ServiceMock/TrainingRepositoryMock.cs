using SportsCompany.FitnessTracker.Endurance.Contracts;
using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Endurance.ServiceMock
{
    class TrainingRepositoryMock : ITrainingRepository
    {
        public void Add(ITraining training)
        {
        }

        public void Delete(ITraining training)
        {
        }

        public IList<ITraining> GetAll()
        {
            return new List<ITraining>();
        }

        public void Update(ITraining training)
        {
        }
    }
}
