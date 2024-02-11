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
    public partial class IssueBook : Form
    {
        User user;
        public IssueBook(User user)
        {
            InitializeComponent();
            this.user = user;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isbn = this.isbnnum.Text;
            string bookID = this.memberID.Text;
            user.IssueBook(isbn, bookID);
        }
    }
}
