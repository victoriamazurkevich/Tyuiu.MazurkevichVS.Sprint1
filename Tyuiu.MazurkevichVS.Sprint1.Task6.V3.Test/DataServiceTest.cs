using Tyuiu.MazurkevichVS.Sprint1.Task6.V3.Lib;
namespace Tyuiu.MazurkevichVS.Sprint1.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string value = "Маша ловит рыбу";
            string res = ds.LastLetterWord(value);
            Assert.AreEqual("ату", res);
        }
    }
}
