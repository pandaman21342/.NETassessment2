﻿namespace Assessment_2
{
    partial class Teacher_menu
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
            button7 = new Button();
            button6 = new Button();
            button2 = new Button();
            button1 = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(45, 128, 185);
            button7.FlatAppearance.BorderSize = 0;
            button7.ForeColor = SystemColors.Control;
            button7.Location = new Point(263, 251);
            button7.Name = "button7";
            button7.Size = new Size(180, 65);
            button7.TabIndex = 27;
            button7.Text = "Show teaching students";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(45, 128, 185);
            button6.FlatAppearance.BorderSize = 0;
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(582, 34);
            button6.Name = "button6";
            button6.Size = new Size(116, 39);
            button6.TabIndex = 26;
            button6.Text = "Log Out";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(45, 128, 185);
            button2.FlatAppearance.BorderSize = 0;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(382, 138);
            button2.Name = "button2";
            button2.Size = new Size(180, 65);
            button2.TabIndex = 24;
            button2.Text = "List all teaching subjects";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(45, 128, 185);
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(144, 138);
            button1.Name = "button1";
            button1.Size = new Size(180, 65);
            button1.TabIndex = 23;
            button1.Text = "View your infomation";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(41, 128, 185);
            label8.Location = new Point(52, 34);
            label8.Name = "label8";
            label8.Size = new Size(286, 37);
            label8.TabIndex = 22;
            label8.Text = "Welcome teacher:";
            // 
            // Teacher_menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 474);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Name = "Teacher_menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teacher_menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button7;
        private Button button6;
        private Button button2;
        private Button button1;
        private Label label8;
    }
}