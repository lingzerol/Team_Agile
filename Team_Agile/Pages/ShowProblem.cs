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
    public partial class ShowProblem : Form
    {
        public ShowProblem()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PHPRunner php = new PHPRunner();
            php.Code = "<?php\n" + this.SourceCode.Text;
            string result = php.run();
            if(result=="Hello World")
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
    }
}
