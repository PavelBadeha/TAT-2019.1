using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DEV_1
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            int ErrorIndex = 0;//Index of the word from the command line where the error occurred
            try
            {
                if (args.Length == 0)
                {
                    throw new ArgumentNullException();
                }
                for (int i = 0; i < args.Length; i++)
                {
                    string str = args[i];
                    if (str.Length < 2)
                    {
                        ErrorIndex = i;
                        throw new FormatException();
                    }

                    FinderUniqueSubString UniqueSequence = new FinderUniqueSubString(str);
                    UniqueSequence.SearchSubString();
                    UniqueSequence.PrintUniqueSequence();
                }

            }
            catch (FormatException)
            {
                Console.WriteLine($"Word caused format exception: {args[ErrorIndex]}");
                Console.WriteLine("Less than 2 symbols");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Empty string");
            }
        }   
    }
}