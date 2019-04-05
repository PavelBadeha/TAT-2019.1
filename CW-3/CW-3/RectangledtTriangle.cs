using System;

namespace CW_3
{
    class RectangledtTriangle:Triangle
    {
        public RectangledtTriangle(Point pointX, Point pointY, Point pointZ) : base(pointX, pointY, pointZ)
        {

        }
        public override double GetSquere()
        {          
            if (Math.Pow(X.Distance(Y), 2) + Math.Pow(X.Distance(Z), 2) - Math.Pow(Y.Distance(Z), 2) < double.Epsilon)
            {
                return X.Distance(Y)*X.Distance(Z)*0.5;
            }
            else if (Math.Pow(X.Distance(Y), 2) + Math.Pow(Y.Distance(Z), 2) - Math.Pow(X.Distance(Z), 2) < double.Epsilon)
            {
                return X.Distance(Y) * Y.Distance(Z) * 0.5;
            }
            else 
            {
                return X.Distance(Z) * Z.Distance(Y) * 0.5;
            }
        }      
    }
}
