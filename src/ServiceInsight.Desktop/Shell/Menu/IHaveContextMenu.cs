﻿namespace Particular.ServiceInsight.Desktop.Shell.Menu
{
    using Caliburn.Micro;

    public interface IHaveContextMenu
    {
        IObservableCollection<IMenuItem> ContextMenuItems { get; }

        void OnContextMenuOpening();
    }
}