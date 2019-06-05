using System.Windows.Forms;

namespace Team_Agile.Pages
{
    partial class Questionbank
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
            this.show_question = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.export_status = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // show_question
            // 
            this.show_question.CheckBoxes = true;
            this.show_question.FullRowSelect = true;
            this.show_question.Location = new System.Drawing.Point(12, 67);
            this.show_question.Name = "show_question";
            this.show_question.Size = new System.Drawing.Size(1155, 580);
            this.show_question.TabIndex = 0;
            this.show_question.UseCompatibleStateImageBehavior = false;
            this.show_question.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.show_question_ItemCheck);
            this.show_question.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.show_question_ItemSelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(502, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHP题集";
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(683, 29);
            this.test.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(89, 25);
            this.test.TabIndex = 2;
            this.test.TextChanged += new System.EventHandler(this.test_TextChanged);
            // 
            // confirm
            // 
            this.confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.confirm.Location = new System.Drawing.Point(795, 29);
            this.confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(78, 25);
            this.confirm.TabIndex = 3;
            this.confirm.Text = "确定";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(900, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // export_status
            // 
            this.export_status.Location = new System.Drawing.Point(1006, 29);
            this.export_status.Name = "export_status";
            this.export_status.Size = new System.Drawing.Size(133, 23);
            this.export_status.TabIndex = 6;
            this.export_status.Text = "导出题目状态";
            this.export_status.UseVisualStyleBackColor = true;
            this.export_status.Click += new System.EventHandler(this.export_status_Click);
            // 
            // Questionbank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 702);
            this.Controls.Add(this.export_status);
            this.Controls.Add(this.show_question);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.test);
            this.Controls.Add(this.label1);
            this.Name = "Questionbank";
            this.Text = "Questionbank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView show_question;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox test;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Button export_status;

        public ListView Show_question { get => show_question; set => show_question = value; }
    }
}