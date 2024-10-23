using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Assessment_2
{
    public partial class Teacher_subjects : Form
    {

        public Teacher_subjects()
        {
            InitializeComponent();
        }

        private void Teacher_subjects_Load(object sender, EventArgs e)
        {
            // Bind json data here to display 
            string json = File.ReadAllText(@"students.json");

            // Load data into data table
            dataGridView1.DataSource = JsonConvert.DeserializeObject<DataTable>(json);

        }
        // using linq query to find the thing


        private void button1_Click(object sender, EventArgs e)
        {
            Admin_menu childForm1 = new Admin_menu();
            childForm1.Show();
            this.Hide();
        }
    }

}
