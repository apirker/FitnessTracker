using System;

namespace SportsCompany.FitnessTracker.UI.Hiit.HiitTraing
{
    /// <summary>
    /// Interface for the HIIT training view.
    /// </summary>
    interface IHiitTrainView
    {
        /// <summary>
        /// Shows the training provided via the name string in the training view.
        /// </summary>
        void Show(string name);

        /// <summary>
        /// Closes the training view.
        /// </summary>
        void Close();

        /// <summary>
        /// Event which is raised when the view is closed.
        /// </summary>
        event EventHandler ViewClosed;
    }
}
