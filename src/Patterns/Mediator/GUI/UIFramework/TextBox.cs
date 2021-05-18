using System;

namespace Patterns.Mediator.GUI.UIFramework
{
    public class TextBox : UIControl
    {
        private string _text;
        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                NotifyHandlers();
            }
        }
    }
}