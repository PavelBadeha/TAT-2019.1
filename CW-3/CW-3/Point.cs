using System;

namespace CW_3
{
    struct Point
    {
        public float x { get; private set; }
        public float y { get; private set; }

        public Point(float x,float y)
        {
            this.x = x;
            this.y = y;
        }
        public double Distance(Point point) =>
            Math.Sqrt(Math.Pow(point.x - x, 2) + Math.Pow(point.y - y, 2));
                       
    }
}
