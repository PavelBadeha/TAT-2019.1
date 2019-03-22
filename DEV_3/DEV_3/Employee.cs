
namespace DEV_3
{
   abstract class Employee
    {
         public int Cost { get; protected set; }
         public int Productivity { get; protected set; }
        public virtual string GetName()
        {
            return "Employee";
        }
    }
}
