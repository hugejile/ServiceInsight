﻿namespace Particular.ServiceInsight.FunctionalTests.Parts
{
    using System;
    using System.Windows.Automation;
    using TestStack.White.UIItems.WindowItems;
    using TestStack.White.Utility;

    public class ShellScreen : ProfilerElement
    {
        public ShellScreen(Window mainWindow) : base(mainWindow)
        {
        }

        public MainMenu MainMenu { get; set; }

        public LayoutManager LayoutManager { get; set; }

        public StatusBar StatusBar { get; set; }

        public void WaitWhileBusy()
        {
            Retry.For(ShellIsBusy, isBusy => isBusy, TimeSpan.FromSeconds(10));
        }

        private bool ShellIsBusy()
        {
            var currentPropertyValue = MainWindow.AutomationElement.GetCurrentPropertyValue(AutomationElement.HelpTextProperty);
            return currentPropertyValue != null && ((string)currentPropertyValue).Contains("Busy");
        }


    }
}