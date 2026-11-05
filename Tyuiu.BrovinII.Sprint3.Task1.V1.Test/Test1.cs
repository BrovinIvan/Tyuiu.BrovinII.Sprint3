using Tyuiu.BrovinII.Sprint3.Task1.V1.Lib;

namespace Tyuiu.BrovinII.Sprint3.Task1.V1.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(5.311, ds.GetMultiplySeries(1, 7));
        }
    }
}
