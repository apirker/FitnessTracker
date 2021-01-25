using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Endurance.Contracts
{
    public interface ITrainingRepository
    {
        void Add(ITraining training);
        void Update(ITraining training);
        void Delete(ITraining training);

        IList<ITraining> GetAll();
    }
}
