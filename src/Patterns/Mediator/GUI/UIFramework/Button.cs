using System;
using Patterns.Mediator.GUI.UIFramework;

namespace Patterns.Mediator.UIFramework
{ 
    public class Button : UIControl
    {
        private bool isEnabled;
        private string label;

        public string Label { get => label; set => label = value; }
        public bool IsEnabled
        {
            get => isEnabled;
            set
            {
                isEnabled = value;
                NotifyHandlers();
            }
        }
        public virtual void Click()
        {
            if (IsEnabled)
            {
                System.Console.WriteLine($"{Label} is Clicked and Enabled");
                NotifyHandlers();
            }
            else
                System.Console.WriteLine(Label + " Button is Disabled");
        }
    }
}