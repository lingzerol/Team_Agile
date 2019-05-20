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
            this.Pannel.Location = new System.Drawing.Point(12, 12);
            this.Pannel.Name = "Pannel";
            this.Pannel.Size = new System.Drawing.Size(1208, 689);
            this.Pannel.TabIndex = 0;
            this.Pannel.Paint += new System.Windows.Forms.PaintEventHandler(this.Pannel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 713);
            this.Controls.Add(this.Pannel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pannel;
    }
}