using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_1._10
{
    class LR_1_2
    {
        public void TaskSolution2()
        {
            var nr = new MainMenu();
            HelpMenu();
            Console.WriteLine(" Введите стороны треугольника с клавиатуры\n");

            try
            {
                double A, B, C;
                Console.Write("Enter A: ");
                A = Double.Parse(Console.ReadLine());
                Console.Write("Enter B: ");
                B = Double.Parse(Console.ReadLine());
                Console.Write("Enter C: ");
                C = Double.Parse(Console.ReadLine());
                if (A <= 0 | B <= 0 | C<= 0)
                    throw new InvalidCastException("Стороны не могут быть отрицательными!");

                //Сравнение сторон
                if (A == B & A == C)
                    Console.Write("This is an quilateral triangle");
                else
                    if (((A == B) & ((A + B) > C)) | ((A == C) & ((A + C) > B)) | ((B == C) & ((C + B) > A)))
                    Console.Write("This is an isosceles triangle");
                else
                    if (Comparison(A,B,C))
                { Console.Write("This is a triangular triangle"); }
                else Console.Write("Не существует подобного треугольника!");
                Console.ReadLine();

                Console.WriteLine("\nПОВТОРИТЬ? (y/n)");
                if (Console.ReadLine() == "y") TaskSolution2();
                else nr.SwitchMenu();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"ОШИБКА ВВОДА ДАННЫХ! {ex.Message}");
                Console.ReadKey();
                TaskSolution2();
            }

        }

        static bool Comparison(double A, double B, double C)
        {
            double temp = 0.0;
            bool tTriangle = false;

            //находим наибольшую из сторон
            if (A > temp)
                temp = A;
            if (B > temp)
                temp = B;
            if (C > temp)
                temp = C;

            //проверка, могут ли сочетания длинн являться сторонами треугольника
            if (A == temp)
                if ((B + C) > A) tTriangle = true;
                else tTriangle = false;
            if (B == temp)
                if ((A + C) > B) tTriangle = true;
                else tTriangle = false;
            if (C == temp)
                if ((A + B) > C) tTriangle = true;
                else tTriangle = false;
            return tTriangle;
        }

        //метод для вывода heder
        private void HelpMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Условие:  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Даны 3 числа, являющиеся длинами сторон треугольника.\n" +
                " Определить тип треугольника (равнобедренный, равносторонний, разносторонний)");
            Console.ForegroundColor = ConsoleColor.Green;
            // Console.WriteLine("Решение:");
            // Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
