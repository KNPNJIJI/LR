using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_1._10
{
    class LR_1_9
    {
        public void TaskSolution9()
        {
            var nr = new MainMenu();
            HelpMenu();
            Console.WriteLine(" Введите строку текста с клавиатуры\n");

            try
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

                Console.WriteLine("\nПОВТОРИТЬ? (y/n)");
                if (Console.ReadLine() == "y") TaskSolution9();
                else nr.SwitchMenu();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ОШИБКА ВВОДА ДАННЫХ!");
                Console.ReadKey();
                TaskSolution9();
            }
        }
        //метод вывода с заменой  местами первое и последнее слова в строке
        static void NextString(string[] str)
        {
            Console.WriteLine(str[str.Length - 1]);
            for (int i = 1; i < str.Length - 1; i++)
            {
                Console.WriteLine(str[i]);
            }
            Console.WriteLine(str[0]);
        }

        //метод для вывода heder
        private void HelpMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Условие:  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Дана строка текста, в которой слова разделены пробелами. \n" +
                   "Необходимо: \n" +
                   "  - определить количество слов в строке; \n" +
                   "  - найти самое длинное слово и вывести его на экран; \n" +
                   "  - поменять местами первое и последнее слова в строке, затем вывести текст на экран. \n");
            Console.ForegroundColor = ConsoleColor.Green;
            // Console.WriteLine("Решение:");
            // Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
