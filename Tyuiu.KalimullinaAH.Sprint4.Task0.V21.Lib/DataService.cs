using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KalimullinaAH.Sprint4.Task0.V21.Lib
{ //Дан одномерный целочисленный массив на 10 элементов
  //заполненный статическими значениями в диапазоне от 0 до 9 подсчитать
  //сумму четных элементов массива.  {8, 2, 4, 3, 8, 5, 6, 7, 9, 8}
    public class DataService : ISprint4Task0V21
    {
        public int GetSumEvenArrEl(int[] array)
        {
             int res = 0;
            for (int i=0; i<= array.Length-1;i++)
                if ( array [i] % 2==0)
                {
                    res += array[i];
                }
            return res;
        }
    }
}
