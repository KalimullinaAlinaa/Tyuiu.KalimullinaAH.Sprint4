﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KalimullinaAH.Sprint4.Task6.V1.Lib;
namespace Tyuiu.KalimullinaAH.Sprint4.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var f = new string[] { "Яблоко", "Банан", "Вишня", "Драгонфрут", "Бузина", "Инжир", "Виноград" };
            int res = ds.Calculate(f);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
