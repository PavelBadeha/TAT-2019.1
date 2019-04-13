using System;
namespace DEV_6
{
    /// <summary>
    /// main class of program 
    /// get information about cars by parsing XML document.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// The entry point.
        /// <param name="args">
        /// Names of the XML documents to parse.
        /// </param>
        /// </summary>
        static void Main(string[] args)
        {          
            try
            {
                if (args.Length < 2)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Invoker invoker = new Invoker(args[0], args[1]);
                invoker.Invoke();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine(
                    "2 arguments are required: XML doc name with cars info and XML doc name with trucks info");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

