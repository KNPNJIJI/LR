using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_1._10
{
    class LR_1_8
    {
        public void TaskSolution8()
        {
            var nr = new MainMenu();
            HelpMenu();
            //Console.WriteLine(" Введите x с клавиатуры \n");

            try
            {
                int num1, num2, sumSpecialNumbers = 0;
                Console.Write("Enter lenght array line: "); //определение размерности прямоугольного массива
                num1 = Int32.Parse(Console.ReadLine());
                Console.Write("Enter lenght array column: ");
                num2 = Int32.Parse(Console.ReadLine());

                double[,] array = new double[num1, num2];
                // ввод массива
                for (int i = 0; i < num1; i++) 
                {
                    for (int j = 0; j < num2; j++)
                    {
                        Console.Write("Enter array[" + i + "," + j + "]: ");
                        array[i, j] = Double.Parse(Console.ReadLine());
                    }
                }
                // вывод массива
                for (int i = 0; i < num1; i++)
                {
                    for (int j = 0; j < num2; j++)
                    {
                        Console.Write(String.Format("{0,7}", array[i, j]));
                    }
                    Console.WriteLine();
                }

                // Подсчёт особых чисел в столбцах
                for (int j = 0; j < num2; j++) 
                {
                    sumSpecialNumbers = sumSpecialNumbers + MaxArrayColumn(j, num1, array);
                    Console.WriteLine();
                }
                Console.ReadLine();

                Console.WriteLine("\nПОВТОРИТЬ? (y/n)");
                if (Console.ReadLine() == "y") TaskSolution8();
                else nr.SwitchMenu();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"ОШИБКА ВВОДА ДАННЫХ! {ex.Message}");
                Console.ReadKey();
                TaskSolution8();
            }
        }

        //метод определения и вывода особого числа в столбце
        static int MaxArrayColumn(int j, int num1, double[,] array)
        {
            int num1Max = 0, num2Max = 0; //переменные для индексов макс числа столбца
            double temp = -2147483648.0, sum = 0;
            for (int i = 0; i < num1; i++)  // поиск наибольшего элемента столбца
            {
                if (array[i, j] > temp)
                {
                    temp = array[i, j];
                    num1Max = i;
                    num2Max = j;
                }
            }
            array[num1Max, num2Max] = 0;
            for (int i = 0; i < num1; i++)  // сумма остальных элементов столбца без потенциально особого
            {
                sum = sum + array[i, j];
            }
            if (temp > sum)
            {
                Console.WriteLine($"Column {num2Max} has a special numbers[{num1Max},{num2Max}] is a {temp} ");
                return 1;
            }
            else
            {
                Console.WriteLine($"There are no special numbers in column {num2Max}");
                return 0;
            }
        }

        //метод для вывода heder
        private void HelpMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Условие:  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Дана прямоугольная матрица. Определить количество особых элементов массива," +
                   "считая его элемент особым, если он больше суммы остальных элементов его столбца \n");
            Console.ForegroundColor = ConsoleColor.Green;
            // Console.WriteLine("Решение:");
            // Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
