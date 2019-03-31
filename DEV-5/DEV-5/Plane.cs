
namespace DEV_5
{
    /// <summary>
    /// The class for plane object
    /// </summary>
    class Plane : FlyObject, IFlyable
    {
        /// <summary>
        /// <param name="flyTime">flight time of the plane</param>
        /// </summary>
        private double flyTime = 0;

        /// <summary>
        /// The default constructor of class
        /// </summary>
        public Plane()
        {
            flySpeed = 200;
        }

        /// <summary>
        /// The constructor of class with param Point
        /// </summary>
        public Plane(Point startPoint)
        {
            flySpeed = 200;
            this.startPoint = startPoint;
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
        public override double GetFlyTime()
        {
            for (int i = 0; i < Distance/10; i++)
            {               
                flyTime += 10 / flySpeed;            
                flySpeed += 10;
            }
            return flyTime;
        }    
    }
}
