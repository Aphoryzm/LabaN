using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDaNuNah
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 550;
            int b = 60;
            int result = DaNuNah.Program.Example(a, b);
            Assert.AreEqual(9, result);
        }
    }
}
