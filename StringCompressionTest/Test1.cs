

using Assigment3Dotnet;

namespace StringCompressionTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestCompression()
        {
            StringCompression stringCompression = new StringCompression();

            string result = stringCompression.Compress("test");

            Assert.AreEqual("test", result);
        }
    }
}
