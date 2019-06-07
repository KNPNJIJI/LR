using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаём экземпляр класса для меню
            MainMenu MMenu = new MainMenu();

            //вызываем метод - отрисовку меню
            MMenu.SwitchMenu();

        }
    }
}
/*
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_1._9
{
    class Program
    {
        static void NextString(string[] str)
        {
            Console.WriteLine(str[str.Length - 1]);
            for (int i = 1; i < str.Length - 1; i++)
            {
                Console.WriteLine(str[i]);
            }
            Console.WriteLine(str[0]);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            string[] str = input.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int maxlen = 0, index = 0;
            
            //определение самого длинного слова
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxlen)
                {
                    maxlen = str[i].Length;
                    index = i;
                }
            }
            Console.WriteLine("Количество слов в строке {0}", str.Length);
            Console.WriteLine("Самое длинное слово: {0}", str[index]);
            NextString(str);
            Console.ReadLine();

            
        }
    }
}

     */
