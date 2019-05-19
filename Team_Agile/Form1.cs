using System.Windows.Forms;

namespace Team_Agile
{
    internal class Form1 : Form
    {
        private Panel panel1;

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(52, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 522);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1052, 642);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);


        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
           // Pages.Questionbank q = new Pages.Questionbank();
           // q.TopLevel = false;
           // panel1.Controls.Add(q);
           // q.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}