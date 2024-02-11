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
    public partial class addstudent : Form
    {
        Librarian librarian;
        public addstudent(Librarian librarian)
        {
            InitializeComponent();
            this.librarian = librarian;
        }

        private void addstudent_Load(object sender, EventArgs e)
        {
            
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveInfoBtn_Click(object sender, EventArgs e)
        {
            string name = this.studentName.Text;
            string indexno = this.indexNo.Text;
            string studentcontactnumber = this.studentContactNumber.Text;
            string studentemailaddress = this.studentEmailAddress.Text;
            string password = this.studentpasswordtxt.Text;
            Member member = new Member(indexno, password, name, studentcontactnumber, studentemailaddress);
            librarian.addmember(member);
        }
    }
}
