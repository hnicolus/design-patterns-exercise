using System;

namespace Patterns.Template
{
    public abstract class Window
    {
        public void Close()
        {

            //TODO: custom windows may need to execute some code before the window
            // is closed.
            OnExecution();

            Console.WriteLine("Removing the window from the screen");

            //TODO: custom windows may need to execute some code after the window
            // is closed.
            OnExecuted();
        }

        protected virtual void OnExecution()
        {

        }
        protected virtual void OnExecuted()
        {

        }


    }
}