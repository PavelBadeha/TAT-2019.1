using System;
using System.Xml;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class CommandCountAll: Command
    {
        private int QuantityOfAll;
        public CommandCountAll(Company company) : base(company)
        {
            QuantityOfAll = 0;
        }
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
