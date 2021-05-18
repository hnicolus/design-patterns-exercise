using static System.Console;

namespace Patterns.Composite
{
    public class Shape :IComponent
    {
        public string Name { get; set; }
        public Shape(string name) => Name = name;
        public void Move() => WriteLine("Moving "+Name);
        public void Render()=> WriteLine("Rendering "+ Name);
    }
}