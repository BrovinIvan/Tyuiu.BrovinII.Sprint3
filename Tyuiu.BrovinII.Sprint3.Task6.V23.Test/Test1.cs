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
            Assert.AreEqual(34, ds.GetSumTheDivisors(18,28));
        }
    }
}
