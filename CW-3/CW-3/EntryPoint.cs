using System;

namespace CW_3
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Point X = new Point(2, 3);
                Point Y = new Point(7, 9);
                Point Z = new Point(5, 1);
                var builderOfTriangle = new BuilderOfRectangledTriangle();
                builderOfTriangle.SetNext(new BuilderOfEquilateralTriangle()).SetNext(new BuilderOfSimpleTriangle());
                Triangle triangle = builderOfTriangle.Create(X, Y, Z);
                Console.WriteLine(triangle.GetSquere());
            }
            catch(FormatException)
            {
                Console.WriteLine("Error!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }         
        }
    }
}
