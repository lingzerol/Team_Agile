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
    public partial class Teacher_Interface : Form
    {
        public Teacher_Interface()
        {
            InitializeComponent();
        }

        private void Teacher_Interface_Load(object sender, EventArgs e)
        {
            this.Main_TreeView.LabelEdit = true;
           
        }
    }
}
