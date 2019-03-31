
namespace DEV_5
{
    /// <summary>
    /// The class for space ship object
    /// </summary>
    class SpaceShip : FlyObject, IFlyable
    {
        /// <summary>
        /// The default constructor of class
        /// </summary>
        public SpaceShip()
        {
            flySpeed = 8000 * 3600;
        }

        /// <summary>
        /// The constructor of class with param Point
        /// </summary>
        /// <param name="startPoint"></param>
        public SpaceShip(Point startPoint)
        {
            flySpeed = 8000 * 3600;
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
        public override double GetFlyTime() =>
          Distance / flySpeed;
    }
}
