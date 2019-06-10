using Lib;

namespace Team_Agile.Pages
{
    partial class Teacher_Interface
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher_Interface));
            this.TreeViewPanel = new System.Windows.Forms.Panel();
            this.Problem_Edit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ProAddBtn = new System.Windows.Forms.Button();
            this.ProDelBtn = new System.Windows.Forms.Button();
            this.Main_TreeView = new System.Windows.Forms.TreeView();
            this.panel_Problem = new System.Windows.Forms.Panel();
            this.Problem_Add = new System.Windows.Forms.Button();
            this.label_Exercise_Name = new System.Windows.Forms.Label();
            this.label_Exercise_title = new System.Windows.Forms.Label();
            this.btn_Run_Code = new System.Windows.Forms.Button();
            this.btn_Run_Answer = new System.Windows.Forms.Button();
            this.btn_See_Answer = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.Problem_tabControl = new System.Windows.Forms.TabControl();
            this.Problem_Description = new System.Windows.Forms.TabPage();
            this.ProblemWebBrowser = new System.Windows.Forms.WebBrowser();
            this.ProblemDec = new System.Windows.Forms.RichTextBox();
            this.Problem_Description_HTML = new System.Windows.Forms.TabPage();
            this.ProDescTextBox = new System.Windows.Forms.RichTextBox();
            this.Standard_Answer = new System.Windows.Forms.TabPage();
            this.StdAnswerTextBox = new System.Windows.Forms.RichTextBox();
            this.Standard_Answer_Output_Browse = new System.Windows.Forms.TabPage();
            this.InputSample = new System.Windows.Forms.TabPage();
            this.InputSampleText = new System.Windows.Forms.RichTextBox();
            this.OutputSample = new System.Windows.Forms.TabPage();
            this.OutputsampleText = new System.Windows.Forms.RichTextBox();
            this.panel_Answer = new System.Windows.Forms.Panel();
            this.Answer_tabControl = new System.Windows.Forms.TabControl();
            this.Answer_Code = new System.Windows.Forms.TabPage();
            this.CodeTextBox = new System.Windows.Forms.RichTextBox();
            this.Browse_Output = new System.Windows.Forms.TabPage();
            this.Note = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.StdAnswerOutputrichTextBox = new System.Windows.Forms.RichTextBox();
            this.Browser_output = new System.Windows.Forms.RichTextBox();
            this.TreeViewPanel.SuspendLayout();
            this.panel_Problem.SuspendLayout();
            this.Problem_tabControl.SuspendLayout();
            this.Problem_Description.SuspendLayout();
            this.Problem_Description_HTML.SuspendLayout();
            this.Standard_Answer.SuspendLayout();
            this.Standard_Answer_Output_Browse.SuspendLayout();
            this.InputSample.SuspendLayout();
            this.OutputSample.SuspendLayout();
            this.panel_Answer.SuspendLayout();
            this.Answer_tabControl.SuspendLayout();
            this.Answer_Code.SuspendLayout();
            this.Browse_Output.SuspendLayout();
            this.SuspendLayout();
            // 
            // TreeViewPanel
            // 
            this.TreeViewPanel.Controls.Add(this.Problem_Edit);
            this.TreeViewPanel.Controls.Add(this.button1);
            this.TreeViewPanel.Controls.Add(this.ProAddBtn);
            this.TreeViewPanel.Controls.Add(this.ProDelBtn);
            this.TreeViewPanel.Controls.Add(this.Main_TreeView);
            this.TreeViewPanel.Location = new System.Drawing.Point(7, 6);
            this.TreeViewPanel.Margin = new System.Windows.Forms.Padding(4);
            this.TreeViewPanel.Name = "TreeViewPanel";
            this.TreeViewPanel.Size = new System.Drawing.Size(267, 688);
            this.TreeViewPanel.TabIndex = 0;
            // 
            // Problem_Edit
            // 
            this.Problem_Edit.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.Problem_Edit.Location = new System.Drawing.Point(45, 456);
            this.Problem_Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Problem_Edit.Name = "Problem_Edit";
            this.Problem_Edit.Size = new System.Drawing.Size(173, 42);
            this.Problem_Edit.TabIndex = 4;
            this.Problem_Edit.Text = "编辑";
            this.Problem_Edit.UseVisualStyleBackColor = true;
            this.Problem_Edit.Click += new System.EventHandler(this.Problem_Edit_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.button1.Location = new System.Drawing.Point(45, 520);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "导出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ProExportBtn_Click);
            // 
            // ProAddBtn
            // 
            this.ProAddBtn.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.ProAddBtn.Location = new System.Drawing.Point(45, 575);
            this.ProAddBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ProAddBtn.Name = "ProAddBtn";
            this.ProAddBtn.Size = new System.Drawing.Size(173, 38);
            this.ProAddBtn.TabIndex = 0;
            this.ProAddBtn.Text = "导入";
            this.ProAddBtn.UseVisualStyleBackColor = true;
            this.ProAddBtn.Click += new System.EventHandler(this.ProAddBtn_Click);
            // 
            // ProDelBtn
            // 
            this.ProDelBtn.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.ProDelBtn.Location = new System.Drawing.Point(45, 630);
            this.ProDelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ProDelBtn.Name = "ProDelBtn";
            this.ProDelBtn.Size = new System.Drawing.Size(173, 38);
            this.ProDelBtn.TabIndex = 2;
            this.ProDelBtn.Text = "删除";
            this.ProDelBtn.UseVisualStyleBackColor = true;
            this.ProDelBtn.Click += new System.EventHandler(this.ProDelBtn_Click);
            // 
            // Main_TreeView
            // 
            this.Main_TreeView.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.Main_TreeView.Location = new System.Drawing.Point(0, 0);
            this.Main_TreeView.Margin = new System.Windows.Forms.Padding(4);
            this.Main_TreeView.Name = "Main_TreeView";
            this.Main_TreeView.Size = new System.Drawing.Size(265, 686);
            this.Main_TreeView.TabIndex = 1;
            this.Main_TreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Main_TreeView_AfterSelect);
            // 
            // panel_Problem
            // 
            this.panel_Problem.AutoScroll = true;
            this.panel_Problem.Controls.Add(this.Problem_Add);
            this.panel_Problem.Controls.Add(this.label_Exercise_Name);
            this.panel_Problem.Controls.Add(this.label_Exercise_title);
            this.panel_Problem.Controls.Add(this.btn_Run_Code);
            this.panel_Problem.Controls.Add(this.btn_Run_Answer);
            this.panel_Problem.Controls.Add(this.btn_See_Answer);
            this.panel_Problem.Controls.Add(this.btn_Save);
            this.panel_Problem.Controls.Add(this.Problem_tabControl);
            this.panel_Problem.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.panel_Problem.Location = new System.Drawing.Point(281, 6);
            this.panel_Problem.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Problem.Name = "panel_Problem";
            this.panel_Problem.Size = new System.Drawing.Size(901, 412);
            this.panel_Problem.TabIndex = 1;
            // 
            // Problem_Add
            // 
            this.Problem_Add.Location = new System.Drawing.Point(239, 10);
            this.Problem_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Problem_Add.Name = "Problem_Add";
            this.Problem_Add.Size = new System.Drawing.Size(88, 39);
            this.Problem_Add.TabIndex = 7;
            this.Problem_Add.Text = "添加";
            this.Problem_Add.UseVisualStyleBackColor = true;
            this.Problem_Add.Click += new System.EventHandler(this.Problem_Add_Click);
            // 
            // label_Exercise_Name
            // 
            this.label_Exercise_Name.AutoSize = true;
            this.label_Exercise_Name.Location = new System.Drawing.Point(49, 22);
            this.label_Exercise_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Exercise_Name.Name = "label_Exercise_Name";
            this.label_Exercise_Name.Size = new System.Drawing.Size(143, 23);
            this.label_Exercise_Name.TabIndex = 6;
            this.label_Exercise_Name.Text = "PHP/MySQL简介";
            // 
            // label_Exercise_title
            // 
            this.label_Exercise_title.AutoSize = true;
            this.label_Exercise_title.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.label_Exercise_title.Location = new System.Drawing.Point(4, 20);
            this.label_Exercise_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Exercise_title.Name = "label_Exercise_title";
            this.label_Exercise_title.Size = new System.Drawing.Size(61, 24);
            this.label_Exercise_title.TabIndex = 5;
            this.label_Exercise_title.Text = "练习：";
            // 
            // btn_Run_Code
            // 
            this.btn_Run_Code.Location = new System.Drawing.Point(737, 11);
            this.btn_Run_Code.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Run_Code.Name = "btn_Run_Code";
            this.btn_Run_Code.Size = new System.Drawing.Size(144, 38);
            this.btn_Run_Code.TabIndex = 4;
            this.btn_Run_Code.Text = "运行解答代码";
            this.btn_Run_Code.UseVisualStyleBackColor = true;
            this.btn_Run_Code.Click += new System.EventHandler(this.btn_Run_Code_Click);
            // 
            // btn_Run_Answer
            // 
            this.btn_Run_Answer.Location = new System.Drawing.Point(587, 12);
            this.btn_Run_Answer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Run_Answer.Name = "btn_Run_Answer";
            this.btn_Run_Answer.Size = new System.Drawing.Size(143, 38);
            this.btn_Run_Answer.TabIndex = 3;
            this.btn_Run_Answer.Text = "运行标准答案";
            this.btn_Run_Answer.UseVisualStyleBackColor = true;
            this.btn_Run_Answer.Click += new System.EventHandler(this.btn_Run_Answer_Click);
            // 
            // btn_See_Answer
            // 
            this.btn_See_Answer.Location = new System.Drawing.Point(443, 11);
            this.btn_See_Answer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_See_Answer.Name = "btn_See_Answer";
            this.btn_See_Answer.Size = new System.Drawing.Size(135, 38);
            this.btn_See_Answer.TabIndex = 2;
            this.btn_See_Answer.Text = "查看标准答案";
            this.btn_See_Answer.UseVisualStyleBackColor = true;
            this.btn_See_Answer.Click += new System.EventHandler(this.btn_See_Answer_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(351, 11);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(84, 38);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Problem_tabControl
            // 
            this.Problem_tabControl.Controls.Add(this.Problem_Description);
            this.Problem_tabControl.Controls.Add(this.Problem_Description_HTML);
            this.Problem_tabControl.Controls.Add(this.Standard_Answer);
            this.Problem_tabControl.Controls.Add(this.Standard_Answer_Output_Browse);
            this.Problem_tabControl.Controls.Add(this.InputSample);
            this.Problem_tabControl.Controls.Add(this.OutputSample);
            this.Problem_tabControl.Location = new System.Drawing.Point(0, 60);
            this.Problem_tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.Problem_tabControl.Name = "Problem_tabControl";
            this.Problem_tabControl.SelectedIndex = 0;
            this.Problem_tabControl.Size = new System.Drawing.Size(881, 352);
            this.Problem_tabControl.TabIndex = 0;
            this.Problem_tabControl.SelectedIndexChanged += new System.EventHandler(this.Problem_tabControl_SelectedIndexChanged);
            // 
            // Problem_Description
            // 
            this.Problem_Description.Controls.Add(this.ProblemWebBrowser);
            this.Problem_Description.Controls.Add(this.ProblemDec);
            this.Problem_Description.Location = new System.Drawing.Point(4, 32);
            this.Problem_Description.Margin = new System.Windows.Forms.Padding(4);
            this.Problem_Description.Name = "Problem_Description";
            this.Problem_Description.Padding = new System.Windows.Forms.Padding(4);
            this.Problem_Description.Size = new System.Drawing.Size(873, 316);
            this.Problem_Description.TabIndex = 0;
            this.Problem_Description.Text = "问题描述";
            this.Problem_Description.UseVisualStyleBackColor = true;
            this.Problem_Description.Click += new System.EventHandler(this.Problem_Description_Click);
            // 
            // ProblemWebBrowser
            // 
            this.ProblemWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProblemWebBrowser.Location = new System.Drawing.Point(4, 4);
            this.ProblemWebBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.ProblemWebBrowser.MinimumSize = new System.Drawing.Size(27, 25);
            this.ProblemWebBrowser.Name = "ProblemWebBrowser";
            this.ProblemWebBrowser.Size = new System.Drawing.Size(865, 308);
            this.ProblemWebBrowser.TabIndex = 1;
            this.ProblemWebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.ProblemWebBrowser_DocumentCompleted);
            // 
            // ProblemDec
            // 
            this.ProblemDec.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProblemDec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProblemDec.Location = new System.Drawing.Point(0, 0);
            this.ProblemDec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProblemDec.Name = "ProblemDec";
            this.ProblemDec.ReadOnly = true;
            this.ProblemDec.Size = new System.Drawing.Size(873, 312);
            this.ProblemDec.TabIndex = 0;
            this.ProblemDec.Text = "";
            // 
            // Problem_Description_HTML
            // 
            this.Problem_Description_HTML.Controls.Add(this.ProDescTextBox);
            this.Problem_Description_HTML.Location = new System.Drawing.Point(4, 32);
            this.Problem_Description_HTML.Margin = new System.Windows.Forms.Padding(4);
            this.Problem_Description_HTML.Name = "Problem_Description_HTML";
            this.Problem_Description_HTML.Padding = new System.Windows.Forms.Padding(4);
            this.Problem_Description_HTML.Size = new System.Drawing.Size(873, 316);
            this.Problem_Description_HTML.TabIndex = 1;
            this.Problem_Description_HTML.Text = "问题描述HTML";
            this.Problem_Description_HTML.UseVisualStyleBackColor = true;
            // 
            // ProDescTextBox
            // 
            this.ProDescTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProDescTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProDescTextBox.Location = new System.Drawing.Point(4, 4);
            this.ProDescTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProDescTextBox.Name = "ProDescTextBox";
            this.ProDescTextBox.Size = new System.Drawing.Size(865, 308);
            this.ProDescTextBox.TabIndex = 0;
            this.ProDescTextBox.Text = "";
            // 
            // Standard_Answer
            // 
            this.Standard_Answer.Controls.Add(this.StdAnswerTextBox);
            this.Standard_Answer.Location = new System.Drawing.Point(4, 32);
            this.Standard_Answer.Margin = new System.Windows.Forms.Padding(4);
            this.Standard_Answer.Name = "Standard_Answer";
            this.Standard_Answer.Padding = new System.Windows.Forms.Padding(4);
            this.Standard_Answer.Size = new System.Drawing.Size(873, 316);
            this.Standard_Answer.TabIndex = 2;
            this.Standard_Answer.Text = "标准答案";
            this.Standard_Answer.UseVisualStyleBackColor = true;
            // 
            // StdAnswerTextBox
            // 
            this.StdAnswerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StdAnswerTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StdAnswerTextBox.Location = new System.Drawing.Point(4, 4);
            this.StdAnswerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.StdAnswerTextBox.Name = "StdAnswerTextBox";
            this.StdAnswerTextBox.Size = new System.Drawing.Size(865, 308);
            this.StdAnswerTextBox.TabIndex = 0;
            this.StdAnswerTextBox.Text = "";
            // 
            // Standard_Answer_Output_Browse
            // 
            this.Standard_Answer_Output_Browse.Controls.Add(this.StdAnswerOutputrichTextBox);
            this.Standard_Answer_Output_Browse.Location = new System.Drawing.Point(4, 32);
            this.Standard_Answer_Output_Browse.Margin = new System.Windows.Forms.Padding(4);
            this.Standard_Answer_Output_Browse.Name = "Standard_Answer_Output_Browse";
            this.Standard_Answer_Output_Browse.Padding = new System.Windows.Forms.Padding(4);
            this.Standard_Answer_Output_Browse.Size = new System.Drawing.Size(873, 316);
            this.Standard_Answer_Output_Browse.TabIndex = 4;
            this.Standard_Answer_Output_Browse.Text = "标准答案输出浏览";
            this.Standard_Answer_Output_Browse.UseVisualStyleBackColor = true;
            // 
            // InputSample
            // 
            this.InputSample.Controls.Add(this.InputSampleText);
            this.InputSample.Location = new System.Drawing.Point(4, 32);
            this.InputSample.Name = "InputSample";
            this.InputSample.Padding = new System.Windows.Forms.Padding(3);
            this.InputSample.Size = new System.Drawing.Size(873, 316);
            this.InputSample.TabIndex = 5;
            this.InputSample.Text = "输入样例";
            this.InputSample.UseVisualStyleBackColor = true;
            // 
            // InputSampleText
            // 
            this.InputSampleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputSampleText.Location = new System.Drawing.Point(0, 0);
            this.InputSampleText.Name = "InputSampleText";
            this.InputSampleText.Size = new System.Drawing.Size(877, 317);
            this.InputSampleText.TabIndex = 0;
            this.InputSampleText.Text = "";
            // 
            // OutputSample
            // 
            this.OutputSample.Controls.Add(this.OutputsampleText);
            this.OutputSample.Location = new System.Drawing.Point(4, 32);
            this.OutputSample.Name = "OutputSample";
            this.OutputSample.Padding = new System.Windows.Forms.Padding(3);
            this.OutputSample.Size = new System.Drawing.Size(873, 316);
            this.OutputSample.TabIndex = 6;
            this.OutputSample.Text = "输出样例";
            this.OutputSample.UseVisualStyleBackColor = true;
            // 
            // OutputsampleText
            // 
            this.OutputsampleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputsampleText.Location = new System.Drawing.Point(0, 0);
            this.OutputsampleText.Name = "OutputsampleText";
            this.OutputsampleText.Size = new System.Drawing.Size(877, 316);
            this.OutputsampleText.TabIndex = 0;
            this.OutputsampleText.Text = "";
            // 
            // panel_Answer
            // 
            this.panel_Answer.AutoScroll = true;
            this.panel_Answer.Controls.Add(this.Answer_tabControl);
            this.panel_Answer.Location = new System.Drawing.Point(281, 426);
            this.panel_Answer.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Answer.Name = "panel_Answer";
            this.panel_Answer.Size = new System.Drawing.Size(887, 268);
            this.panel_Answer.TabIndex = 2;
            // 
            // Answer_tabControl
            // 
            this.Answer_tabControl.Controls.Add(this.Answer_Code);
            this.Answer_tabControl.Controls.Add(this.Browse_Output);
            this.Answer_tabControl.Controls.Add(this.Note);
            this.Answer_tabControl.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.Answer_tabControl.Location = new System.Drawing.Point(0, 0);
            this.Answer_tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.Answer_tabControl.Name = "Answer_tabControl";
            this.Answer_tabControl.SelectedIndex = 0;
            this.Answer_tabControl.Size = new System.Drawing.Size(881, 268);
            this.Answer_tabControl.TabIndex = 0;
            // 
            // Answer_Code
            // 
            this.Answer_Code.Controls.Add(this.CodeTextBox);
            this.Answer_Code.Location = new System.Drawing.Point(4, 32);
            this.Answer_Code.Margin = new System.Windows.Forms.Padding(4);
            this.Answer_Code.Name = "Answer_Code";
            this.Answer_Code.Padding = new System.Windows.Forms.Padding(4);
            this.Answer_Code.Size = new System.Drawing.Size(873, 232);
            this.Answer_Code.TabIndex = 0;
            this.Answer_Code.Text = "解答代码";
            this.Answer_Code.UseVisualStyleBackColor = true;
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CodeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodeTextBox.Location = new System.Drawing.Point(4, 4);
            this.CodeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(865, 224);
            this.CodeTextBox.TabIndex = 0;
            this.CodeTextBox.Text = "";
            this.CodeTextBox.TextChanged += new System.EventHandler(this.CodeTextBox_TextChanged);
            // 
            // Browse_Output
            // 
            this.Browse_Output.Controls.Add(this.Browser_output);
            this.Browse_Output.Location = new System.Drawing.Point(4, 32);
            this.Browse_Output.Margin = new System.Windows.Forms.Padding(4);
            this.Browse_Output.Name = "Browse_Output";
            this.Browse_Output.Padding = new System.Windows.Forms.Padding(4);
            this.Browse_Output.Size = new System.Drawing.Size(873, 232);
            this.Browse_Output.TabIndex = 2;
            this.Browse_Output.Text = "浏览输出";
            this.Browse_Output.UseVisualStyleBackColor = true;
            // 
            // Note
            // 
            this.Note.Location = new System.Drawing.Point(4, 32);
            this.Note.Margin = new System.Windows.Forms.Padding(4);
            this.Note.Name = "Note";
            this.Note.Padding = new System.Windows.Forms.Padding(4);
            this.Note.Size = new System.Drawing.Size(873, 232);
            this.Note.TabIndex = 3;
            this.Note.Text = "笔记";
            this.Note.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "3.0-未完成.png");
            this.imageList1.Images.SetKeyName(1, "正确.png");
            this.imageList1.Images.SetKeyName(2, "错误.png");
            // 
            // StdAnswerOutputrichTextBox
            // 
            this.StdAnswerOutputrichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StdAnswerOutputrichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StdAnswerOutputrichTextBox.Location = new System.Drawing.Point(4, 4);
            this.StdAnswerOutputrichTextBox.Name = "StdAnswerOutputrichTextBox";
            this.StdAnswerOutputrichTextBox.Size = new System.Drawing.Size(865, 308);
            this.StdAnswerOutputrichTextBox.TabIndex = 0;
            this.StdAnswerOutputrichTextBox.Text = "";
            // 
            // Browser_output
            // 
            this.Browser_output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Browser_output.Location = new System.Drawing.Point(0, 0);
            this.Browser_output.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Browser_output.Name = "Browser_output";
            this.Browser_output.Size = new System.Drawing.Size(873, 232);
            this.Browser_output.TabIndex = 0;
            this.Browser_output.Text = "";
            // 
            // Teacher_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 701);
            this.Controls.Add(this.panel_Answer);
            this.Controls.Add(this.panel_Problem);
            this.Controls.Add(this.TreeViewPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Teacher_Interface";
            this.Text = "PHP编程开放实验工具-教师端";
            this.Load += new System.EventHandler(this.Teacher_Interface_Load);
            this.TreeViewPanel.ResumeLayout(false);
            this.panel_Problem.ResumeLayout(false);
            this.panel_Problem.PerformLayout();
            this.Problem_tabControl.ResumeLayout(false);
            this.Problem_Description.ResumeLayout(false);
            this.Problem_Description_HTML.ResumeLayout(false);
            this.Standard_Answer.ResumeLayout(false);
            this.Standard_Answer_Output_Browse.ResumeLayout(false);
            this.InputSample.ResumeLayout(false);
            this.OutputSample.ResumeLayout(false);
            this.panel_Answer.ResumeLayout(false);
            this.Answer_tabControl.ResumeLayout(false);
            this.Answer_Code.ResumeLayout(false);
            this.Browse_Output.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        SerializableDictionary<int, StructureOfProblem> problems = ProblemList.GetAll();
        private System.Windows.Forms.Panel TreeViewPanel;
        private System.Windows.Forms.TreeView Main_TreeView;
        private System.Windows.Forms.Panel panel_Problem;
        private System.Windows.Forms.Panel panel_Answer;
        private System.Windows.Forms.Label label_Exercise_Name;
        private System.Windows.Forms.Label label_Exercise_title;
        private System.Windows.Forms.Button btn_Run_Code;
        private System.Windows.Forms.Button btn_Run_Answer;
        private System.Windows.Forms.Button btn_See_Answer;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TabControl Answer_tabControl;
        private System.Windows.Forms.TabPage Answer_Code;
        private System.Windows.Forms.TabPage Browse_Output;
        private System.Windows.Forms.TabPage Note;
        private System.Windows.Forms.Button ProAddBtn;
        private System.Windows.Forms.Button ProDelBtn;
        private System.Windows.Forms.RichTextBox CodeTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Problem_Edit;
        private System.Windows.Forms.Button Problem_Add;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl Problem_tabControl;
        private System.Windows.Forms.TabPage Problem_Description;
        private System.Windows.Forms.WebBrowser ProblemWebBrowser;
        private System.Windows.Forms.RichTextBox ProblemDec;
        private System.Windows.Forms.TabPage Problem_Description_HTML;
        private System.Windows.Forms.RichTextBox ProDescTextBox;
        private System.Windows.Forms.TabPage Standard_Answer;
        private System.Windows.Forms.RichTextBox StdAnswerTextBox;
        private System.Windows.Forms.TabPage Standard_Answer_Output_Browse;
        private System.Windows.Forms.TabPage InputSample;
        private System.Windows.Forms.RichTextBox InputSampleText;
        private System.Windows.Forms.TabPage OutputSample;
        private System.Windows.Forms.RichTextBox OutputsampleText;
        private System.Windows.Forms.RichTextBox StdAnswerOutputrichTextBox;
        private System.Windows.Forms.RichTextBox Browser_output;
    }
}