using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_1._10
{
    class LR_1
    {
        public void TaskSolution()
        {
            var nr = new MainMenu();
            HelpMenu();
            Console.WriteLine(" Введите три числа с клавиатуры\n");

            try
            {
                double A = 0, B = 0, C = 0, temp;

                Console.Write("Enter A: ");
                A = Double.Parse(Console.ReadLine());
                Console.Write("Enter B: ");
                B = Double.Parse(Console.ReadLine());
                Console.Write("Enter C: ");
                C = Double.Parse(Console.ReadLine());

                temp = Comparison(A, B, C);
                if (temp == A)
                    Console.Write("A");
                if (temp == B)
                    Console.Write("B");
                if (temp == C)
                    Console.Write("C");
                Console.Write(" - greatest of A, B, C ");
                Console.ReadLine();
                Console.WriteLine("\nПОВТОРИТЬ? (y/n)");
                if (Console.ReadLine() == "y") TaskSolution();
                else nr.SwitchMenu();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"ОШИБКА ВВОДА ДАННЫХ! {ex.Message}");
                Console.ReadKey();
                TaskSolution();
            }

        }

        static double Comparison(double A, double B, double C)
        {
            double temp = -2147483648.0;
            if (A > temp)
                temp = A;
            if (B > temp)
                temp = B;
            if (C > temp)
                temp = C;
            return temp;
        }
        //метод для вывода heder
        private void HelpMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Условие:  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Напишите программу, которая определит наибольшее из трех чисел A, B и C.\n Числа A, B и C вводятся с клавиатуры");
            Console.ForegroundColor = ConsoleColor.Green;
           // Console.WriteLine("Решение:");
           // Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
