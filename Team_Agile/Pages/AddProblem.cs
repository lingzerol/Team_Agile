using Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Agile.Pages
{
    public partial class AddProblem : Form
    {
        public AddProblem()
        {
            InitializeComponent();
        }

        private void AddProblem_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            ((Form1)(this.ParentForm)).TurnForm(new Questionbank());
        }
        private bool checkProblem()
        {
            if (this.DescriptionInput.Text.Length == 0 || this.ProblemNameInput.Text.Length ==0 || this.TimeLimitInput.Text.Length ==0 || this.MemoryLimitInput.Text.Length==0)
            {
                return true;
            }
            return false;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkProblem())
                {
                    MessageBox.Show("请完善信息");
                    return;
                }
                
                string[] inputSamples = this.InputSampleInput.Text.Split(';');
                string[] outputSamples = this.OutputSampleInput.Text.Split(';');
                if(inputSamples.Length != outputSamples.Length)
                {
                    MessageBox.Show("输入及输出样例不匹配");
                    return;
                }
                string problemName = this.ProblemNameInput.Text;
                string timeLimit = this.TimeLimitInput.Text;
                string memoryLimit = this.MemoryLimitInput.Text;
                string inputDescription = this.InputDescriptionInput.Text;
                string outputDesctiption = this.OutputDescriptionInput.Text;
                string inputSample = this.InputSampleInput.Text;
                string outputSample = this.OutputSampleInput.Text;
                string hint = this.hintInput.Text;
                string decription = this.DescriptionInput.Text;
                StructureOfProblem newProblem = new StructureOfProblem();
                newProblem.ProblemID = ProblemList.GetAll().Values.Last().ProblemID+1;
                newProblem.Hint = hint;
                newProblem.QuestionName = problemName;
                newProblem.TimeLimitIndex = timeLimit;
                newProblem.MemoryLimitIndex = memoryLimit;
                newProblem.InputDescription = inputDescription;
                newProblem.OutputDescription = outputDesctiption;
                newProblem.InputSample = inputSample;
                newProblem.OutputSample = outputSample;
                newProblem.QuestionDescription = decription;
                ProblemList.Add(newProblem);
                ProblemList.Save();
                MessageBox.Show("添加成功");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                return;
            }
            ((Form1)(this.ParentForm)).TurnForm(new Questionbank());

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
