using System;
namespace DEV_5
{
    /// <summary>
    /// The abstract class the parent of objects that can fly
    /// </summary>
    abstract class FlyObject
    {
        /// <summary>
        /// <param name="startPoint">the point where the flight begins</param>
        /// <param name="Distance">Distance between start and finish points</param>
        /// <param name="flySpeed">flight speed of object</param>
        /// </summary>
        protected Point startPoint;
        public double Distance { get; protected set; }
        public double flySpeed { get; protected set; }

        /// <summary>
        /// The method that returns object name
        /// </summary>
        /// <returns></returns>
        public object WhoAmI() => this.GetType().Name;

        /// <summary>
        ///The method that returns the distance between start and finish points
        /// </summary>
        /// <param name="newPoint">finish point</param>
        /// <returns></returns>
        public abstract double FlyTo(Point newPoint);

        /// <summary>
        ///The method that returns flight time
        /// </summary>
        /// <returns></returns>
        public abstract double GetFlyTime();

        /// <summary>
        ///The method that inform u about flight
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"Object is: {WhoAmI()}\nFly time is:{GetFlyTime()} hours \nDistance is:{Distance} km\nSpeed is:{flySpeed} hours/km");
        } 
    }
}
