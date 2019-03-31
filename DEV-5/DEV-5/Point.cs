using System;

namespace DEV_5
{
    struct Point
    {
        public int coordinateX { get; set; }
        public int coordinateY { get; set; }
        public int coordinateZ { get; set; }
        public Point (int x, int y, int z)
        {
            coordinateX = x;
            coordinateY = y;
            coordinateZ = z;
        }
        public double ColculateDistance(Point newPoint)=>             
              Math.Sqrt(Math.Pow(newPoint.coordinateX - coordinateX, 2) +
                        Math.Pow(newPoint.coordinateY - coordinateY, 2) +
                        Math.Pow(newPoint.coordinateZ - coordinateZ, 2));        
    }
}
