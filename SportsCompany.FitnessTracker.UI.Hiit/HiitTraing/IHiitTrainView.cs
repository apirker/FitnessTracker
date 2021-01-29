using System;

namespace SportsCompany.FitnessTracker.UI.Hiit.HiitTraing
{
    interface IHiitTrainView
    {
        void Show(string name);

        void Close();

        event EventHandler ViewClosed;
    }
}
