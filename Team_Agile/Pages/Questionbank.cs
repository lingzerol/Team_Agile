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
        private List<StructureOfProblem> problems;
        public Questionbank(List<StructureOfProblem> problems)
        {
            InitializeComponent();
            TableLoad();
            this.problems = problems;
            showlist(problems);
        }

        private void TableLoad()
        {
            this.show_question.GridLines = true;
            this.show_question.View = View.Details;
            this.show_question.Scrollable = true;

            this.show_question.Columns.Add("Pro.Status", 230, HorizontalAlignment.Center);
            this.show_question.Columns.Add("Pro.ID", 150, HorizontalAlignment.Center);
            this.show_question.Columns.Add("Problem Title", 360, HorizontalAlignment.Center);
            this.show_question.Columns.Add("", 130, HorizontalAlignment.Center);
        }
        private void showlist(List<StructureOfProblem> problems)
        {
            for(int i = 0; i < problems.Count(); i++)
            {
                ListViewItem list = new ListViewItem();
                list.Text = problems[i].AcceptsRate;
                list.SubItems.Add(problems[i].ProblemID);
                list.SubItems.Add(problems[i].QuestionName);
                list.SubItems.Add("删除");
                this.show_question.Items.Add(list);
            }
        }

        private void Questionbank_Load(object sender, EventArgs e)
        {

        }


        private void Test_TextChanged(object sender, EventArgs e)
        {

        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            StructureOfQuestionbank.problemTitle = test.Text;
            ProblemStructure problemStructure = new ProblemStructure();
            problemStructure.Show();
            this.Hide();
        }

        private void show_question_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //添加按钮
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("添加");
        }
    }
}
