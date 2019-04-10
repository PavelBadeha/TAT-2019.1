using System;
using System.Xml;

namespace DEV_6
{
    class CommandAveragePriceType: Command
    {
        private double allPrice;
        private int countOfCars;
        private string Type = string.Empty;
        public CommandAveragePriceType(Company company,string Type) : base(company)
        {
            this.Type = Type;
            allPrice = 0;
            countOfCars = 0;        
        }
        public override double Execute()
        {
          foreach(var element in company.cars)
            {
                if(element.Mark.Equals(Type))
                {
                    allPrice += element.Price*element.Quantity;
                    countOfCars+=element.Quantity;
                }
            }
            return allPrice / countOfCars;        
        }
    }
}
