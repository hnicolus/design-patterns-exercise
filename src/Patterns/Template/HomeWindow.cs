using System;
using static System.Console;
namespace Patterns.Template
{
    public class HomeWindow : Window
    {

        protected override void OnExecution() => WriteLine("Home window is about to Close");
        protected override void OnExecuted() => WriteLine("Home window has been closed");
    }
}