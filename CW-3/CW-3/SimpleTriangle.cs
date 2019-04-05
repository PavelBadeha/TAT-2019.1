using System;

namespace CW_3
{
    class SimpleTriangle:Triangle
    {
        public SimpleTriangle(Point pointX, Point pointY, Point pointZ) : base(pointX, pointY, pointZ)
        {

        }
        public override double GetSquere()
        {         
            double p = 0.5*(X.Distance(Y) + Y.Distance(Z) + Z.Distance(X));
            return Math.Sqrt(p * (p - X.Distance(Y)) * (p - Y.Distance(Z)) * (p - Z.Distance(X)));
        }
    }
}
