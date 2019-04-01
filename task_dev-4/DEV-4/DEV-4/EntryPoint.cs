using System;

namespace DEV_4
{

    /// <summary>
    /// The main class of program.
    /// </summary>
    class EntryPoint
    {

        /// <summary>
        /// The entry point of program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {      
                // Create new discipline.               .                  
                Discipline discipline = new Discipline();                        
            }
            catch (FormatException)
            {
                Console.WriteLine("Exception:length exceeds the allowable value ");
            }
            catch(Exception)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
