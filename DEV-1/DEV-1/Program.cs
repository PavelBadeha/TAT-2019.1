using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                string slovo = args[i];
                if (slovo.Length < 2)
                {
                    Console.WriteLine("Empty or less then 2 symbols");
                }

                Console.WriteLine($"\n{slovo}\n");
                SubStringFinder obj = new SubStringFinder(slovo);
            }
            Console.ReadKey();
        }
    }
    class SubStringFinder
    {
        public SubStringFinder(string slovo)
        {
            bool flag = false;
            string buff;
            string buff2 = string.Empty;
            buff = string.Concat(slovo[0]);
            for (int i = 1; i < slovo.Length; i++)
            {
                if (slovo[i] != slovo[i - 1])
                {
                    buff += slovo[i];
                }
                else
                {
                    flag = true;
                }

                if (flag || (!flag && i == slovo.Length - 1))
                    while (buff.Length >= 2)
                    {
                        for (int k = 0; k < buff.Length; k++)
                        {
                            buff2 += buff[k];
                            if (buff2.Length >= 2)
                            {
                                Console.WriteLine(buff2);
                            }
                        }
                        buff = buff.TrimStart(buff[0]);
                        buff2 = string.Empty;
                    }
                flag = false;
            }
        }
    }
}


