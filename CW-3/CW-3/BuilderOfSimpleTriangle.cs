
namespace CW_3
{
    class BuilderOfSimpleTriangle:Builder
    {
        public override Triangle Create(Point X, Point Y, Point Z)
        { 
          return new EquilateralTriangle(X,Y,Z);  
        }
    }
}
