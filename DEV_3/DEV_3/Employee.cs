
namespace DEV_3
{
    /// <summary>
    /// Abstract class for all employees.
    /// </summary>
    abstract class Employee
    {
        public int Cost { get; protected set; }
        public int Productivity { get; protected set; }

        /// <summary>
        /// virtual method thath return name of class
        /// </summary>
        /// <returns></returns>
        public virtual string GetName()
        {
            return "Employee";
        }
    }
}
