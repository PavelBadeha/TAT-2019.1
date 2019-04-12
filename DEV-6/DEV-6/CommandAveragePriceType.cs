namespace DEV_6
{
    class CommandAveragePriceType: Command
    {
        private double allPrice;
        private int countOfCars;
        private string Brand = string.Empty;
        public CommandAveragePriceType(Company company,string Brand) : base(company)
        {
            this.Brand = Brand;
            allPrice = 0;
            countOfCars = 0;        
        }
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
