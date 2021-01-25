using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Hiit.Contracts
{
    public interface ITrainingRepository
    {
        void Add(ITraining training);
        void Update(ITraining training);
        void Delete(ITraining training);

        ITraining FindTrainingByName(string name);
        IList<ITraining> GetAll();
    }
}
