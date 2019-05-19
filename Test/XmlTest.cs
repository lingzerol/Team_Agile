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
            p.ProblemID = 1;
            SerializableDictionary<int, StructureOfProblem> problemlist = new SerializableDictionary<int, StructureOfProblem>();
            problemlist.Add(p.ProblemID, p);
            xmlOperator.XMLSerialized("Problem//Problem.xml",problemlist);
            Directory.Exists("Problem//Problem.xml");
        }

        [TestMethod]
        public void XmlreadTest()
        {
            XmlOperator xmlOperator = new XmlOperator();
            SerializableDictionary<int, StructureOfProblem> p = xmlOperator.readXML("Problem//Problem.xml");
            Assert.IsTrue(p.ContainsKey(1));
            Assert.AreEqual("testing", p[1].QuestionDescription);
        }
    }
}
