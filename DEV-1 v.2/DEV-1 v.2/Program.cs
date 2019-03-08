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
                if (slovo.Length < 2)                //Провека на правильность ввода 
                {
                    Console.WriteLine("Empty or less than 2 symbols");
                }
                Console.WriteLine($"\n{slovo}\n");
                SubStringFinder obj = new SubStringFinder(slovo);
            }
            Console.ReadKey();
        }
    }
    class SubStringFinder                   //Класс который ищет подстроки 
    {
        public SubStringFinder(string slovo)  //Конструктор принимающий строку 
        {
            bool flag = false;
            string buff;                   // Переменная buff будет принимать в себя подстроки
            string buff2 = string.Empty;   //Перенменная buff2 будет принимать в себя подстроки подстроки(buff) 
            buff = string.Concat(slovo[0]);
            for (int i = 1; i < slovo.Length; i++)
            {
                if (slovo[i] != slovo[i - 1])
                {
                    buff += slovo[i];              //Поиск подстрок с последовательно неповторяющимеся символами 
                }
                else
                {
                    flag = true;
                }
                if (flag || (i == slovo.Length - 1))  //Вычлинение из подстроки все возможные подстроки 
                    while (buff.Length >= 2)                   //Более 2-ух символов 
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