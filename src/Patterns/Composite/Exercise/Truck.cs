using System;
using static System.Console;
namespace Patterns.Composite.Exercise
{
    public class Truck : IComponent
    {
        public void Deploy() => WriteLine("Deploying Truck");
    }
}