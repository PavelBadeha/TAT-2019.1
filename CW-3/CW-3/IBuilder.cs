
namespace CW_3
{
    interface IBuilder
    {
        IBuilder SetNext(IBuilder builder);
        Triangle Create(Point X, Point Y, Point Z);
    }
}
