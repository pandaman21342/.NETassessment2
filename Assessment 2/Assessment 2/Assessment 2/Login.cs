using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics.Eventing.Reader;


namespace Assessment_2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Open up the json file to be read here
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            panel5.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            textBox2.BackColor = SystemColors.Control;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = SystemColors.Control;
            panel5.BackColor = SystemColors.Control;
            panel4.BackColor = Color.White;
            textBox2.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Change this to another page
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                // if (textBox1.Text == "admin" && textBox2.Text == "adminpass")
                // Check against json file 


                if (textBox1.Text == "admin")
                {
                    Admin_menu childForm1 = new Admin_menu();
                    childForm1.Show();
                    this.Hide();
                }
                else if (textBox1.Text == "teacher")
                {
                    Teacher_menu childForm3 = new Teacher_menu();
                    childForm3.Show();
                    this.Hide();
                }
                else if (textBox1.Text == "student")
                {

                    Student_menu childForm2 = new Student_menu();
                    childForm2.Show();
                    this.Hide();
                }
                else 
                {
                    MessageBox.Show("Please enter valid credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
