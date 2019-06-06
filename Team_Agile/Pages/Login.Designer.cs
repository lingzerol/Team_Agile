namespace Team_Agile.Pages
{
    partial class Login
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
            this.Login_Title = new System.Windows.Forms.Label();
            this.Login_groupBox = new System.Windows.Forms.GroupBox();
            this.Login_ChooseLabel = new System.Windows.Forms.Label();
            this.Login_Stubutton = new System.Windows.Forms.Button();
            this.Login_TchButton = new System.Windows.Forms.Button();
            this.Login_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_Title
            // 
            this.Login_Title.AutoSize = true;
            this.Login_Title.Font = new System.Drawing.Font("微软雅黑", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login_Title.Location = new System.Drawing.Point(424, 167);
            this.Login_Title.Name = "Login_Title";
            this.Login_Title.Size = new System.Drawing.Size(465, 57);
            this.Login_Title.TabIndex = 7;
            this.Login_Title.Text = "PHP编程开放实验工具";
            // 
            // Login_groupBox
            // 
            this.Login_groupBox.Controls.Add(this.Login_ChooseLabel);
            this.Login_groupBox.Controls.Add(this.Login_Stubutton);
            this.Login_groupBox.Controls.Add(this.Login_TchButton);
            this.Login_groupBox.Location = new System.Drawing.Point(416, 300);
            this.Login_groupBox.Name = "Login_groupBox";
            this.Login_groupBox.Size = new System.Drawing.Size(484, 226);
            this.Login_groupBox.TabIndex = 8;
            this.Login_groupBox.TabStop = false;
            // 
            // Login_ChooseLabel
            // 
            this.Login_ChooseLabel.AutoSize = true;
            this.Login_ChooseLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login_ChooseLabel.Location = new System.Drawing.Point(187, 0);
            this.Login_ChooseLabel.Name = "Login_ChooseLabel";
            this.Login_ChooseLabel.Size = new System.Drawing.Size(110, 24);
            this.Login_ChooseLabel.TabIndex = 3;
            this.Login_ChooseLabel.Text = "选择身份";
            // 
            // Login_Stubutton
            // 
            this.Login_Stubutton.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login_Stubutton.Location = new System.Drawing.Point(86, 145);
            this.Login_Stubutton.Name = "Login_Stubutton";
            this.Login_Stubutton.Size = new System.Drawing.Size(310, 50);
            this.Login_Stubutton.TabIndex = 2;
            this.Login_Stubutton.Text = "学生";
            this.Login_Stubutton.UseVisualStyleBackColor = true;
            this.Login_Stubutton.Click += new System.EventHandler(this.Login_Stubutton_Click);
            // 
            // Login_TchButton
            // 
            this.Login_TchButton.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login_TchButton.Location = new System.Drawing.Point(86, 57);
            this.Login_TchButton.Name = "Login_TchButton";
            this.Login_TchButton.Size = new System.Drawing.Size(310, 50);
            this.Login_TchButton.TabIndex = 1;
            this.Login_TchButton.Text = "教师";
            this.Login_TchButton.UseVisualStyleBackColor = true;
            this.Login_TchButton.Click += new System.EventHandler(this.Login_TchButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 743);
            this.Controls.Add(this.Login_Title);
            this.Controls.Add(this.Login_groupBox);
            this.Name = "Login";
            this.Text = "Login";
            this.Login_groupBox.ResumeLayout(false);
            this.Login_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login_Title;
        private System.Windows.Forms.GroupBox Login_groupBox;
        private System.Windows.Forms.Label Login_ChooseLabel;
        private System.Windows.Forms.Button Login_Stubutton;
        private System.Windows.Forms.Button Login_TchButton;
    }
}