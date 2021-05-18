using System.Collections.Generic;

namespace Patterns.Composite
{
    public class Group : IComponent
    {
        private List<IComponent> components;
        public Group() => components = new List<IComponent>();
        public void Add(IComponent component) => components.Add(component);
        public void Move() => components.ForEach(comp => comp.Move());
        public void Render() => components.ForEach(component => component.Render());
    }
}