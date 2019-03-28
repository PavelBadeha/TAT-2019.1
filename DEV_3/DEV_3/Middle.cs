
namespace DEV_3
{
    /// <summary>
    /// Class of Middles
    /// </summary>
    class Middle:Junior
    {       
        /// <summary>
        /// the constructor of class
        /// </summary>
        public Middle()
        {
            Cost += 50;
            Productivity *= 2;
        }
         public override string GetName()
        {
            return "Middle";
        }
    }
}
