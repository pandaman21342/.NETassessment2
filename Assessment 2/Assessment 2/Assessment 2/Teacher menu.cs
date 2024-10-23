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
    public partial class Teacher_menu : Form
    {
        public Teacher_menu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login childForm1 = new Login();
            childForm1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher_info childForm2 = new Teacher_info();
            childForm2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teacher_subjects childForm2 = new Teacher_subjects();
            childForm2.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Teacher_info childForm2 = new Teacher_info();
            childForm2.Show();
            this.Hide();
        }
    }
}
