﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib;
using Team_Agile.Pages;
using System.Collections.Generic;
using System.Windows.Forms;
using Team_Agile;
namespace Test
{
    [TestClass]
    public class ShowstatusTest
    {
        [TestMethod]
        public void showStatusTest()
        {
                  
            List<StructureOfProblem> problems = new List<StructureOfProblem>();
            StructureOfProblem problem = new StructureOfProblem();
            problem.AcceptsRate = "Accept";
            problem.ProblemID = "1";
            problem.QuestionName = "test";
            problems.Add(problem);
            Questionbank bank = new Questionbank(problems);
            //bank.Show();

            
            ListViewItem temp = bank.Show_question.TopItem;
            Assert.AreEqual(temp.SubItems[1].Text, "1");
            Assert.AreEqual(temp.SubItems[2].Text, "test");
            Assert.AreEqual(temp.Text,"Accept");

        }
    }
}
