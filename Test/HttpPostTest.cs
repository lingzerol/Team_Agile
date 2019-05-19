using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib;
namespace Test
{
    [TestClass]
    public class HttpPostTest
    {
        [TestMethod]
        public void HttpPostResponseTest()
        {    
            string request = "casper";
            HttpPost httpPost = new HttpPost(request);
            string result=httpPost.Excute("echo $_POST['who']");
            Assert.AreEqual(result, request);
           
        }
    }

   
}
