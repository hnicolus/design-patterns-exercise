using System;
using static System.Console;
namespace Patterns.FlyWeight
{
    public class Point
    {
        private readonly int x;
        private readonly int y;
        public PointIcon PointIcon { get; }
        public Point(int x, int y, PointIcon Pointicon)
        {
            this.x = x;
            this.y = y;
            this.PointIcon = Pointicon;
        }

        public void Draw() => WriteLine($"{PointIcon.Type} at {x} {y} {PointIcon.Icon}");

    }
}