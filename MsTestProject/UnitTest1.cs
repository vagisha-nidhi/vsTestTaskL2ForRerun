using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace vsTestTaskL2ForRerun
{
    [TestClass]
    public class UnitTest1
    {
        private static int counter = 1;

        [TestMethod]
        [Priority(0)]
        public void TestMethod1()
        {
            counter++;
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Priority(0)]
        public void TestMethod2()
        {
            counter++;
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Priority(0)]
        public void TestMethod3()
        {
            Assert.IsTrue(counter == 1);
        }
    }
}
