using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Agile.QuestionBank
{
    public partial class QuestionBank : Form
    {
        public QuestionBank()
        {
            InitializeComponent();
            TableLoad();
        }

        private void TableLoad()
        {
            show_problembank.GridLines = true;

            this.show_problembank.View = View.Details;
            this.show_problembank.Scrollable = true;

            this.show_problembank.Columns.Add("Pro.ID",70,HorizontalAlignment.Center);
            this.show_problembank.Columns.Add("Problem Title", 300, HorizontalAlignment.Center);
            this.show_problembank.Columns.Add("Ratio(Accepted/Submissions)", 150, HorizontalAlignment.Center);
        }
    }
}
