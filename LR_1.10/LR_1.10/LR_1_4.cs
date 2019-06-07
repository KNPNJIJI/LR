using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_1._10
{
    class LR_1_4
    {
        public void TaskSolution4()
        {
            var nr = new MainMenu();
            HelpMenu();
            Console.WriteLine(" Введите n с клавиатуры\n");

            try
            {
                int n;
                n = Int32.Parse(Console.ReadLine());
                Console.Write($" n! = {Faktorial(n)} ");
                Console.ReadLine();

                Console.WriteLine("\nПОВТОРИТЬ? (y/n)");
                if (Console.ReadLine() == "y") TaskSolution4();
                else nr.SwitchMenu();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"ОШИБКА ВВОДА ДАННЫХ!{ex.Message}");
                Console.ReadKey();
                TaskSolution4();
            }

        }
        static int Faktorial(int n)
        {
            if (n > 14)
                throw new InvalidCastException(" Переполнение типа!");
            return (n == 0 ? 1 : n * Faktorial(n - 1));
        }

        //метод для вывода heder
        private void HelpMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Условие:  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Найти n!, где n-заданное число (n!=1*2*3*…*n).\n");
            Console.ForegroundColor = ConsoleColor.Green;
            // Console.WriteLine("Решение:");
            // Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
