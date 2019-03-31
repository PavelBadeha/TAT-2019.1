using System;

namespace DEV_5
{
    /// <summary>
    /// The class for bird object 
    /// </summary>
    class Bird:FlyObject,IFlyable
    {
        /// <summary>
        /// The default constructor of class
        /// </summary>
        public Bird()
        {
            Random rnd = new Random();
            flySpeed = rnd.Next(20);
        }

        /// <summary>
        /// The constructor of class with param Point
        /// </summary>
        /// <param name="startPoint"></param>
        public Bird(Point startPoint)
        {
            this.startPoint = startPoint;
            Random rnd = new Random();
            flySpeed = rnd.Next(20);
        }

        /// <summary>
        ///Overridden method FlyTo(Point newPoint)
        /// </summary>
        /// <param name="newPoint"></param>
        /// <returns></returns>
        public override double FlyTo(Point newPoint)
        {
            Distance = startPoint.ColculateDistance(newPoint);
            return Distance;
        }

        /// <summary>
        ///Overridden method GetFlyTime()
        /// </summary>
        /// <param name="newPoint"></param>
        /// <returns></returns>
        public override double GetFlyTime() =>
            Distance / flySpeed;    
    }
}
