namespace Team_Agile
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pannel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Pannel
            // 
            this.Pannel.Location = new System.Drawing.Point(9, 10);
            this.Pannel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pannel.Name = "Pannel";
            this.Pannel.Size = new System.Drawing.Size(906, 551);
            this.Pannel.TabIndex = 0;
            this.Pannel.Paint += new System.Windows.Forms.PaintEventHandler(this.Pannel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 561);
            this.Controls.Add(this.Pannel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "PHP编程开放实验工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pannel;
    }
}