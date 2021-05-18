using System;

namespace Patterns.Composite.Exercise
{
    public class HumanResource : IComponent
    {
        public void Deploy() => Console.WriteLine("Deploying Human Resource");
    }
}