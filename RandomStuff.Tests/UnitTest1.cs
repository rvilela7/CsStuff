using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomStuff;

namespace RandomStuff.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.isFail(1==0);
        }
    }
}
