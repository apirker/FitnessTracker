using System;

namespace SportsCompany.FitnessTracker.UI.Hiit.HiitEditor
{
    /// <summary>
    /// Interface to abstract the view of the HIIT editor.
    /// </summary>
    interface IHiitEditorView
    {
        /// <summary>
        /// Shows the HIIT editor view.
        /// </summary>
        void Show();

        /// <summary>
        /// Closes the HIIT editor view.
        /// </summary>
        void Close();

        /// <summary>
        /// Event which is raised when the view is closed.
        /// </summary>
        event EventHandler ViewClosed;
    }
}
