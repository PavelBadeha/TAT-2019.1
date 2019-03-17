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

                for (int i = 0; i < str.Length; i++)          //Validation check
                {
                    if (str[i] == '+' || str[i] == 'ё')
                    {                      
                        break;
                    }
                    if (i + 1 == str.Length)
                    {
                        throw new FormatException();
                    }
                }

                var obj = new MakeTranscription(str);
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
