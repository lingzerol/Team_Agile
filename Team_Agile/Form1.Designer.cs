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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pannel
            // 
            this.Pannel.Location = new System.Drawing.Point(12, 48);
            this.Pannel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pannel.Name = "Pannel";
            this.Pannel.Size = new System.Drawing.Size(1208, 689);
            this.Pannel.TabIndex = 0;
            this.Pannel.Paint += new System.Windows.Forms.PaintEventHandler(this.Pannel_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TeacherToolStripMenuItem,
            this.StudentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1232, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TeacherToolStripMenuItem
            // 
            this.TeacherToolStripMenuItem.Name = "TeacherToolStripMenuItem";
            this.TeacherToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.TeacherToolStripMenuItem.Text = "教师端";
            this.TeacherToolStripMenuItem.Click += new System.EventHandler(this.TeacherToolStripMenuItem_Click);
            // 
            // StudentToolStripMenuItem
            // 
            this.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem";
            this.StudentToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.StudentToolStripMenuItem.Text = "学生端";
            this.StudentToolStripMenuItem.Click += new System.EventHandler(this.StudentToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 748);
            this.Controls.Add(this.Pannel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "PHP编程开放实验工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pannel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StudentToolStripMenuItem;
    }
}