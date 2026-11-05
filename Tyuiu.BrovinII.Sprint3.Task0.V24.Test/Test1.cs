using Tyuiu.BrovinII.Sprint3.Task0.V24.Lib;

namespace Tyuiu.BrovinII.Sprint3.Task0.V24.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0.05057697110832914, ds.GetMultiplySeries(5,4,6));
        }
    }
}
