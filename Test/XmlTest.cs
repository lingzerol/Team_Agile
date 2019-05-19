using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Team_Agile;
using System.IO;
using Lib;

namespace Test
{
    /// <summary>
    /// XmlTest 的摘要说明
    /// </summary>
    [TestClass]
    public class XmlTest
    {
        [TestMethod]
        public void XmlwriteTest()
        {
            XmlOperator xmlOperator = new XmlOperator();
            StructureOfProblem p = new StructureOfProblem();
            p.QuestionDescription = "testing";
            p.QuestionName = "test";
            xmlOperator.XMLSerialized(p);
            Assert.IsTrue(Directory.Exists("Problem//Problem" + p.QuestionName + ".xml"));
        }

        [TestMethod]
        public void XmlreadTest()
        {
            XmlOperator xmlOperator = new XmlOperator();
            StructureOfProblem p = xmlOperator.readXML("test");
            Assert.AreEqual("testing", p.QuestionDescription);
        }
    }
}
