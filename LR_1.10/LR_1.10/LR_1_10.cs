using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_1._10
{
    class LR_1_10
    {
        public void TaskSolution10()
        {
            var nr = new MainMenu();
            HelpMenu();
            Console.WriteLine("Введите строку с клавиатуры\n");

            try
            {
                List<char> text = new List<char> { }; // список исходного текста
                int numChar = 0; // переменная для суммы числа символов
                int tempnum = 0; // переменная для выбора режима работы с текстом
                List<char> codtext = new List<char> { }; // список результирующего текста

                //Console.Write("Введите строку: ");
                foreach (char temp in Console.ReadLine())
                {
                    text.Add(temp);
                    numChar++;
                }

                //выбор режима работы с текстом
                Console.Write("Выберите режим работы с текстом: 1 - получить шифровку, 2 - получить источник.");
                int.TryParse(Console.ReadLine(), out tempnum);
                switch (tempnum)
                {
                    case 1:
                        codtext = Coding(text);
                        break;
                    case 2:
                        codtext = Uncoding(text);
                        break;
                }

                foreach (char n in codtext)
                {
                    Console.Write(n);
                }
                Console.ReadLine();

                Console.WriteLine("\nПОВТОРИТЬ? (y/n)");
                if (Console.ReadLine() == "y") TaskSolution10();
                else nr.SwitchMenu();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ОШИБКА ВВОДА ДАННЫХ!");
                Console.ReadKey();
                TaskSolution10();
            }
        }

        // метод дешифрования
        static List<char> Uncoding(List<char> text)
        {
            List<char> codtext = new List<char> { };
            foreach (char n in text)
            {
                //проверка на ввод "А","Б","В", для исключения выхода за пределы алфавита
                if (n > 1042)
                {
                    int value = n - 3;
                    codtext.Add((char)value);
                }
                else
                {
                    switch (n)
                    {
                        case 'A':
                            codtext.Add('э');
                            break;
                        case 'Б':
                            codtext.Add('ю');
                            break;
                        case 'В':
                            codtext.Add('я');
                            break;
                    }
                }

            }
            return (codtext);
        }

        //метод шифрования 
        static List<char> Coding(List<char> text)
        {
            List<char> codtext = new List<char> { };
            foreach (char n in text)
            {
                //проверка на ввод "э","ю","я", для исключения выхода за пределы алфавита
                if (n < 1101)
                {
                    int value = n + 3;
                    codtext.Add((char)value);
                }
                else
                {
                    switch (n)
                    {
                        case 'э':
                            codtext.Add('A');
                            break;
                        case 'ю':
                            codtext.Add('Б');
                            break;
                        case 'я':
                            codtext.Add('В');
                            break;
                    }
                }

            }
            return (codtext);
        }

        //метод для вывода heder
        private void HelpMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Условие:  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Имеется следующее правило шифрования: каждая буква русского алфавита\n" +
                " заменяется на букву идущую через 3 после нее (например, а -> д).\n" +
                " Исходную строку назовем источник, результирующую – шифровка.\n" +
                " Напишите программу для создания шифровки и получения источника.\n" +
                "Формат ввода: < строка > < 1 | 2 > // 1 - получить шифровку, 2 - получить источник.\n");
            Console.ForegroundColor = ConsoleColor.Green;
            // Console.WriteLine("Решение:");
            // Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
