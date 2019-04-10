namespace DEV_6
{
   abstract class Command
    {
        protected Company company;
        public abstract double Execute();      
        public Command(Company company)
        {
            this.company = company; 
        }        
    }
}
