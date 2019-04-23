﻿using System;

namespace DEV_6
{
    /// <summary>
    /// The commands invoker.
    /// </summary>
    class Invoker
    {
        /// <summary>
        ///The receiver of all commands
        /// </summary>
        private Company company;

        /// <summary>
        /// The constructor
        /// </summary>
        /// <param name="company">The receiver</param>  
        public Invoker(Company company)
        {
            this.company = company;
        }

        /// <summary>
        /// The method that check is there such a brand
        /// </summary>
        /// <param name="type">The name of custom's brand</param>
        public void IsThereSuchBrand(ref string type)
        {
            if (!company.allBrands.Contains(type))
            {
                Console.WriteLine("!!!!Not correct Brand!!!!\nBrands that we have");

                foreach (var typ in company.allBrands)
                {
                    Console.WriteLine(typ);
                }

                Console.WriteLine("Input new Brand");
                type = Console.ReadLine();

                IsThereSuchBrand(ref type);
            }
        }

        /// <summary>
        /// Invokes the commands
        /// </summary>
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
                        string type = Console.ReadLine();
                        IsThereSuchBrand(ref type);

                        command = new CommandAveragePriceType(company, type);
                        Console.WriteLine("average price of " + type + " " + command.Execute());
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