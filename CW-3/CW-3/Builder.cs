using System;
    
namespace CW_3
{
    class Builder:IBuilder
    {
        public IBuilder nextBuilder { get; set; }
        public IBuilder SetNext(IBuilder nextBuilder)
        {
            this.nextBuilder = nextBuilder;
            return nextBuilder;
        }
        public virtual Triangle Create(Point X,Point Y, Point Z)
        {
            if (nextBuilder != null)
            {
               return nextBuilder.Create(X,Y,Z);
            }
            else
            {
                throw new FormatException();
            }
        }
    }
}
