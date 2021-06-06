namespace Patterns.FlyWeight
{
    public class PointIcon
    {
        public byte[] Icon { get; }
        public PointType Type { get; }
        public PointIcon(PointType type, byte[] icon)
        {
            this.Type = type;
            this.Icon = icon;
        }
    }
}