
namespace CW_3
{
    class BuilderOfEquilateralTriangle:Builder
    {
        public override Triangle Create(Point X, Point Y, Point Z)
        {
            if(X.Distance(Y)<double.Epsilon && Y.Distance(Z) < double.Epsilon && X.Distance(Z) < double.Epsilon)
            {
                return new EquilateralTriangle(X,Y,Z);         
            }
            else 
            {
               return nextBuilder.Create(X,Y,Z);
            }            
        }
    }
}
