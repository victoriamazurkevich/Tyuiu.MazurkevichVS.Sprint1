using Tyuiu.MazurkevichVS.Sprint1.Task0.V10.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.MazurkevichVS.Sprint1.Task0.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double res = ds.Calculate();
            Assert.AreEqual(-10.5, res);
        }
    }
}