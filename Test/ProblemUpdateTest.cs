using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Team_Agile.Pages;
using Lib;
namespace Test
{
    [TestClass]
    public class ProblemUpdateTest
    {
        [TestMethod]
        public void EditShow()
        {
            StructureOfProblem problem =new StructureOfProblem();
            problem.ProblemID = 1;
            problem.QuestionName = "动态规划";
            problem.InputSample = "1 7 4 9 2 5\r\n1 2 3 4 5 6 7 8 9";
            problem.OutputSample = "6\r\n2";

            ProblemList.GetAll().Clear();
            ProblemList.Add(problem);

            ProblemUpdate problemUpdate = new ProblemUpdate(problem.ProblemID);

            Assert.AreEqual(problemUpdate.QuestionName, problem.QuestionName);
            Assert.AreEqual(problemUpdate.InputSamples, problem.InputSample);
            Assert.AreEqual(problemUpdate.OutputSamples, problem.OutputSample);
            Assert.AreEqual(problemUpdate.QuestionDescription, problem.QuestionDescription);
            
            //修改题目名字
            string newQuestionName = "贪心";
            problemUpdate.QuestionName = newQuestionName;
            Assert.AreEqual(problemUpdate.QuestionName, newQuestionName);
        }
    }
}
                   