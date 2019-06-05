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
    public partial class SubmitProblem : Form
    {
        public StructureOfProblem structureOfProblem;
        public SubmitProblem()
        {
            InitializeComponent();
        }
        public SubmitProblem(StructureOfProblem p)
        {
            InitializeComponent();
            structureOfProblem = p;
            textBox1.Text = structureOfProblem.ProblemID.ToString();
            textBox2.Text = structureOfProblem.QuestionName;
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            PHPRunner php = new PHPRunner();
            php.Code = "<?php\n" + this.SourceCode.Text;
            string result = php.run();
            if(result==structureOfProblem.OutputSample)
            {
                MessageBox.Show("Accepted!");
            }
            else
            {
                MessageBox.Show("Wrong answer");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SourceCode.Text = "";
        }

        private void ShowProblem_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ((Form1)this.ParentForm).TurnForm(new ProblemStructure(structureOfProblem.ProblemID));
            this.Close();
        }

    }
}
