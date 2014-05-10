﻿namespace Particular.ServiceInsight.Desktop.Settings
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class SettingBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}