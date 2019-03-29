
namespace DEV_3
{
    /// <summary>
    /// Class of Seniors
    /// </summary>
    class Senior:Middle
    {       
        /// <summary>
        /// the constructor of class
        /// </summary>
        public Senior()
        {
            Cost *= 2;
            Productivity *= 5;
        }
        public override string GetName()
        {
            return "Senior";
        }
    }
}
