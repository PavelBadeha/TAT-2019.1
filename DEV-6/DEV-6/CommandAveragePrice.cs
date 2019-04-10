
namespace DEV_6
{
    class CommandAveragePrice : Command
    {
        private int countOfAllCars;
        private double allPrice;
        public CommandAveragePrice(Company company) : base(company)
        {
            countOfAllCars = 0;
            allPrice = 0;
        }
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
