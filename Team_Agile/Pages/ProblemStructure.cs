using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib;

namespace Team_Agile.Pages
{
    public partial class ProblemStructure : Form
    {
        private XmlOperator xmlOperator = new XmlOperator();
        private int ID;
        StructureOfProblem structureOfProblem = null;
        //private StructureOfQuestionbank structureOfQuestionbank = new StructureOfQuestionbank();
        public ProblemStructure(int ID)
        {
            this.ID = ID;
            this.Location = new System.Drawing.Point(500, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            InitializeComponent();
            
            try
            {
                structureOfProblem = ProblemList.GetProblem(ID);
                this.questionName.AppendText(structureOfProblem.QuestionName);
                this.timeLimitIndex.AppendText(structureOfProblem.TimeLimitIndex.Length != 0 ? structureOfProblem.TimeLimitIndex : "");
                this.memoryLimitIndex.AppendText(structureOfProblem.MemoryLimitIndex.Length != 0 ? structureOfProblem.MemoryLimitIndex : "");
                //添加+“”，表达int向string的隐式转换
                this.totalAccepts.AppendText(!structureOfProblem.TotalAccepts.Equals(0) ? structureOfProblem.TotalAccepts + "" : "");
                this.totalSubmits.AppendText(!structureOfProblem.TotalSubmits.Equals(0) ? structureOfProblem.TotalSubmits + "" : "");
                this.acceptsRate.AppendText(!structureOfProblem.AcceptsRate.Equals(0) ? structureOfProblem.AcceptsRate : "");
                this.questionDescription.AppendText(structureOfProblem.QuestionDescription.Length != 0 ? structureOfProblem.QuestionDescription : "");
                this.inputDescription.AppendText(structureOfProblem.InputDescription.Length != 0 ? structureOfProblem.InputDescription : "");
                this.outputDescription.AppendText(structureOfProblem.OutputDescription.Length != 0 ? structureOfProblem.OutputDescription : "");
                this.inputSample.AppendText(structureOfProblem.InputSample.Length != 0 ? structureOfProblem.InputSample : "");
                this.outputDescription.AppendText(structureOfProblem.OutputSample.Length != 0 ? structureOfProblem.OutputSample : "");
                this.hint.AppendText(structureOfProblem.Hint.Length != 0 ? structureOfProblem.Hint : "");
                //StructureOfQuestionbank.structureOfProblem = structureOfProblem;
            }
            catch { }
        }




        private void ProblemStructure_Load(object sender, EventArgs e)
        {
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            StructureOfProblem structureOfProblem = new StructureOfProblem();
            structureOfProblem.QuestionName = this.questionName.Text;
            structureOfProblem.TimeLimitIndex = this.timeLimitIndex.Text;
            structureOfProblem.MemoryLimitIndex = this.memoryLimitIndex.Text;
            structureOfProblem.TotalSubmits = this.totalSubmits.Text;
            structureOfProblem.TotalAccepts = this.totalAccepts.Text;
            structureOfProblem.AcceptsRate = this.acceptsRate.Text;
            structureOfProblem.QuestionDescription = this.questionDescription.Text;
            structureOfProblem.InputDescription = this.inputDescription.Text;
            structureOfProblem.OutputDescription = this.outputDescription.Text; 
            structureOfProblem.InputSample = this.inputSample.Text;
            structureOfProblem.OutputSample = this.outputSample.Text;
            structureOfProblem.Hint = this.hint.Text;
            structureOfProblem.ProblemID = ID;
            ProblemList.Add(structureOfProblem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Form1)(this.ParentForm)).TurnForm(new SubmitProblem(structureOfProblem));
            
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            
            ((Form1)this.ParentForm).TurnForm(new Questionbank());
            this.Close();
        }
    }
}
