using System;

namespace DEV_6
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Command command;
            Console.WriteLine("count types(1) - количество марок автомобилей\n"
                    + "count all(2) - общее количество автомобилей\n"
                    + "average price(3) - средняя стоимость автомобиля\n"
                    + "average price type(4) - средняя стоимость автомобилей каждой марки(марка задается пользователем), например average price volvo\n"
                    + "exit(0)");
                int choice = Int32.Parse(Console.ReadLine());
            while (true) 
            { 
                  switch (choice)
                  { 
                    case 1:
                        command = new CommandCountTypes(args[0]);
                        command.Execute();
                        choice = Int32.Parse(Console.ReadLine());
                        break;
                    case 2:
                        command = new CommandCountAll(args[0]);
                        command.Execute();
                        choice = Int32.Parse(Console.ReadLine());
                        break;
                    case 3:
                        command = new CommandAveragePrice(args[0]);
                        command.Execute();
                        choice = Int32.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Inuput ur Mark");
                        string Type = Console.ReadLine();
                        command = new CommandAveragePriceType(args[0], Type);
                        command.Execute();
                        choice = Int32.Parse(Console.ReadLine());
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                  }
            }                                                                    
        }
    }
}
