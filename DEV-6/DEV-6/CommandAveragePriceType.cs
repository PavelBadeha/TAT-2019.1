namespace DEV_6
{
    /// /// <summary>
    /// The command to count average price of a certain  type
    /// </summary
    class CommandAveragePriceType : Command
    {
        /// <summary>
        /// The count of all price
        /// </summary>
        private double allPrice;

        /// <summary>
        /// The count of cars
        /// </summary>
        private int countOfCars;

        /// <summary>
        /// The certain type
        /// </summary>
        private string Brand = string.Empty;

        /// <summary>
        /// The constructor
        /// </summary>
        /// <param name="company">The receiver</param>
        /// <param name="Brand">The certain type</param>
        public CommandAveragePriceType(Company company,string Brand) : base(company)
        {
            this.Brand = Brand;
            allPrice = 0;
            countOfCars = 0;        
        }

        /// <summary>
        /// The override method Execute
        /// </summary>
        /// <returns>The average price of certain type</returns>
        public override double Execute()
        {
          foreach(var element in company.cars)
            {
                if(element.Brand.Equals(Brand))
                {
                    allPrice += element.Price*element.Quantity;
                    countOfCars+=element.Quantity;
                }
            }
            return allPrice / countOfCars;        
        }
    }
}
