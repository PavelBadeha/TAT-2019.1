using System;

namespace DEV_1
{
    /// <summary>
    ///The main class of program 
    ///search substrings
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// The entry point.
        /// <param name="args">String from comman line</param>
        /// </summary>
        static void Main(string[] args)
        {
            ///<summary>
            ///<param name="ErrorIndex"></param>Index of the word from the command line where the error occurred
            ///</summary>
            int ErrorIndex = 0;

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
                }

            }

            catch (ArgumentNullException)
            {
                Console.WriteLine("Empty string");
            }

            catch (FormatException)
            {
                Console.WriteLine($"Word caused format exception: {args[ErrorIndex]}");
                Console.WriteLine("Less than 2 symbols");
            }

            catch (Exception)
            {
                Console.WriteLine("Unknown error");
            }
        }
    }
}