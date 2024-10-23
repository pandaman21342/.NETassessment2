using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_2
{
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Change this to another page
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                // write to json file

                MessageBox.Show("New user registered!.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Admin_menu childForm1 = new Admin_menu();
                childForm1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Admin_menu childForm1 = new Admin_menu();
            childForm1.Show();
            this.Hide();
        }
    }
}
