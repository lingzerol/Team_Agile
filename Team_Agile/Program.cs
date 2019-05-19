using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team_Agile.Pages;
using Lib;

namespace Team_Agile
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //加载进题目列表样例，正常流程为获取xml转成 List<StructureOfProblem>传入Questionbank
            List<StructureOfProblem> problems = new List<StructureOfProblem>();
            StructureOfProblem problem1 = new StructureOfProblem();
            problem1.AcceptsRate = "Accept";
            problem1.ProblemID = "1";
            problem1.QuestionName = "动态规划";
            problems.Add(problem1);
            Application.Run(new Questionbank(problems));
        }
    }
}
