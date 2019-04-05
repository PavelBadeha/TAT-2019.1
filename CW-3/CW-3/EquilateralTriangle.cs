using System;


namespace CW_3
{
    class EquilateralTriangle:Triangle
    {
        public EquilateralTriangle(Point pointX, Point pointY, Point pointZ):base (pointX, pointY, pointZ)
        {

        }
        public override double GetSquere() =>
            1.7 / 4 * Math.Pow(X.Distance(Y), 2);
    }
}
