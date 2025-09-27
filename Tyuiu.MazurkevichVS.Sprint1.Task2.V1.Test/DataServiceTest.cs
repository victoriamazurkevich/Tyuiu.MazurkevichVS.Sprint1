using System.ComponentModel.DataAnnotations;
using Tyuiu.MazurkevichVS.Sprint1.Task2.V1.Lib;
namespace Tyuiu.MazurkevichVS.Sprint1.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.ConvertKmToM(x);
            double rounded_res = Math.Round(res, 3);
            Assert.AreEqual(1.243, rounded_res);

        }
    }
}
