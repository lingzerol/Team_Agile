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
        public Questionbank( )
        {
            InitializeComponent();
            TableLoad();

            
        }

        private void TableLoad()
        {
            this.show_question.GridLines = true;
            this.show_question.View = View.Details;
            this.show_question.Scrollable = true;


            this.show_question.Columns.Add("Pro.Status", 100, HorizontalAlignment.Center);
            this.show_question.Columns.Add("Pro.Id", 100, HorizontalAlignment.Center);
            this.show_question.Columns.Add("Pro.Name", 350, HorizontalAlignment.Center);
 
        }

        private void Questionbank_Load(object sender, EventArgs e)
        {

        }

        public void show(List<StructureOfProblem> problems)
        {
            for (int i = 0; i < problems.Count(); i++)
            {
                StructureOfProblem s = new StructureOfProblem();
                ListViewItem temp = new ListViewItem();
                temp.Text = problems[i].AcceptsRate;
                temp.SubItems.Add(problems[i].ProblemID);
                temp.SubItems.Add(problems[i].QuestionName);
                this.show_question.Items.Add(temp);
            }
        }
        
        private void show_question_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
