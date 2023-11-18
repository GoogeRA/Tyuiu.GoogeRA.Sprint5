using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GoogeRA.Sprint5.Task1.V25.Lib;

namespace Tyuiu.GoogeRA.Sprint5.Task1.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5| Выполнил :  Гооге Р.A. | ПКТб-23-1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #5                                                  *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл           *");
            Console.WriteLine("* Задание #0                                                 *");
            Console.WriteLine("* Вариант #16                                                *");
            Console.WriteLine("* Выполнил :  Гооге Роберт Aлексндрович | ПКТб-23-1          *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат *");
            Console.WriteLine("* сохранить в текстовый файл OutPutFileTask0.txt и           *");
            Console.WriteLine("* вывести на консоль. Округлить до трёх знаков после запятой.*");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine("**************************************************************");

            int startValue = -5;
            int stopValue = 5;

           
            Console.WriteLine("startValue" + startValue);
            Console.WriteLine("stoptValue" + stopValue);

            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");
            Console.WriteLine("**************************************************************");


            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
            
        }
    }
}
