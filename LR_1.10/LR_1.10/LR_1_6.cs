using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_1._10
{
    class LR_1_6
    {
        public void TaskSolution6()
        {
            var nr = new MainMenu();
            HelpMenu();
            Console.WriteLine(" Введите длинну массива\n");

            try
            {
                double[] array;
                double result;
                int lenghtArr = 1;

//                Console.Write("Enter lenght array: ");
                lenghtArr = Int32.Parse(Console.ReadLine());
                array = new double[lenghtArr];

                //цикл для инициализации массива
                for (int i = 0; i < lenghtArr; i++)
                {
                    Console.Write($"Enter array element {i}: ");
                    array[i] = Double.Parse(Console.ReadLine());
                }

                //цикл для проверки на отрицательный элемент массива, замену его на индекс и вывод 
                for (int i = 0; i < lenghtArr; i++)
                {
                    if (array[i] < 0)
                    {
                        int a = Array.IndexOf(array, array[i]);
                        Console.WriteLine($"Index element array <0 :{a}  ");
                    }
                    else
                    {
                        Console.WriteLine($" Element array[{ i}] :{array[i]}  ");
                    }
                }
                Console.ReadLine();

                Console.WriteLine("\nПОВТОРИТЬ? (y/n)");
                if (Console.ReadLine() == "y") TaskSolution6();
                else nr.SwitchMenu();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"ОШИБКА ВВОДА ДАННЫХ!{ex.Message}");
                Console.ReadKey();
                TaskSolution6();
            }
        }

        //метод для вывода heder
        private void HelpMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Условие:  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Замените все отрицательные элементы одномерного массива" +
                   "на индекс, занимаемый данным элементом." +
                   "Элементы массива вводятся с клавиатуры, или задаются случайным образом");
            Console.ForegroundColor = ConsoleColor.Green;
            // Console.WriteLine("Решение:");
            // Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
