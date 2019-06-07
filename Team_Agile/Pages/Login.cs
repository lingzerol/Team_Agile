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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Stubutton_Click(object sender, EventArgs e)
        {
            Student_Interface stu = new Student_Interface();
            stu.Show();
            this.Close();
        }

        private void Login_TchButton_Click(object sender, EventArgs e)
        {
            Teacher_Interface tch = new Teacher_Interface();
            tch.Show();
            this.Close();
        }
    }
}
