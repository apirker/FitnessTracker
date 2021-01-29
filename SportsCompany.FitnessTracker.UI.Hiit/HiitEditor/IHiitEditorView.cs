using System;

namespace SportsCompany.FitnessTracker.UI.Hiit.HiitEditor
{
    interface IHiitEditorView
    {
        void Show();

        void Close();

        event EventHandler ViewClosed;
    }
}
