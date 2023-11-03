﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KalimullinaAH.Sprint4.Task0.V21.Lib;
namespace Tyuiu.KalimullinaAH.Sprint4.Task0.V21
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
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнила: Калимуллина Алина Халимовна | ИИПб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать                *");
            Console.WriteLine("* сумму четных элементов массива.  {8, 2, 4, 3, 8, 5, 6, 7, 9, 8}         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = {8, 2, 4, 3, 8, 5, 6, 7, 9, 8 };

            Console.Write("Исходный массив:");
            for (int i = 0; i <= array.Length-1 ; i++)
            {
                Console.WriteLine(array[i]);
            }

           

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Сумма всех чётных элеметов массива: " + ds.GetSumEvenArrEl(array));
           
            Console.ReadKey();
        }
    }
}
