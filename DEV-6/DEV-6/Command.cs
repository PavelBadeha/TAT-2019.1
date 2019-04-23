namespace DEV_6
{
    /// <summary>
    /// The abstract class parent for all commands 
    /// </summary>
    abstract class Command
    {
        /// <summary>
        /// The class receiver
        /// </summary>
        protected Company company;

        /// <summary>
        /// Executes the command
        /// </summary>
        /// <returns> The necessary amount</returns>
        public abstract double Execute();

        /// <summary>
        /// The constructor
        /// </summary>
        /// <param name="company">The receiver</param>
        public Command(Company company)
        {
            this.company = company; 
        }        
    }
}
