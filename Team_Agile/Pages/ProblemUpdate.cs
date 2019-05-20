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
        public int problemID;

        public ProblemUpdate(int _problemID)
        {
            InitializeComponent();
            problemID = _problemID;
            readProblem();
            showProblem();
        }

        //读取问题内容详情
        private void readProblem() {
            problem=ProblemList.GetProblem(problemID);
        }

        //显示问题的内容详情
        private void showProblem()
        {
            this.Update_Hint.Text = problem.Hint;
            this.Update_InputDescription.Text = problem.InputDescription;
            this.Update_InputSamples.Text = problem.InputSample;
            this.Update_MemLimit.Text = problem.MemoryLimitIndex;
            this.Update_TimeLimit.Text = problem.TimeLimitIndex;
            this.Update_OutputDescription.Text = problem.OutputDescription;
            this.Update_OutputSamples.Text = problem.OutputSample;
            this.Update_QuestionDescription.Text = problem.QuestionDescription;
            this.Update_QuestionName.Text = problem.QuestionName;
        }

        //将修改后的内容详情写入
        private void writeProblem()
        {
            problem.Hint= this.Update_Hint.Text ;
            problem.InputDescription = this.Update_InputDescription.Text;
            problem.InputSample = this.Update_InputSamples.Text;
            problem.MemoryLimitIndex = this.Update_MemLimit.Text;
            problem.TimeLimitIndex = this.Update_TimeLimit.Text;
            problem.OutputDescription = this.Update_OutputDescription.Text;
            problem.OutputSample = this.Update_OutputSamples.Text;
            problem.QuestionDescription = this.Update_QuestionDescription.Text;
            problem.QuestionName = this.Update_QuestionName.Text;
            //更新问题修改
            ProblemList.Add(problem);
        }

        private void Update_ConfirmBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult=MessageBox.Show("确认更新吗？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
                writeProblem();
            else
                return;
        }

        public string QuestionName
        {
            set { Update_QuestionName.Text = value; }
            get { return Update_QuestionName.Text; }
        }

        public string InputSamples {
            set { Update_InputSamples.Text = value; }
            get { return Update_InputSamples.Text; }
        }

        public string OutputSamples {
            set { Update_OutputSamples.Text = value; }
            get { return Update_OutputSamples.Text; }
        }

        public string QuestionDescription {
            set {Update_QuestionDescription.Text = value; }
            get { return Update_QuestionDescription.Text; }
        }
    }
}
