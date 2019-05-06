using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Test
{
    [TestClass]
    public class HttpPostTest
    {
        /*
           作为系统，应能运行HTTP/POST的php代码以让用户获得代码执行结果
    （通过浏览器POST数据
    who=casper
    执行的php代码
    echo $_POST['who'];
    应该返回casper）

             */
        [TestMethod]
        public void HttpPostResponseTest()
        {    /*
            string request = "casper";
            HttpPost httpPost = new HttpPost(request);
            string result=httpPost.Excute("echo $_POST['who']");
            Assert.AreEqual(result, request);
            */
        }
    }

   
}
