using Tyuiu.MazurkevichVS.Sprint1.Task4.V14.Lib;
namespace Tyuiu.MazurkevichVS.Sprint1.Task4.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            double rounded_res = Math.Round(res, 3);
            Assert.AreEqual(0.062, rounded_res);
        }
    }
}
