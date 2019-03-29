
namespace DEV_3
{
    /// <summary>
    /// Class of Juniors
    /// </summary>
    class Junior:Employee
    {      
        /// <summary>
        /// the constructor of class
        /// </summary>
        public Junior()
        {
            Cost = 100;
            Productivity = 5;        
        }     
      public override string GetName()
        {
            return "Junior";
        }
    }
}
