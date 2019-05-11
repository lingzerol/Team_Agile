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
    public partial class Questionbank : Form
    {
        public Questionbank()
        {
            InitializeComponent();
            TableLoad();
        }

        private void TableLoad()
        {
            this.show_question.GridLines = true;
            this.show_question.View = View.Details;
            this.show_question.Scrollable = true;

            this.show_question.Columns.Add("Pro.ID", 70, HorizontalAlignment.Center);
            this.show_question.Columns.Add("Problem Title", 300, HorizontalAlignment.Center);
            this.show_question.Columns.Add("Ratio(Accepted/Submissions)", 150, HorizontalAlignment.Center);
        }
    }
}
