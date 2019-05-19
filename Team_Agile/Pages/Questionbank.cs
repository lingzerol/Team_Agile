using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib;

namespace Team_Agile.Pages
{
    public partial class Questionbank : Form
    {
        public Questionbank()
        {
            InitializeComponent();
            TableLoad();
        }

        private void TableLoad()
        {
            this.show_question.GridLines = true;
            this.show_question.View = View.Details;
            this.show_question.Scrollable = true;

            this.show_question.Columns.Add("Pro.ID", 100, HorizontalAlignment.Center);
            this.show_question.Columns.Add("Problem Title", 350, HorizontalAlignment.Center);
            this.show_question.Columns.Add("Ratio(Accepted/Submissions)", 200, HorizontalAlignment.Center);
        }

        private void Questionbank_Load(object sender, EventArgs e)
        {

        }

        //private void Test_Click(object sender, EventArgs e)
        //{
        //    ProblemStructure problemStructure = new ProblemStructure();
        //    problemStructure.Show();
        //    this.Hide();
        //}

        private void Test_TextChanged(object sender, EventArgs e)
        {

        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            StructureOfProblem problem = new StructureOfProblem();
            problem.ProblemID = 1;
            ProblemList.Add(problem);
            ((Form1)(this.ParentForm)).TurnForm(new ProblemStructure(1));
            //StructureOfQuestionbank.problemTitle = test.Text;
            //ProblemStructure problemStructure = new ProblemStructure();
            //problemStructure.Show();
            //this.Hide();
        }

        private void show_question_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
