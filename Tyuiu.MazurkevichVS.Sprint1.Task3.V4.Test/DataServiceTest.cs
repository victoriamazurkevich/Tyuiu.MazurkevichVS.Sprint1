using Tyuiu.MazurkevichVS.Sprint1.Task3.V4.Lib;
namespace Tyuiu.MazurkevichVS.Sprint1.Task3.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double priceNotebook = 2.75;
            double priceCover = 0.5;
            var quantity = 2;
            var res = ds.PurchaseAmount(priceNotebook, priceCover, quantity);
            Assert.AreEqual(6.5, res);
        }
    }
}
