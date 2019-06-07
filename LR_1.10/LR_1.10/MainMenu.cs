using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_1._10
{
    class MainMenu
    {
        private int MenuNumber; //колличество элементов меню
        private int NItem = 0; //текущий выбранный пункт
        private ConsoleKeyInfo NN; //информация о нажатой клавише

        //header и footer для главного меню (легенда)
        private string Header = "Выберите номер задачи, для решения:";
        private string Footer = "Для выхода из программы нажмите 'Esc'";

        //массив пунтов меню
        string[] MenuItem = new string[]
        {
            "Найти наибольшее из трёх чисел.",
            "Определить тип треугольника по трём сторонам.",
            "Вычислить стоимость покупки с учётом скидки.",
            "Факториал n.",
            "Найти остаток от деления функции f(x) на функцию g(x)",
            "Замените все отрицательные элементы одномерного массива",
            "Поворота матрицы A на 90 градусов",
            "Особые элементы массива",
            "В строке текста, в которой определить количество слов, найти слово, поменять местами ",
            "Шифрование/дешифрование текста"
        };
        public void SwitchMenu()
        {
            MenuNumber = MenuItem.Length;//запоминаем кол-во эл-тов
            PrintMenu();//печатаем меню
            NN = Console.ReadKey();//сохраняем инф-ю о нажатой клавише
            switch (NN.Key)
            {
                case ConsoleKey.Escape:
                    return;
                case ConsoleKey.UpArrow:
                    if (NItem > 0) NItem--;
                    else NItem = MenuNumber - 1;
                    SwitchMenu();
                    break;
                case ConsoleKey.DownArrow:
                    if (NItem < MenuNumber - 1) NItem++;
                    else NItem = 0;
                    SwitchMenu();
                    break;
                case ConsoleKey.Enter:
                    SwitchTask();
                    break;
                default: SwitchMenu(); break;
            }

        }

        //печать меню
        private void PrintMenu()
        {
            Console.Clear();//очистка консоли
            //печатаем header зелёным цветом
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Header}\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            //перебераем массив пунктов меню
            for (int i = 0; i<MenuNumber; i++)
            {
                if (i == NItem) Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{i+1}.{MenuItem[i]}");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n{Footer} \n");
        }
        //выбр задания для отработки
        private void SwitchTask()
        {
            switch (NItem)
            {
                case 0:
                    var Sol01 = new LR_1();
                    Sol01.TaskSolution();
                    break;
                case 1:
                    var Sol02 = new LR_1_2();
                    Sol02.TaskSolution2();
                    break;
                case 2:
                    var Sol03 = new LR_1_3();
                    Sol03.TaskSolution3();
                    break;
                case 3:
                    var Sol04 = new LR_1_4();
                    Sol04.TaskSolution4();
                    break;
                case 4:
                    var Sol05 = new LR_1_5();
                    Sol05.TaskSolution5();
                    break;
                case 5:
                    var Sol06 = new LR_1_6();
                    Sol06.TaskSolution6();
                    break;
                case 6:
                    var Sol07 = new LR_1_7();
                    Sol07.TaskSolution7();
                    break;
                case 7:
                    var Sol08 = new LR_1_8();
                    Sol08.TaskSolution8();
                    break;
                case 8:
                    var Sol09 = new LR_1_9();
                    Sol09.TaskSolution9();
                    break;
                case 9:
                    var Sol10 = new LR_1_10();
                    Sol10.TaskSolution10();
                    break;
            }
        }
    }
}
