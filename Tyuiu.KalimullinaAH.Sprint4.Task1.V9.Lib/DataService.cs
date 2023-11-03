using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KalimullinaAH.Sprint4.Task1.V9.Lib
{//Дан одномерный целочисленный массив на 13 элементов заполненный значениями
 //с клавиатуры в диапазоне от 3 до 8 подсчитать произведение четных элементов массива.
 //С клавиатуры: 6, 3, 3, 7, 7, 7, 7, 3, 3, 6, 4, 4, 8
    public class DataService : ISprint4Task1V9
    {
        public int Calculate(int[] array)
        {
            int res = 1;
             for( int i = 0; i< array.Length;i++)
            {
                if ( array[i] % 2==0)
                {
                    res *= array[i];
                }
            }
            return res;
        }
    }
}
