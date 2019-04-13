using System;

namespace DEV_2
{
    /// <summary>
    ///The main class of the program    
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// The entry point.
        /// <param name="args">String from command line</param>
        /// </summary>
        static void Main(string[] args)
        {
            try
            {
                string str = args[0];

                if (args[0].Length < 2 || args.Length < 1)
                {
                    throw new ArgumentNullException();
                }
                var transcription = new MakeTranscription(str);
                transcription.ValidationCheck();
                transcription.Transcriptor();
                transcription.DisplayResult();

            }          
            catch (ArgumentNullException)
            {
                Console.WriteLine("Empty or less than 2 symbols!");
            }        
            catch (FormatException)
            {
                Console.WriteLine("Missing pointer to stressed letter!");
            }            
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
