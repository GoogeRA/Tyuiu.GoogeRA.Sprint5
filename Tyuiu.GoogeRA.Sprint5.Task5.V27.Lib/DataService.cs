using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

//Найти среднее значение всех целых чисел в файле, которые делятся на 5. 
namespace Tyuiu.GoogeRA.Sprint5.Task5.V27.Lib
{
    public class DataService : ISprint5Task5V27
    {
        public double LoadFromDataFile(string path)
        {
            int res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
     
                while ((line = reader.ReadLine()) != null )
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] % 5 == 0) i++;
                        {
                            res++;
                            
                        }
                    }
                }
            }
            return res;

            //int num = int.Parse(Console.ReadLine());
            //while (num != 0)
            //{
             ///   if (num % 5 = 0) k++;
                
            //}
            //Console.WriteLine($"Количество чисел кратных пяти = ", k);


        }
    }
}
