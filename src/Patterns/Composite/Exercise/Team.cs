using System;
using System.Collections.Generic;

namespace Patterns.Composite.Exercise
{
    public class Team : IComponent
    {
        private List<IComponent> teams  = new List<IComponent>();
        public void Add(IComponent component) => teams.Add(component);
        public void Deploy() => teams.ForEach(team => team.Deploy());
    }
}