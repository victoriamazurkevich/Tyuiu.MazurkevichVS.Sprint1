﻿using Tyuiu.MazurkevichVS.Sprint1.Task1.V17.Lib;
namespace Tyuiu.MazurkevichVS.Sprint1.Task1.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(8, res);
        }
    }
}
