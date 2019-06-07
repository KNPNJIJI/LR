using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_1._10
{
    class LR_1_3
    {
        public void TaskSolution3()
        {
            var nr = new MainMenu();
            HelpMenu();
            Console.WriteLine(" Введите сумму покупок с клавиатуры\n");

            try
            {
                double cost;
                const double LevelDiscount_1 = 500;
                const double LevelDiscount_2 = 1000;
                //Console.Write("Enter the cost: ");
                cost = Double.Parse(Console.ReadLine());
                if (cost > LevelDiscount_2)
                    cost = cost * 0.95;
                else
                if (cost > LevelDiscount_1)
                    cost = cost * 0.97;
                Console.Write("Total for payment: " + cost);
                Console.ReadLine();

                Console.WriteLine("\nПОВТОРИТЬ? (y/n)");
                if (Console.ReadLine() == "y") TaskSolution3();
                else nr.SwitchMenu();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ОШИБКА ВВОДА ДАННЫХ!");
                Console.ReadKey();
                TaskSolution3();
            }

        }


        //метод для вывода heder
        private void HelpMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Условие:  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Написать программу вычисления стоимости покупки с учетом скидки.\n" +
                " Скидка в 3% предоставляется, если сумма покупки больше 500 руб., в 5% — если сумма больше 1000 руб");
            Console.ForegroundColor = ConsoleColor.Green;
            // Console.WriteLine("Решение:");
            // Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
