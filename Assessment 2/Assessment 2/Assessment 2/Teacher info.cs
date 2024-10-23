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
    public partial class Teacher_info : Form
    {

        public Teacher_info()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Admin_menu childForm1 = new Admin_menu();
            childForm1.Show();
            this.Hide();
        }

        private void Teacher_info_Load(object sender, EventArgs e)
        {

            string jsonFile = File.ReadAllText(@"teacher.json");
            var json = JsonConvert.DeserializeObject<TInfo>(jsonFile);
            // get some logic here for the current user login
            label1.Text = json.TeacherInfo[0].name;
            label4.Text = json.TeacherInfo[0].email;
        
        }
        public class items
        {
            public int id { get; set; }
            public string name { get; set; }
            public string email { get; set; }

        }
        class TInfo
        { 
            public List<items> TeacherInfo { get; set; }
        }

    }
}
