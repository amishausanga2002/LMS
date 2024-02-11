using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class viewstudent : Form
    {
        List<Member> members;
        public viewstudent(List<Member> members)
        {
            this.members = members;
            InitializeComponent();

        }

        private void viewstudent_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Student ID");
            dt.Columns.Add("Contact No");
            dt.Columns.Add("Email");

            foreach (Member member in members)
            {
                dt.Rows.Add(member.Name, member.UserID, member.ContactNo, member.Email);
            }

            this.dataGridView2.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
