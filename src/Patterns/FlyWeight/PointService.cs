using System.Collections.Generic;

namespace Patterns.FlyWeight
{
    public class PointService
    {
        public List<Point> GetPoints()
        {
            var pointIconFacttory = new PointIconFactory();
            return new List<Point>()
            {
                new Point(234, 2345, pointIconFacttory.GetPoint(PointType.Hospital)),
                new Point(7654, 6575, pointIconFacttory.GetPoint(PointType.Park)),
                new Point(12434, 9371,pointIconFacttory.GetPoint(PointType.Stadium)),
                new Point(98774, 5673,pointIconFacttory.GetPoint(PointType.Cafe)),
                new Point(234, 2345, pointIconFacttory.GetPoint(PointType.Hospital)),
            };

        }
    }
}