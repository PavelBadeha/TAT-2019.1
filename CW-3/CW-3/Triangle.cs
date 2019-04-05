using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_3
{
    abstract class Triangle
    {
        public Point X { get; protected set; }
        public Point Y { get; protected set; }
        public Point Z { get; protected set; }
        public abstract double GetSquere();
        public Triangle(Point pointX, Point pointY, Point pointZ)
        {
            X = pointX;
            Y = pointY;
            Z = pointZ;
        }      
    }
}
