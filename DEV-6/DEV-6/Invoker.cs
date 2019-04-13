using System;
using System.Linq;
using System.Collections.Generic;

namespace DEV_6
{
    /// <summary>
    /// The commands invoker.
    /// </summary>
    class Invoker
    {     
        /// <summary>
        /// The list of all commands
        /// </summary>
        private List<Command> commands;

        /// <summary>
        /// The name of Xml file that contains ifno about cars
        /// </summary>
        private string carXml = string.Empty;

        /// <summary>
        /// The name of Xml file that contains ifno about trucks
        /// </summary
        private string truckXml = string.Empty;

        /// <summary>
        /// The constructor
        /// </summary>
        /// <param name="carXml">The name of Xml file that contains info about cars</param>
        /// <param name="truckXml">The name of Xml file that contains ifno about trucks</param>
        public Invoker(string carXml,string truckXml)
        {
            commands = new List<Command>();
            this.carXml = carXml;
            this.truckXml = truckXml;
        }

        /// <summary>
        /// The method that check is there such a brand?
        /// </summary>
        /// <param name="brandOfCustom">The name of custom's brand</param>
        /// <param name="nameOfXml">The name of Xml file</param>
        private void IsThereSuchBrand(ref string brandOfCustom,string nameOfXml)
        {
            if (!Company.getInstance(nameOfXml).allBrands.Contains(brandOfCustom))
            {
                Console.WriteLine("!!!!Not correct Brand!!!!\nBrands that we have");
                foreach (var brand in Company.getInstance(nameOfXml).allBrands.Distinct())
                {
                    Console.WriteLine(brand);
                }
                
                Console.WriteLine("Input new Brand");
                brandOfCustom = Console.ReadLine();
                IsThereSuchBrand(ref brandOfCustom,nameOfXml);
            }
        }

        /// <summary>
        /// Invokes the commands
        /// </summary>
        public void Invoke()
        {            
            Console.WriteLine("count_types car(truck)- number of car brands\n"
                    + "count_all car(truck) - total number of cars\n"
                    + "average_price car(truck)- average car cost\n"
                    + "average_price car(truck) type -average cost of cars of each brand(the brand is set by the user), for example, average price volvo\n"
                    + "exit\n"
                    +"Input chain of commands than input 'execute'");
            while(true)
            {
                
                string[] commandKeyWords = Console.ReadLine().Split(' ');         
                string nameOfXml = string.Empty;
                const int commandTypeIndex = 0;
                const int commandVehicleIndex = 1;
                const int minimumAmountOfArgs = 2;
                const int commandBrandIndex = 2;
                var commandType = commandKeyWords[commandTypeIndex];

                if (commandType == "execute") 
                {
                    break;
                }

                if (commandKeyWords.Length < minimumAmountOfArgs)
                {
                    Console.WriteLine(
                        "A command must contain at least two arguments: type of command, type of vehicle, (optional for average_price) brand of vehicle");
                    continue;
                }

                var commandVehicle = commandKeyWords[commandVehicleIndex];

                if(commandVehicle=="car")
                {
                    nameOfXml = carXml;
                }

                if(commandVehicle=="truck")
                {
                    nameOfXml = truckXml;
                }             
                
                switch(commandKeyWords[commandTypeIndex])
                {
                    case "count_types":
                        commands.Add(new CommandCountTypes(Company.getInstance(nameOfXml)));
                        break;

                    case "count_all":
                        commands.Add(new CommandCountAll(Company.getInstance(nameOfXml)));
                        break;

                    case "average_price":  
                        
                        if (commandKeyWords.Length==commandBrandIndex+1)
                        {
                            IsThereSuchBrand(ref commandKeyWords[commandBrandIndex],nameOfXml);
                            commands.Add(new CommandAveragePriceType(Company.getInstance(nameOfXml), commandKeyWords[commandBrandIndex]));
                        }

                        else
                        {
                            commands.Add(new CommandAveragePrice(Company.getInstance(nameOfXml)));
                        }                        
                        break;

                    case "exit":
                        Environment.Exit(0);
                        break;
                }
            }

            ///<summary>
            ///The commands execution
            ///</summary>
            foreach (var command in commands)
            {
                Console.WriteLine(command.Execute());
            }
        }
    }
}
