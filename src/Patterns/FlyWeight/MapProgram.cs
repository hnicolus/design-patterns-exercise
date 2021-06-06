using System;

namespace Patterns.FlyWeight
{
    public static class MapProgram
    {
        public static void Run()
        {
            var pointService = new PointService();
            var points = pointService.GetPoints();
            points.ForEach(point => point.Draw());
            
        }
    }
}