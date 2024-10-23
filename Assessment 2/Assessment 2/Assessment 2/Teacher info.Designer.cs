namespace Assessment_2
{
    partial class Teacher_info
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
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(45, 128, 185);
            button6.FlatAppearance.BorderSize = 0;
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(547, 35);
            button6.Name = "button6";
            button6.Size = new Size(142, 45);
            button6.TabIndex = 31;
            button6.Text = "Back to menu";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(41, 128, 185);
            label8.Location = new Point(67, 39);
            label8.Name = "label8";
            label8.Size = new Size(264, 32);
            label8.TabIndex = 30;
            label8.Text = "Displaying user info:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(319, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(305, 31);
            textBox2.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 33);
            label2.Name = "label2";
            label2.Size = new Size(144, 32);
            label2.TabIndex = 28;
            label2.Text = "Full name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(21, 86);
            label3.Name = "label3";
            label3.Size = new Size(82, 32);
            label3.TabIndex = 29;
            label3.Text = "Email";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(31, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(667, 303);
            panel1.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 30;
            label1.Text = "label1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(319, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(305, 34);
            panel2.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(322, 90);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 32;
            label4.Text = "label4";
            // 
            // Teacher_info
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 474);
            Controls.Add(panel1);
            Controls.Add(button6);
            Controls.Add(label8);
            Name = "Teacher_info";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teacher_info";
            Load += Teacher_info_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button6;
        private Label label8;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label4;
    }
}