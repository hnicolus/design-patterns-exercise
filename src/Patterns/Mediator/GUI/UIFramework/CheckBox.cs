using System;

namespace Patterns.Mediator.GUI.UIFramework
{
    public class CheckBox : UIControl
    {
        private bool _isChecked;
        public bool IsChecked
        {
            get { return _isChecked; }
            set
            {
                _isChecked = value;
                NotifyHandlers();
            }
        }


    }

}