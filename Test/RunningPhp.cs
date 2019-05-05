using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Team_Agile;
namespace Test
{
    [TestClass]
    public class RunningPhp
    {
        [TestMethod]
        public void RunningPhpCgiTest()
        {
            Php php = new Php();
            string request = "hello world!!!";
            string result=php.Excute("echo \"hello world!!!\";");
            Assert.AreEqual(result, request);
        }
    }
}
