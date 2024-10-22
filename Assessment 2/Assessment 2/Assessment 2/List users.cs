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
    public partial class List_users : Form
    {
        public List_users()
        {
            InitializeComponent();
        }

        private void List_users_Load(object sender, EventArgs e)
        {
            // Bind json data here to display 
            // string json = File.ReadAllText(@"users.json");
            // Load data into data table
            // dataGridView1.DataSource = JsonConvert.DeserializeObject<DataTable>(json);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Admin_menu childForm1 = new Admin_menu();
            childForm1.Show();
            this.Hide();
        }
    }
}
