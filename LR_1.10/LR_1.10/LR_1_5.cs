using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_1._10
{
    class LR_1_5
    {
        public void TaskSolution5()
        {
            var nr = new MainMenu();
            HelpMenu();
            Console.WriteLine(" Введите x с клавиатуры\n");

            try
            {
                double x, fanctionF, fanctionG;
                double result;
                Console.Write("Enter x: ");
                x = Double.Parse(Console.ReadLine());
                fanctionF = Math.Log(x) / (1 / (Math.Cos(x * Math.PI / 180)) + 2.7 * x);
                fanctionG = Math.Asin(x * Math.PI / 180) + Math.Acos(x * Math.PI / 180) + Math.Sqrt(2 * x);
                result = fanctionF % fanctionG;
                Console.WriteLine($"Remeinder of the division f(x)/g(x) = {result} ");
                // Console.WriteLine("sin  = " + Math.Sin(0 * Math.PI / 180));
                Console.ReadLine();

                Console.WriteLine("\nПОВТОРИТЬ? (y/n)");
                if (Console.ReadLine() == "y") TaskSolution5();
                else nr.SwitchMenu();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ОШИБКА ВВОДА ДАННЫХ!");
                Console.ReadKey();
                TaskSolution5();
            }
        }
       
        //метод для вывода heder
        private void HelpMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Условие:  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Решить следующую задачу: Вводится x. Найти остаток от деления функции f(x) на функцию g(x).\n" +
                   "f(x) = ln x / (1 / cos x + 2,7x); \n" +
                   "g(x) = arcsin x + arccos x + √2x; \n");
            Console.ForegroundColor = ConsoleColor.Green;
            // Console.WriteLine("Решение:");
            // Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
