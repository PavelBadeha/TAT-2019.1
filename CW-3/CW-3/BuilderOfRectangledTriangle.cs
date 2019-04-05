using System;

namespace CW_3
{
    class BuilderOfRectangledTriangle:Builder
    {
        public override Triangle Create(Point X, Point Y, Point Z)
        {
            if (IsItRightTriangle(X,Y,Z))
            {
                return new RectangledtTriangle(X,Y,Z);
            }
            else
            {
               return nextBuilder.Create(X,Y,Z);
            }
        }
        public bool IsItRightTriangle(Point X, Point Y, Point Z)
        {
            if(Math.Pow(X.Distance(Y),2)+ Math.Pow(X.Distance(Z),2)-Math.Pow(Y.Distance(Z),2)<double.Epsilon)
            {
                return true;
            }
          else if (Math.Pow(X.Distance(Y), 2) + Math.Pow(Y.Distance(Z), 2) - Math.Pow(X.Distance(Z), 2) < double.Epsilon)
            {
                return true;
            }
          else if (Math.Pow(X.Distance(Z), 2) + Math.Pow(Z.Distance(Y), 2) - Math.Pow(X.Distance(Y), 2) < double.Epsilon)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
