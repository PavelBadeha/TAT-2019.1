
namespace DEV_5
{
    /// <summary>
    /// Interface for flying objects.
    /// </summary>
    interface IFlyable
    {
        /// <summary>
        ///The method that returns the distance between start and finish points
        /// </summary>
        /// <param name="newPoint">finish point</param>
        /// <returns></returns>
        double FlyTo(Point newPoint);

        /// <summary>
        /// The method that returns object name
        /// </summary>
        /// <returns></returns>
        object WhoAmI();

        /// <summary>
        ///The method that returns flight time
        /// </summary>
        /// <returns></returns>
        double GetFlyTime();
    }
}
