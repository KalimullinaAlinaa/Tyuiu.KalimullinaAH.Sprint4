using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KalimullinaAH.Sprint4.Task0.V21.Lib;
namespace Tyuiu.KalimullinaAH.Sprint4.Task0.V21.Test
{//Дан одномерный целочисленный массив на 10 элементов
 //заполненный статическими значениями в диапазоне от 0 до 9 подсчитать
 //сумму четных элементов массива.  {8, 2, 4, 3, 8, 5, 6, 7, 9, 8}

    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();
            int[] array = { 8, 2, 4, 3, 8, 5, 6, 7, 9, 8 };
            int res = ds.GetSumEvenArrEl(array);
            int wait = 36;
            Assert.AreEqual(wait, res);
        }
    }
}
