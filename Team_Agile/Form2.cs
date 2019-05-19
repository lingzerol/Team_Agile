using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Agile
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
                Pages.Questionbank q = new Pages.Questionbank();
                q.TopLevel = false;
                panel1.Controls.Add(q);
                q.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //string str = AppDomain.CurrentDomain.BaseDirectory;
            //MessageBox.Show(str);
        }
    }
}
