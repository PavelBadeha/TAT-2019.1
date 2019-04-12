using System;
using System.Linq;
namespace DEV_6
{
    class Invoker
    {
        private Company company;
        public Invoker(Company company)
        {
            this.company = company;
        }
        public void checkForValid(ref string brandOfCustom)
        {
            if (!company.allBrands.Contains(brandOfCustom))
            {
                Console.WriteLine("!!!!Not correct Brand!!!!\nBrands that we have");
                foreach (var brand in company.allBrands.Distinct())
                {
                    Console.WriteLine(brand);
                }
                
                Console.WriteLine("Input new Brand");
                brandOfCustom = Console.ReadLine();
                checkForValid(ref brandOfCustom);
            }
        }
        public void Invoke()
        {
            Command command;
            Console.WriteLine("count types(1) - number of car brands\n"
                    + "count all(2) - total number of cars\n"
                    + "average price(3) - average car cost\n"
                    + "average price type(4) -average cost of cars of each brand(the brand is set by the user), for example, average price volvo\n"
                    + "exit(0)");
            int choice = Int32.Parse(Console.ReadLine());
            while (true)
            {
                switch (choice)
                {
                    case 1:
                        command = new CommandCountTypes(company);
                        Console.WriteLine("number of car brands: "+command.Execute());
                        choice = Int32.Parse(Console.ReadLine());
                        break;
                    case 2:
                        command = new CommandCountAll(company);
                        Console.WriteLine("total number of cars: "+command.Execute());
                        choice = Int32.Parse(Console.ReadLine());
                        break;
                    case 3:
                        command = new CommandAveragePrice(company);
                        Console.WriteLine("average car cost: " + command.Execute());
                        choice = Int32.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Inuput ur Brand");
                        string brand = Console.ReadLine();
                        checkForValid(ref brand);
                        command = new CommandAveragePriceType(company, brand);
                        Console.WriteLine("average price of " + brand + " " + command.Execute());
                        choice = Int32.Parse(Console.ReadLine());
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Choose number from 0-4 pls");
                        choice = Int32.Parse(Console.ReadLine());
                        break;
                }
            }
        }
    }
}
