using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib;
namespace Team_Agile.Pages
{
    public partial class ProblemUpdate : Form
    {
        public StructureOfProblem problem;

        public ProblemUpdate()
        {
            InitializeComponent();
            //readProblem();
            //showProblem();


        }

        //读取问题内容详情
        private void readProblem() {
            byte[] byData = new byte[200];
            char[] charData = new Char[200];

            try
            {
                FileStream aFile = new FileStream("Problem//Problem" + problem.QuestionName + ".xml", FileMode.Open);
                aFile.Seek(0, SeekOrigin.Begin);
                aFile.Read(byData, 0, 200);
            }
            catch (IOException e)
            {
                Console.WriteLine("An IO exception has been thrown!");
                Console.WriteLine(e.ToString());
                Console.ReadKey();
                return;
            }

            Decoder d = Encoding.UTF8.GetDecoder();
            d.GetChars(byData, 0, byData.Length, charData, 0);

            string ss = "1 2\r\n 3 4\r\n 4 5  \r\n";
            char[] charData2 = ss.ToCharArray();
        }

        //显示问题的内容详情
        private void showProblem()
        {
            this.Update_Hint.Text = problem.Hint;
            this.Update_InputDescription.Text = problem.InputDescription;
            this.Update_InputSamples.Text = problem.InputSample;
            this.Update_MemLimit.Text = problem.MemoryLimitIndex;
            this.Update_OutputDescription.Text = problem.OutputDescription;
            this.Update_OutputSamples.Text = problem.OutputSample;
            this.Update_PassPercent.Text = problem.AcceptsRate;
            this.Update_ProblemDescription.Text = problem.QuestionDescription;
            this.Update_ProblemName.Text = problem.QuestionName;
        }

        //将修改后的内容详情写入
        private void writeProblem()
        {
            problem.Hint= this.Update_Hint.Text ;
            problem.InputDescription = this.Update_InputDescription.Text;
            problem.InputSample = this.Update_InputSamples.Text;
            problem.MemoryLimitIndex = this.Update_MemLimit.Text;
            problem.OutputDescription = this.Update_OutputDescription.Text;
            problem.OutputSample = this.Update_OutputSamples.Text;
            problem.AcceptsRate = this.Update_PassPercent.Text;
            problem.QuestionDescription = this.Update_ProblemDescription.Text;
            problem.QuestionName = this.Update_ProblemName.Text;
        }

        private void Update_ConfirmBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult=MessageBox.Show("确认更新吗？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
                writeProblem();
            else
                return;
        }
    }
}
