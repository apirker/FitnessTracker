namespace SportsCompany.FitnessTracker.Hiit.Contracts
{
    public interface ITrainingPlanner
    {
        ITraining NewTraining(string name);

        void AddRound();
        void RemoveRound(IRound round);

        void SetPauseBetweenRounds(int value);
        void SetPauseBetweenExercises(int round, int value);
        
        void AddExercise(int round, string name, int duration);
        void RemoveExercise(int round, IExercise exercise);
    }
}
