using System;
using System.Collections.Generic;

namespace DEV_5
{
    /// <summary>
    /// The entry point.
    /// Create flying object
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// The main method colculate flying time from start point to finish point
        /// </summary>
        static void Main()
        {
            try
            {
                Point startPoint = new Point(0, 0, 0);
                Point finishPoint = new Point(100, 200, 800);
                List<FlyObject> flyObjects = new List<FlyObject>();
                flyObjects.Add(new Bird(startPoint));
                flyObjects.Add(new Plane(startPoint));
                flyObjects.Add(new SpaceShip(startPoint));
                foreach (var flyObj in flyObjects)
                {
                    flyObj.FlyTo(finishPoint);
                    flyObj.DisplayInfo();
                }
            }
            catch(Exception)
            {
                Console.WriteLine("ERROR!");
            }          
        }
    }
}
