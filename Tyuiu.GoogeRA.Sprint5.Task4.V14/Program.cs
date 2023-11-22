using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.GoogeRA.Sprint5.Task4.V14.Lib;

namespace Tyuiu.GoogeRA.Sprint5.Task4.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5| Выполнил :  Гооге Р.A. | ПКТб-23-1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #5                                                  *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                    *");
            Console.WriteLine("* Задание #4                                                 *");
            Console.WriteLine("* Вариант #14                                                *");
            Console.WriteLine("* Выполнил :  Гооге Роберт Aлексндрович | ПКТб-23-1          *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Дан файл С:DataSprint5InPutDataFileTask4V0.txt             *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формул *");
            Console.WriteLine("* y = sin(x^3)+(2/x) Вычислить по формуле и вернуть результат*");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine("**************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V14.txt";
            Console.WriteLine("данные находятся в файле: " + path);

            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");
            Console.WriteLine("**************************************************************");


            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
           
            Console.ReadKey();
        }
    }
}
