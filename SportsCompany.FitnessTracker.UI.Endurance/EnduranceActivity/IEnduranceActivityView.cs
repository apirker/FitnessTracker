using System;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity
{
    /// <summary>
    /// Interface to hide the view implementation.
    /// </summary>
    interface IEnduranceActivityView
    {
        /// <summary>
        /// Shows the activity view.
        /// </summary>
        void Show();

        /// <summary>
        /// Closes the activity view.
        /// </summary>
        void Close();

        /// <summary>
        /// Event which signals that the view has been closed by the user.
        /// </summary>
        event EventHandler ViewClosed;
    }
}
