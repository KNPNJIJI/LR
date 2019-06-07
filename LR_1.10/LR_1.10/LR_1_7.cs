using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_1._10
{
    class LR_1_7
    {
        public void TaskSolution7()
        {
            var nr = new MainMenu();
            HelpMenu();
            Console.WriteLine(" Введите массив 2x3 с клавиатуры\n");

            try
            {
                double[,] array = new double[2, 3];
                for (int j = 0; j < 3; j++)
                    for (int i = 0; i < 2; i++)
                    {
                        Console.Write($"array[{i},{j}]: ");
                        array[i, j] = Double.Parse(Console.ReadLine());
                    }

                for (int j = 0; j < 3; j++)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        Console.Write($" Array[{i},{j}]:{ array[i, j]} ");
                    }
                    Console.WriteLine("   ");
                }
                Console.WriteLine("   ");

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 2; j > -1; j--)
                    {
                        Console.Write($" Array[{i},{j}]:{ array[i, j]} ");
                    }
                    Console.WriteLine("   ");
                }
                Console.ReadLine();

                Console.WriteLine("\nПОВТОРИТЬ? (y/n)");
                if (Console.ReadLine() == "y") TaskSolution7();
                else nr.SwitchMenu();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"ОШИБКА ВВОДА ДАННЫХ! {ex.Message}");
                Console.ReadKey();
                TaskSolution7();
            }
        }

        //метод для вывода heder
        private void HelpMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Условие:  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Напишите программу для вычисления матрицы B," +
                   "которая будет представлять собой результат поворота матрицы A[nxn]" +
                   "на 90 градусов вправо");
            Console.ForegroundColor = ConsoleColor.Green;
            // Console.WriteLine("Решение:");
            // Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
