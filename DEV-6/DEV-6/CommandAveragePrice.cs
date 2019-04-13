namespace DEV_6
{
    /// <summary>
    /// The command to count average price
    /// </summary>
    class CommandAveragePrice : Command
    {
        /// <summary>
        /// The count of all cars
        /// </summary>
        private int countOfAllCars;

        /// <summary>
        /// The count of all price
        /// </summary>
        private double allPrice;

        /// <summary>
        /// The constructor
        /// </summary>
        /// <param name="company">Receiver</param>
        public CommandAveragePrice(Company company) : base(company)
        {
            countOfAllCars = 0;
            allPrice = 0;
        }

        /// <summary>
        /// The override method Execute
        /// </summary>
        /// <returns>The average price of all cars</returns>
        public override double Execute()
        {
           foreach(var element in company.cars)
            {                         
                allPrice += element.Price*element.Quantity;
                countOfAllCars += element.Quantity;
            }
            return allPrice/countOfAllCars;
        }
    }
}
