using System;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity
{
    interface IEnduranceActivityView
    {
        void Show();

        void Close();

        event EventHandler ViewClosed;
    }
}
