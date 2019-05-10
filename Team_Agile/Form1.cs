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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str = System.Windows.Forms.Application.StartupPath;
            string TargetPath = str.Substring(0, str.Length - 9) + "Properties\\php\\php.exe";
             MessageBox.Show(TargetPath);
        }
    }
}
