using Tyuiu.MazurkevichVS.Sprint1.Task7.V22.Lib;
namespace Tyuiu.MazurkevichVS.Sprint1.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double z = ds.Calculate(x, y);
            double expected = Math.Pow((1 - Math.Tan(x)), 1.0 / Math.Tan(x)) + Math.Cos(x - y);
            Assert.AreEqual(expected, z);
        }
    }
}
