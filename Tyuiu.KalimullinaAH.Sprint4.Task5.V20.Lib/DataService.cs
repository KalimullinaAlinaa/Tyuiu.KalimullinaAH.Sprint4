﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KalimullinaAH.Sprint4.Task5.V20.Lib
{
    public class DataService : ISprint4Task5V20
    {
        public int Calculate(int[,] matrix)
        {
            int count = 0;
           // int rows = matrix.GetUpperBound(0) + 1;
          //  int columns = matrix.Length / rows;
            for (int i=0; i<matrix.GetLength(0);i++)
            {
                for (int j=0; j<matrix.GetLength(1);j++)
                {
                    if (matrix [i,j]>0)
                    {
                        count +=matrix[i, j];
                    }
                }
            }return count;
        }
    }
}
