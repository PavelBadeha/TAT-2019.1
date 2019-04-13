using System;

namespace DEV_6
{
    /// <summary>
    /// The main class of program 
    /// get information about cars by parsing XML document.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// The entry point.
        /// <param name="args">
        ///The name of the XML documents to parse.
        /// </param>
        /// </summary>
        static void Main(string[] args)
        {
            try
            {
                if (args.Length < 1)
                {
                    throw new ArgumentOutOfRangeException();
                }

                Company company = new Company(args[0]);
                Invoker invoker = new Invoker(company);

                invoker.Invoke();
            }

            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine(
                    "1 arguments are required: XML doc name with cars info and XML doc name with trucks info");
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

