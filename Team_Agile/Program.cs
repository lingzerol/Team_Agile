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
            ProblemList.Init();

            //StructureOfProblem pro = new StructureOfProblem();
            //pro.AcceptsRate = "Accept";
            //pro.ProblemID = 1;
            //pro.QuestionName = "动态规划";
            //ProblemList.Add(pro);
            //StructureOfProblem pro1 = new StructureOfProblem();
            //pro1.AcceptsRate = "Accept";
            //pro1.ProblemID = 2;
            //pro1.QuestionName = "背包问题";
            //ProblemList.Add(pro1);
            //StructureOfProblem pro2 = new StructureOfProblem();
            //pro2.AcceptsRate = "false";
            //pro2.ProblemID = 4;
            //pro2.QuestionName = "自动机";
            //ProblemList.Add(pro2);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
