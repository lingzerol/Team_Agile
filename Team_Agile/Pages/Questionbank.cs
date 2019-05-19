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
        private Button btn = new Button();
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
            this.show_question.Columns.Add("Pro.ID", 170, HorizontalAlignment.Center);
            this.show_question.Columns.Add("Problem Title", 360, HorizontalAlignment.Center);
            //this.show_question.Columns.Add("", 130, HorizontalAlignment.Center);
        }
        private void showlist(List<StructureOfProblem> problems)
        {
            
            
            for(int i = 0; i < problems.Count(); i++)
            {
                ListViewItem list = new ListViewItem();
                list.Text = problems[i].AcceptsRate;
                list.SubItems.Add(problems[i].ProblemID);
                list.SubItems.Add(problems[i].QuestionName);
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

        private void show_question_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.show_question.SelectedItems.Count > 0)
            {
                this.btn.Location = new Point(this.show_question.SelectedItems[0].SubItems[3].Bounds.Left,
                    this.show_question.SelectedItems[0].SubItems[3].Bounds.Top);
                this.btn.Visible = true;
            }
           
        }
        private void buttondelete_Click(object sender, EventArgs e)
        {
            String text = "";
            for(int i=0;i<this.show_question.Items.Count;i++)
            {
                if (this.show_question.Items[i].Checked == true)
                {
                    text += i
;                }
            }
            MessageBox.Show(text);
        }

        //添加按钮
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("添加");
        }


     

        private void Item_select(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(this.show_question.SelectedItems.Count==1)
            MessageBox.Show(e.Item.Text.ToString());

        }

        private void show_question_ItemCheck(object sender, ItemCheckEventArgs e)
        {
           
           //this.show_question.Items[e.Index].Checked = !this.show_question.Items[e.Index].Checked;
            MessageBox.Show("num:"+ this.show_question.Items[e.Index].Checked);
        }


        private void show_question_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
