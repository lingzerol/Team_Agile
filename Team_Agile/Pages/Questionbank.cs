using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Lib;

namespace Team_Agile.Pages
{
    public partial class Questionbank : Form
    {
        private Button btn = new Button();
        public Questionbank()
        {
            InitializeComponent();
            TableLoad();
            showlist();
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
        private void showlist()
        {
            SerializableDictionary<int, StructureOfProblem> problems = ProblemList.GetAll();
            foreach (int key in problems.Keys)
            {
                ListViewItem list = new ListViewItem();
                list.Text = ProblemList.GetProblem(key).AcceptsRate;
                if (list.Text == "")
                    list.Text = "Undo";
                list.SubItems.Add(ProblemList.GetProblem(key).ProblemID.ToString());
                list.SubItems.Add(ProblemList.GetProblem(key).QuestionName);
                this.show_question.Items.Add(list);
            }
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            StructureOfProblem problem = new StructureOfProblem();
            //problem.ProblemID = int.Parse(test.Text);
            //ProblemList.Add(problem);
            Boolean isNumber = true;
            foreach(char a in test.Text)
            {
                if (!Char.IsDigit(a))
                {
                    isNumber = false;
                    break;
                }
            }
            if (isNumber)
            ((Form1)(this.ParentForm)).TurnForm(new ProblemStructure(int.Parse(test.Text)));
            else
            {
                MessageBox.Show("请输入题目ID号");
            }
            //StructureOfQuestionbank.problemTitle = test.Text;
            //ProblemStructure problemStructure = new ProblemStructure();
            //problemStructure.Show();
            //this.Hide();
        }

    


        private void buttondelete_Click(object sender, EventArgs e)
        {
            Boolean Checked =true;
            for(int i=0;i<this.show_question.Items.Count;i++)
            {
                if (this.show_question.Items[i].Checked == true)
                {
                    Checked = false;
                    ProblemList.Delete(int.Parse(this.show_question.Items[i].SubItems[1].Text));
                    ProblemList.Save();
;                }
            }
            //MessageBox.Show(this.show_question.Items[2].SubItems[1].Text);
            if (Checked)
                MessageBox.Show("没有选择要删除的题目");
            else
            {
                this.show_question.Items.Clear();
                showlist();
            }
                
        }

        //添加按钮
        private void button1_Click(object sender, EventArgs e)
        {
            ((Form1)(this.ParentForm)).TurnForm(new AddProblem());
            //AddProblem addProblem = new AddProblem();
            //addProblem.Show();
            //this.Close();
        }


     



        private void show_question_ItemCheck(object sender, ItemCheckEventArgs e)
        {
           //this.show_question.Items[e.Index].Checked = !this.show_question.Items[e.Index].Checked;
            //MessageBox.Show("num:"+ this.show_question.Items[e.Index].Checked);
        }

        private void test_TextChanged(object sender, EventArgs e)
        {
            
        }
        //点击行跳转
        private void show_question_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(this.show_question.SelectedItems.Count==1)
            //MessageBox.Show(e.Item.SubItems[1].Text);
            ((Form1)(this.ParentForm)).TurnForm(new ProblemStructure(int.Parse(e.Item.SubItems[1].Text)));
        }


        private void export_status_Click_1(object sender, EventArgs e)
        {
            SerializableDictionary<int, StructureOfProblem> problems = ProblemList.GetAll();
            SerializableDictionary<int, StructureOfProblem> problemlist = new SerializableDictionary<int, StructureOfProblem>();
            XmlOperator xmlOperator = new XmlOperator();
            foreach (int key in problems.Keys)
            {
                StructureOfProblem p = new StructureOfProblem();
                p.AcceptsRate = ProblemList.GetProblem(key).AcceptsRate;
                p.QuestionName = ProblemList.GetProblem(key).QuestionName;
                p.ProblemID = ProblemList.GetProblem(key).ProblemID;
                problemlist.Add(p.ProblemID, p);                                  
            }
            xmlOperator.XMLSerialized("Problem//ProblemStatus.xml", problemlist);
            //MessageBox.Show("导出成功");
        }
    }
}
