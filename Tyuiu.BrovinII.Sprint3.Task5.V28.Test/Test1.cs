using Tyuiu.BrovinII.Sprint3.Task4.V20.Lib;

namespace Tyuiu.BrovinII.Sprint3.Task4.V20.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(8.798, ds.GetSumSumSeries(3,1,2,1,2));
        }
    }
}
