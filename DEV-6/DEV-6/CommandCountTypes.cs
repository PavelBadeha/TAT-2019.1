namespace DEV_6
{
    /// <summary>
    /// The command to count all brands of car
    /// </summary>
    class CommandCountTypes : Command
    {
        /// <summary>
        /// The constructor
        /// </summary>
        /// <param name="company">The receiver</param>
        public CommandCountTypes(Company company) : base(company)
        { }

        /// <summary>
        /// The override method Execute
        /// </summary>
        /// <returns>The count of all brands</returns>
        public override double Execute()=>
            company.allBrands.Capacity;          
    }
}
