using NUnit.Framework;
using RandomStuff;
using RandomStuff.MD5;

namespace RandomStuff.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SimpleTest()
        {
            Assert.Pass();
        }

        [Test]
        public void MD5StringTest()
        {
            MD5Gen md5Gen = new MD5Gen();
            Assert.IsNotNull(md5Gen);
            string result = md5Gen.GetMD5("ABC");
            Assert.IsNotEmpty(result);
            Assert.AreEqual("902FBDD2B1DF0C4F70B4A5D23525E932", result);
        }

        [Test]
        public void MD5IntTest()
        {
            MD5Gen md5Gen = new MD5Gen();
            Assert.IsNotNull(md5Gen);
            string result = md5Gen.GetMD5(1234);
            Assert.IsNotEmpty(result);
            Assert.AreEqual("81DC9BDB52D04DC20036DBD8313ED055", result);
            
        }

    }
}