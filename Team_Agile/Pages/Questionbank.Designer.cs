﻿namespace Team_Agile.Pages
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
            this.SuspendLayout();
            // 
            // show_question
            // 
            this.show_question.Location = new System.Drawing.Point(12, 67);
            this.show_question.Name = "show_question";
            this.show_question.Size = new System.Drawing.Size(1155, 580);
            this.show_question.TabIndex = 0;
            this.show_question.UseCompatibleStateImageBehavior = false;
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
            this.test.TextChanged += new System.EventHandler(this.Test_TextChanged);
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
            // Questionbank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 702);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.test);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.show_question);
            this.Name = "Questionbank";
            this.Text = "Questionbank";
            this.Load += new System.EventHandler(this.Questionbank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView show_question;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox test;
        private System.Windows.Forms.Button confirm;
    }
}