using SportsCompany.FitnessTracker.Hiit.Contracts;
using System;

namespace SportsCompany.FitnessTracker.Hiit.BoundedContext
{
    class TrainingPlanner : ITrainingPlanner
    {
        private Training training;

        public void AddExercise(int round, string name, int duration)
        {
            ThrowIfTrainingNotCreated();
            training.AddExercise(round, name, duration);
        }

        public void RemoveExercise(int round, IExercise exercise)
        {
            ThrowIfTrainingNotCreated();
            training.RemoveExercise(round, exercise);
        }

        public void AddRound()
        {
            ThrowIfTrainingNotCreated();
            training.AddRound();
        }

        public void RemoveRound(IRound round)
        {
            ThrowIfTrainingNotCreated();
            training.RemoveRound(round);
        }

        public void SetPauseBetweenExercises(int round, int value)
        {
            ThrowIfTrainingNotCreated();
            training.SetPauseBetweenExercises(round, value);
        }

        public void SetPauseBetweenRounds(int value)
        {
            ThrowIfTrainingNotCreated();
            training.SetPauseBetweenRounds(value);
        }

        public ITraining NewTraining(string name)
        {
            training = new Training(name);
            return training;
        }

        private void ThrowIfTrainingNotCreated()
        {
            if (training == null)
                throw new InvalidOperationException();
        }
    }
}
