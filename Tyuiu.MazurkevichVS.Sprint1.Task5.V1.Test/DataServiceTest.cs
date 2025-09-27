using Tyuiu.MazurkevichVS.Sprint1.Task5.V1.Lib;
namespace Tyuiu.MazurkevichVS.Sprint1.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 1.0;
            double x2 = 4.0;
            double y1 = 2.0;
            double y2 = 6.0;
            double res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            res = Convert.ToInt32(res);
            Assert.AreEqual(5, res);
        }
    }
}
