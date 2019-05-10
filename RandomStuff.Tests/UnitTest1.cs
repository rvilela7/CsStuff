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
            var str = MD5Gen.CreateMD5("ABCDEF");
            var result = "8827a41122a5028b9808c7bf84b9fcf6".ToUpper();
            Assert.IsTrue(str.Equals(result));
        }
    }
}
