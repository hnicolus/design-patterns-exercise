using System;
using System.Collections.Generic;

namespace Patterns.FlyWeight
{
    public class PointIconFactory
    {
        private Dictionary<PointType, PointIcon> _points = new();
        public PointIcon GetPoint(PointType type)
        {
            if (!_points.ContainsKey(type))
            {
                _points.Add(type, new PointIcon(type, null));
            }
            return _points[type];
        }
    }
}