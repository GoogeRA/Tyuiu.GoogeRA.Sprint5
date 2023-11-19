using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GoogeRA.Sprint5.Task2.V30.Lib;

namespace Tyuiu.GoogeRA.Sprint5.Task2.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5| Выполнил :  Гооге Р.A. | ПКТб-23-1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #5                                                  *");
            Console.WriteLine("* Тема: Класс File. структурированных данных текстовый файл  *");
            Console.WriteLine("* Задание #2                                                 *");
            Console.WriteLine("* Вариант #30                                                *");
            Console.WriteLine("* Выполнил :  Гооге Роберт Aлексндрович | ПКТб-23-1          *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов,       *");
            Console.WriteLine("* заполненный значениями с клавиатуры. Заменить положительн  *");
            Console.WriteLine("* элементы массива на 1, отрицательные на 0.                 *");
            Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv             *");
            Console.WriteLine("* и вывести на консоль.                                      *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine("**************************************************************");

            int[,] mtrx = new int[3, 3] { { 3, -1, -3},
                                          {-2, -5, 0},
                                          {-8, -7, 2} };

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }

                Console.WriteLine();
            }

            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");
            Console.WriteLine("**************************************************************");


            string res = ds.SaveToFileTextData(mtrx);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
