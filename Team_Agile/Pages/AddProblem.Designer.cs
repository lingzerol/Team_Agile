namespace Team_Agile.Pages
{
    partial class AddProblem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.ProblemNameInput = new System.Windows.Forms.TextBox();
            this.TimeLimitInput = new System.Windows.Forms.TextBox();
            this.MemoryLimitInput = new System.Windows.Forms.TextBox();
            this.DescriptionInput = new System.Windows.Forms.TextBox();
            this.InputDescriptionInput = new System.Windows.Forms.TextBox();
            this.OutputDescriptionInput = new System.Windows.Forms.TextBox();
            this.hintInput = new System.Windows.Forms.TextBox();
            this.InputSampleInput = new System.Windows.Forms.TextBox();
            this.OutputSampleInput = new System.Windows.Forms.TextBox();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(198, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "时间限制：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(660, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "内存限制：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(164, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "题目描述";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(163, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "输入描述";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(164, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "输出描述";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(164, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "输入样例";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(164, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "输出样例";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(164, 397);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 27);
            this.label9.TabIndex = 8;
            this.label9.Text = "提示";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.AddButton.Location = new System.Drawing.Point(590, 593);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(96, 44);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "添加";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ProblemNameInput
            // 
            this.ProblemNameInput.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold);
            this.ProblemNameInput.Location = new System.Drawing.Point(426, 34);
            this.ProblemNameInput.Name = "ProblemNameInput";
            this.ProblemNameInput.Size = new System.Drawing.Size(309, 53);
            this.ProblemNameInput.TabIndex = 10;
            // 
            // TimeLimitInput
            // 
            this.TimeLimitInput.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.TimeLimitInput.Location = new System.Drawing.Point(302, 105);
            this.TimeLimitInput.Name = "TimeLimitInput";
            this.TimeLimitInput.Size = new System.Drawing.Size(309, 29);
            this.TimeLimitInput.TabIndex = 11;
            // 
            // MemoryLimitInput
            // 
            this.MemoryLimitInput.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.MemoryLimitInput.Location = new System.Drawing.Point(764, 107);
            this.MemoryLimitInput.Name = "MemoryLimitInput";
            this.MemoryLimitInput.Size = new System.Drawing.Size(309, 29);
            this.MemoryLimitInput.TabIndex = 12;
            // 
            // DescriptionInput
            // 
            this.DescriptionInput.BackColor = System.Drawing.Color.AliceBlue;
            this.DescriptionInput.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.DescriptionInput.Location = new System.Drawing.Point(169, 489);
            this.DescriptionInput.Multiline = true;
            this.DescriptionInput.Name = "DescriptionInput";
            this.DescriptionInput.Size = new System.Drawing.Size(904, 72);
            this.DescriptionInput.TabIndex = 13;
            // 
            // InputDescriptionInput
            // 
            this.InputDescriptionInput.BackColor = System.Drawing.Color.AliceBlue;
            this.InputDescriptionInput.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.InputDescriptionInput.Location = new System.Drawing.Point(168, 175);
            this.InputDescriptionInput.Name = "InputDescriptionInput";
            this.InputDescriptionInput.Size = new System.Drawing.Size(905, 29);
            this.InputDescriptionInput.TabIndex = 14;
            // 
            // OutputDescriptionInput
            // 
            this.OutputDescriptionInput.BackColor = System.Drawing.Color.AliceBlue;
            this.OutputDescriptionInput.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.OutputDescriptionInput.Location = new System.Drawing.Point(169, 237);
            this.OutputDescriptionInput.Name = "OutputDescriptionInput";
            this.OutputDescriptionInput.Size = new System.Drawing.Size(904, 29);
            this.OutputDescriptionInput.TabIndex = 15;
            // 
            // hintInput
            // 
            this.hintInput.BackColor = System.Drawing.Color.AliceBlue;
            this.hintInput.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.hintInput.Location = new System.Drawing.Point(169, 427);
            this.hintInput.Name = "hintInput";
            this.hintInput.Size = new System.Drawing.Size(904, 29);
            this.hintInput.TabIndex = 16;
            // 
            // InputSampleInput
            // 
            this.InputSampleInput.BackColor = System.Drawing.Color.AliceBlue;
            this.InputSampleInput.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.InputSampleInput.Location = new System.Drawing.Point(169, 300);
            this.InputSampleInput.Name = "InputSampleInput";
            this.InputSampleInput.Size = new System.Drawing.Size(904, 29);
            this.InputSampleInput.TabIndex = 17;
            // 
            // OutputSampleInput
            // 
            this.OutputSampleInput.BackColor = System.Drawing.Color.AliceBlue;
            this.OutputSampleInput.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.OutputSampleInput.Location = new System.Drawing.Point(169, 365);
            this.OutputSampleInput.Name = "OutputSampleInput";
            this.OutputSampleInput.Size = new System.Drawing.Size(904, 29);
            this.OutputSampleInput.TabIndex = 18;
            // 
            // GoBackButton
            // 
            this.GoBackButton.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.GoBackButton.Location = new System.Drawing.Point(25, 23);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(75, 40);
            this.GoBackButton.TabIndex = 19;
            this.GoBackButton.Text = "返回";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(262, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "(多个样例以\";\"隔开";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(262, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "(多个样例以\";\"隔开";
            // 
            // AddProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 702);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.OutputSampleInput);
            this.Controls.Add(this.InputSampleInput);
            this.Controls.Add(this.hintInput);
            this.Controls.Add(this.OutputDescriptionInput);
            this.Controls.Add(this.InputDescriptionInput);
            this.Controls.Add(this.DescriptionInput);
            this.Controls.Add(this.MemoryLimitInput);
            this.Controls.Add(this.TimeLimitInput);
            this.Controls.Add(this.ProblemNameInput);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "AddProblem";
            this.Text = "AddProblem";
            this.Load += new System.EventHandler(this.AddProblem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox ProblemNameInput;
        private System.Windows.Forms.TextBox TimeLimitInput;
        private System.Windows.Forms.TextBox MemoryLimitInput;
        private System.Windows.Forms.TextBox DescriptionInput;
        private System.Windows.Forms.TextBox InputDescriptionInput;
        private System.Windows.Forms.TextBox OutputDescriptionInput;
        private System.Windows.Forms.TextBox hintInput;
        private System.Windows.Forms.TextBox InputSampleInput;
        private System.Windows.Forms.TextBox OutputSampleInput;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}