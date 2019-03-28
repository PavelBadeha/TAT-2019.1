
namespace DEV_3
{
    /// <summary>
    /// Class of Leads
    /// </summary>
    class Lead:Senior
    {      
        /// <summary>
        /// the constructor of class
        /// </summary>
        public Lead()
        {
            Cost *= 2;
            Productivity += 30;
        }
        public override string GetName()
        {
            return "Lead";
        }
    }
}
