﻿namespace Assessment_2
{
    partial class RegisterUser
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
            button6 = new Button();
            label8 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(45, 128, 185);
            button6.FlatAppearance.BorderSize = 0;
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(532, 33);
            button6.Name = "button6";
            button6.Size = new Size(142, 45);
            button6.TabIndex = 21;
            button6.Text = "Back to menu";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(41, 128, 185);
            label8.Location = new Point(21, 30);
            label8.Name = "label8";
            label8.Size = new Size(330, 37);
            label8.TabIndex = 22;
            label8.Text = "Registration: new user";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(45, 128, 185);
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(300, 423);
            button1.Name = "button1";
            button1.Size = new Size(116, 39);
            button1.TabIndex = 23;
            button1.Text = "Register new user";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Student", "Teacher" });
            comboBox1.Location = new Point(319, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(305, 33);
            comboBox1.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(29, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(669, 195);
            panel1.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 132);
            label3.Name = "label3";
            label3.Size = new Size(151, 32);
            label3.TabIndex = 29;
            label3.Text = "Last name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 83);
            label2.Name = "label2";
            label2.Size = new Size(148, 32);
            label2.TabIndex = 28;
            label2.Text = "First name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 30);
            label1.Name = "label1";
            label1.Size = new Size(135, 32);
            label1.TabIndex = 27;
            label1.Text = "User role: ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(319, 132);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(305, 31);
            textBox2.TabIndex = 26;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(319, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(305, 31);
            textBox1.TabIndex = 25;
            // 
            // RegisterUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 474);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(button6);
            Name = "RegisterUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterUser";
            Load += RegisterUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button6;
        private Label label8;
        private Button button1;
        private ComboBox comboBox1;
        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}