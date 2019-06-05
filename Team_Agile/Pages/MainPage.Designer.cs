using Lib;
namespace Team_Agile.Pages
{
    partial class MainPage
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.deletebutton = new System.Windows.Forms.Button();
            this.editbuuton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.treeView1.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.Location = new System.Drawing.Point(-7, -5);
            this.treeView1.Margin = new System.Windows.Forms.Padding(0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(295, 522);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(12, 551);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(276, 41);
            this.deletebutton.TabIndex = 1;
            this.deletebutton.Text = "删除所选项";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.delete);
            // 
            // editbuuton
            // 
            this.editbuuton.Location = new System.Drawing.Point(12, 625);
            this.editbuuton.Name = "editbuuton";
            this.editbuuton.Size = new System.Drawing.Size(276, 39);
            this.editbuuton.TabIndex = 2;
            this.editbuuton.Text = "编辑所选项";
            this.editbuuton.UseVisualStyleBackColor = true;
            this.editbuuton.Click += new System.EventHandler(this.edit);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(288, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 699);
            this.panel1.TabIndex = 3;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 699);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.editbuuton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.treeView1);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);

        }

        #endregion
        SerializableDictionary<int, StructureOfProblem> problems = ProblemList.GetAll();
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button editbuuton;
        private System.Windows.Forms.Panel panel1;

    }
}