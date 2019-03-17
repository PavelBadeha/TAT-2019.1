using System;

namespace DEV_2
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                string str = args[0];

                if (args[0].Length < 2 || args.Length < 1)
                {
                    throw new ArgumentNullException();
                }
                var obj = new MakeTranscription(str);
                obj.ValidationCheck();
                obj.Transcriptor();
                obj.DisplayResult();

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
