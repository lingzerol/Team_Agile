using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team_Agile.Pages;
using Lib;
namespace Team_Agile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TurnForm(new Login());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void TurnForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pannel.Controls.Clear();
            this.Pannel.Controls.Add(form);
            form.Show();
        }

        private void Pannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurnForm(new Teacher_Interface());
        }

        private void StudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurnForm(new Student_Interface());
        }
    }
}
