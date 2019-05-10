using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestA()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestB()
        {
            Assert.IsFalse(false);
        }
    }
}
