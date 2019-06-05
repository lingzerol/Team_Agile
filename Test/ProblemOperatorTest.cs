using System;
using Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class ProblemOperatorTest
    {
        [TestMethod]
        public void AddTest()
        {
            ProblemList.Init();
            int size = ProblemList.GetAll().Values.Count;
            StructureOfProblem newProblem = new StructureOfProblem();
            newProblem.ProblemID = 9;
            newProblem.Hint = "test";
            newProblem.QuestionName = "test";
            newProblem.TimeLimitIndex = "test";
            newProblem.MemoryLimitIndex = "test";
            newProblem.InputDescription = "test";
            newProblem.OutputDescription = "test";
            newProblem.InputSample = "test";
            newProblem.OutputSample = "test";
            newProblem.QuestionDescription = "test";
            ProblemList.Add(newProblem);
            Assert.AreEqual(ProblemList.GetAll().Values.Count,size+1);
        }
        [TestMethod]
        public void DeleteTest()
        {
             ProblemList.Init();
            StructureOfProblem newProblem = new StructureOfProblem();
            newProblem.ProblemID = 9;
            newProblem.Hint = "test";
            newProblem.QuestionName = "test";
            newProblem.TimeLimitIndex = "test";
            newProblem.MemoryLimitIndex = "test";
            newProblem.InputDescription = "test";
            newProblem.OutputDescription = "test";
            newProblem.InputSample = "test";
            newProblem.OutputSample = "test";
            newProblem.QuestionDescription = "test";
            ProblemList.Add(newProblem);
            int size = ProblemList.GetAll().Values.Count;
            ProblemList.Delete(9);
            Assert.AreEqual(ProblemList.GetAll().Values.Count, size-1);
        }
    }
}
