namespace DEV_6
{
    /// <summary>
    /// The command to count all cars
    /// </summary>
    class CommandCountAll: Command
    {
        /// <summary>
        /// The count of all cars
        /// </summary>
        private int QuantityOfAll;

        /// <summary>
        /// The construcor
        /// </summary>
        /// <param name="company">The receiver</param>
        public CommandCountAll(Company company) : base(company)
        {
            QuantityOfAll = 0;
        }

        /// <summary>
        /// The override method Execute
        /// </summary>
        /// <returns>The count of all cars</returns>
        public override double Execute()
        {
            foreach(var element in company.cars)
            {
                QuantityOfAll += element.Quantity;
            }
            return QuantityOfAll;
        }
    }
}
