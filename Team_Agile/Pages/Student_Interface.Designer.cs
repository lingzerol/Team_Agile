namespace Team_Agile.Pages
{
    partial class Student_Interface
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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("PHP/MySQL三日通");
            this.TreeViewPanel = new System.Windows.Forms.Panel();
            this.Main_TreeView = new System.Windows.Forms.TreeView();
            this.panel_Problem = new System.Windows.Forms.Panel();
            this.panel_Answer = new System.Windows.Forms.Panel();
            this.Problem_tabControl = new System.Windows.Forms.TabControl();
            this.Problem_Description = new System.Windows.Forms.TabPage();
            this.Problem_Description_HTML = new System.Windows.Forms.TabPage();
            this.Standard_Answer = new System.Windows.Forms.TabPage();
            this.Standard_Answer_Original_Output = new System.Windows.Forms.TabPage();
            this.Standard_Answer_Output_Browse = new System.Windows.Forms.TabPage();
            this.Answer_tabControl = new System.Windows.Forms.TabControl();
            this.Answer_Code = new System.Windows.Forms.TabPage();
            this.Original_Output = new System.Windows.Forms.TabPage();
            this.Browse_Output = new System.Windows.Forms.TabPage();
            this.Note = new System.Windows.Forms.TabPage();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_See_Answer = new System.Windows.Forms.Button();
            this.btn_Run_Answer = new System.Windows.Forms.Button();
            this.btn_Run_Code = new System.Windows.Forms.Button();
            this.label_Exercise_title = new System.Windows.Forms.Label();
            this.label_Exercise_Name = new System.Windows.Forms.Label();
            this.TreeViewPanel.SuspendLayout();
            this.panel_Problem.SuspendLayout();
            this.panel_Answer.SuspendLayout();
            this.Problem_tabControl.SuspendLayout();
            this.Answer_tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // TreeViewPanel
            // 
            this.TreeViewPanel.Controls.Add(this.Main_TreeView);
            this.TreeViewPanel.Location = new System.Drawing.Point(5, 5);
            this.TreeViewPanel.Name = "TreeViewPanel";
            this.TreeViewPanel.Size = new System.Drawing.Size(200, 550);
            this.TreeViewPanel.TabIndex = 0;
            // 
            // Main_TreeView
            // 
            this.Main_TreeView.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.Main_TreeView.Location = new System.Drawing.Point(0, 0);
            this.Main_TreeView.Name = "Main_TreeView";
            treeNode2.Name = "Tree_Root";
            treeNode2.Text = "PHP/MySQL三日通";
            this.Main_TreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.Main_TreeView.Size = new System.Drawing.Size(200, 550);
            this.Main_TreeView.TabIndex = 1;
            // 
            // panel_Problem
            // 
            this.panel_Problem.AutoScroll = true;
            this.panel_Problem.Controls.Add(this.label_Exercise_Name);
            this.panel_Problem.Controls.Add(this.label_Exercise_title);
            this.panel_Problem.Controls.Add(this.btn_Run_Code);
            this.panel_Problem.Controls.Add(this.btn_Run_Answer);
            this.panel_Problem.Controls.Add(this.btn_See_Answer);
            this.panel_Problem.Controls.Add(this.btn_Save);
            this.panel_Problem.Controls.Add(this.Problem_tabControl);
            this.panel_Problem.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.panel_Problem.Location = new System.Drawing.Point(211, 5);
            this.panel_Problem.Name = "panel_Problem";
            this.panel_Problem.Size = new System.Drawing.Size(665, 330);
            this.panel_Problem.TabIndex = 1;
            // 
            // panel_Answer
            // 
            this.panel_Answer.AutoScroll = true;
            this.panel_Answer.Controls.Add(this.Answer_tabControl);
            this.panel_Answer.Location = new System.Drawing.Point(211, 341);
            this.panel_Answer.Name = "panel_Answer";
            this.panel_Answer.Size = new System.Drawing.Size(665, 214);
            this.panel_Answer.TabIndex = 2;
            // 
            // Problem_tabControl
            // 
            this.Problem_tabControl.Controls.Add(this.Problem_Description);
            this.Problem_tabControl.Controls.Add(this.Problem_Description_HTML);
            this.Problem_tabControl.Controls.Add(this.Standard_Answer);
            this.Problem_tabControl.Controls.Add(this.Standard_Answer_Original_Output);
            this.Problem_tabControl.Controls.Add(this.Standard_Answer_Output_Browse);
            this.Problem_tabControl.Location = new System.Drawing.Point(0, 48);
            this.Problem_tabControl.Name = "Problem_tabControl";
            this.Problem_tabControl.SelectedIndex = 0;
            this.Problem_tabControl.Size = new System.Drawing.Size(661, 282);
            this.Problem_tabControl.TabIndex = 0;
            // 
            // Problem_Description
            // 
            this.Problem_Description.Location = new System.Drawing.Point(4, 28);
            this.Problem_Description.Name = "Problem_Description";
            this.Problem_Description.Padding = new System.Windows.Forms.Padding(3);
            this.Problem_Description.Size = new System.Drawing.Size(653, 250);
            this.Problem_Description.TabIndex = 0;
            this.Problem_Description.Text = "问题描述";
            this.Problem_Description.UseVisualStyleBackColor = true;
            // 
            // Problem_Description_HTML
            // 
            this.Problem_Description_HTML.Location = new System.Drawing.Point(4, 28);
            this.Problem_Description_HTML.Name = "Problem_Description_HTML";
            this.Problem_Description_HTML.Padding = new System.Windows.Forms.Padding(3);
            this.Problem_Description_HTML.Size = new System.Drawing.Size(653, 250);
            this.Problem_Description_HTML.TabIndex = 1;
            this.Problem_Description_HTML.Text = "问题描述HTML";
            this.Problem_Description_HTML.UseVisualStyleBackColor = true;
            // 
            // Standard_Answer
            // 
            this.Standard_Answer.Location = new System.Drawing.Point(4, 28);
            this.Standard_Answer.Name = "Standard_Answer";
            this.Standard_Answer.Padding = new System.Windows.Forms.Padding(3);
            this.Standard_Answer.Size = new System.Drawing.Size(653, 250);
            this.Standard_Answer.TabIndex = 2;
            this.Standard_Answer.Text = "标准答案";
            this.Standard_Answer.UseVisualStyleBackColor = true;
            // 
            // Standard_Answer_Original_Output
            // 
            this.Standard_Answer_Original_Output.Location = new System.Drawing.Point(4, 28);
            this.Standard_Answer_Original_Output.Name = "Standard_Answer_Original_Output";
            this.Standard_Answer_Original_Output.Padding = new System.Windows.Forms.Padding(3);
            this.Standard_Answer_Original_Output.Size = new System.Drawing.Size(653, 250);
            this.Standard_Answer_Original_Output.TabIndex = 3;
            this.Standard_Answer_Original_Output.Text = "标准答案原始输出";
            this.Standard_Answer_Original_Output.UseVisualStyleBackColor = true;
            // 
            // Standard_Answer_Output_Browse
            // 
            this.Standard_Answer_Output_Browse.Location = new System.Drawing.Point(4, 28);
            this.Standard_Answer_Output_Browse.Name = "Standard_Answer_Output_Browse";
            this.Standard_Answer_Output_Browse.Padding = new System.Windows.Forms.Padding(3);
            this.Standard_Answer_Output_Browse.Size = new System.Drawing.Size(653, 250);
            this.Standard_Answer_Output_Browse.TabIndex = 4;
            this.Standard_Answer_Output_Browse.Text = "标准答案输出浏览";
            this.Standard_Answer_Output_Browse.UseVisualStyleBackColor = true;
            // 
            // Answer_tabControl
            // 
            this.Answer_tabControl.Controls.Add(this.Answer_Code);
            this.Answer_tabControl.Controls.Add(this.Original_Output);
            this.Answer_tabControl.Controls.Add(this.Browse_Output);
            this.Answer_tabControl.Controls.Add(this.Note);
            this.Answer_tabControl.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.Answer_tabControl.Location = new System.Drawing.Point(0, 0);
            this.Answer_tabControl.Name = "Answer_tabControl";
            this.Answer_tabControl.SelectedIndex = 0;
            this.Answer_tabControl.Size = new System.Drawing.Size(661, 214);
            this.Answer_tabControl.TabIndex = 0;
            // 
            // Answer_Code
            // 
            this.Answer_Code.Location = new System.Drawing.Point(4, 28);
            this.Answer_Code.Name = "Answer_Code";
            this.Answer_Code.Padding = new System.Windows.Forms.Padding(3);
            this.Answer_Code.Size = new System.Drawing.Size(653, 182);
            this.Answer_Code.TabIndex = 0;
            this.Answer_Code.Text = "解答代码";
            this.Answer_Code.UseVisualStyleBackColor = true;
            // 
            // Original_Output
            // 
            this.Original_Output.Location = new System.Drawing.Point(4, 28);
            this.Original_Output.Name = "Original_Output";
            this.Original_Output.Padding = new System.Windows.Forms.Padding(3);
            this.Original_Output.Size = new System.Drawing.Size(657, 182);
            this.Original_Output.TabIndex = 1;
            this.Original_Output.Text = "原始输出";
            this.Original_Output.UseVisualStyleBackColor = true;
            // 
            // Browse_Output
            // 
            this.Browse_Output.Location = new System.Drawing.Point(4, 28);
            this.Browse_Output.Name = "Browse_Output";
            this.Browse_Output.Padding = new System.Windows.Forms.Padding(3);
            this.Browse_Output.Size = new System.Drawing.Size(657, 182);
            this.Browse_Output.TabIndex = 2;
            this.Browse_Output.Text = "浏览输出";
            this.Browse_Output.UseVisualStyleBackColor = true;
            // 
            // Note
            // 
            this.Note.Location = new System.Drawing.Point(4, 28);
            this.Note.Name = "Note";
            this.Note.Padding = new System.Windows.Forms.Padding(3);
            this.Note.Size = new System.Drawing.Size(657, 182);
            this.Note.TabIndex = 3;
            this.Note.Text = "笔记";
            this.Note.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(219, 12);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(105, 30);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_See_Answer
            // 
            this.btn_See_Answer.Location = new System.Drawing.Point(330, 12);
            this.btn_See_Answer.Name = "btn_See_Answer";
            this.btn_See_Answer.Size = new System.Drawing.Size(105, 30);
            this.btn_See_Answer.TabIndex = 2;
            this.btn_See_Answer.Text = "查看标准答案";
            this.btn_See_Answer.UseVisualStyleBackColor = true;
            // 
            // btn_Run_Answer
            // 
            this.btn_Run_Answer.Location = new System.Drawing.Point(441, 11);
            this.btn_Run_Answer.Name = "btn_Run_Answer";
            this.btn_Run_Answer.Size = new System.Drawing.Size(105, 30);
            this.btn_Run_Answer.TabIndex = 3;
            this.btn_Run_Answer.Text = "运行标准答案";
            this.btn_Run_Answer.UseVisualStyleBackColor = true;
            // 
            // btn_Run_Code
            // 
            this.btn_Run_Code.Location = new System.Drawing.Point(552, 11);
            this.btn_Run_Code.Name = "btn_Run_Code";
            this.btn_Run_Code.Size = new System.Drawing.Size(105, 30);
            this.btn_Run_Code.TabIndex = 4;
            this.btn_Run_Code.Text = "运行解答代码";
            this.btn_Run_Code.UseVisualStyleBackColor = true;
            // 
            // label_Exercise_title
            // 
            this.label_Exercise_title.AutoSize = true;
            this.label_Exercise_title.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.label_Exercise_title.Location = new System.Drawing.Point(14, 17);
            this.label_Exercise_title.Name = "label_Exercise_title";
            this.label_Exercise_title.Size = new System.Drawing.Size(51, 19);
            this.label_Exercise_title.TabIndex = 5;
            this.label_Exercise_title.Text = "练习：";
            // 
            // label_Exercise_Name
            // 
            this.label_Exercise_Name.AutoSize = true;
            this.label_Exercise_Name.Location = new System.Drawing.Point(62, 16);
            this.label_Exercise_Name.Name = "label_Exercise_Name";
            this.label_Exercise_Name.Size = new System.Drawing.Size(128, 20);
            this.label_Exercise_Name.TabIndex = 6;
            this.label_Exercise_Name.Text = "Name_of_Exercise";
            // 
            // Student_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel_Answer);
            this.Controls.Add(this.panel_Problem);
            this.Controls.Add(this.TreeViewPanel);
            this.Name = "Student_Interface";
            this.Text = "PHP编程开放实验工具-学生端";
            this.TreeViewPanel.ResumeLayout(false);
            this.panel_Problem.ResumeLayout(false);
            this.panel_Problem.PerformLayout();
            this.panel_Answer.ResumeLayout(false);
            this.Problem_tabControl.ResumeLayout(false);
            this.Answer_tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TreeViewPanel;
        private System.Windows.Forms.TreeView Main_TreeView;
        private System.Windows.Forms.Panel panel_Problem;
        private System.Windows.Forms.TabControl Problem_tabControl;
        private System.Windows.Forms.TabPage Problem_Description;
        private System.Windows.Forms.TabPage Problem_Description_HTML;
        private System.Windows.Forms.TabPage Standard_Answer;
        private System.Windows.Forms.TabPage Standard_Answer_Original_Output;
        private System.Windows.Forms.Panel panel_Answer;
        private System.Windows.Forms.Label label_Exercise_Name;
        private System.Windows.Forms.Label label_Exercise_title;
        private System.Windows.Forms.Button btn_Run_Code;
        private System.Windows.Forms.Button btn_Run_Answer;
        private System.Windows.Forms.Button btn_See_Answer;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TabPage Standard_Answer_Output_Browse;
        private System.Windows.Forms.TabControl Answer_tabControl;
        private System.Windows.Forms.TabPage Answer_Code;
        private System.Windows.Forms.TabPage Original_Output;
        private System.Windows.Forms.TabPage Browse_Output;
        private System.Windows.Forms.TabPage Note;
    }
}