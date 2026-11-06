using Tyuiu.BrovinII.Sprint3.Task2.V30.Lib;

namespace Tyuiu.BrovinII.Sprint3.Task2.V30.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(840, ds.GetMultiplySeries(2, 2, 4));
        }
    }
}
