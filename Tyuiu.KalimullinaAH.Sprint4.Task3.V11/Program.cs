using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KalimullinaAH.Sprint4.Task3.V11.Lib;
namespace Tyuiu.KalimullinaAH.Sprint4.Task3.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Калимуллина А.Х | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнила: Калимуллина Алина Халимовна | ИИПб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 4 до 9. Подсчитайте количество   *");
            Console.WriteLine("* нечетных элементов во всем массиве.                                     *");
            Console.WriteLine("* 8, 6, 9, 4, 5                                                           *");
            Console.WriteLine("* 9, 4, 8, 5, 6                                                           *");
            Console.WriteLine("* 9, 7, 9, 8, 4                                                           *");
            Console.WriteLine("* 4, 6, 5, 7, 8                                                           *");
            Console.WriteLine("* 6, 6, 7, 6, 4                                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

      
            int[,] numArry = new int[5, 5] { {8, 6, 9, 4, 5 },
                                           { 9, 4, 8, 5, 6 },
                                           { 9, 7, 9, 8, 4 },
                                           { 4, 6, 5, 7, 8 },
                                           { 6, 6, 7, 6, 4 } };
           

            
            Console.WriteLine("Массив: ");
            for (int i = 0; i < numArry.GetLength(0); i++)
            {
                for (int j = 0; j < numArry.GetLength(1); j++)
                {
                    Console.Write($"{numArry[i, j]} \t");
                }
            }   Console.WriteLine();
            Console.WriteLine();
            
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Kоличество нечетных элементов массива: " + ds.Calculate(numArry));

            Console.ReadKey();
        }
    }
}
