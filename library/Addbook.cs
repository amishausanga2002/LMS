using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MongoDB.Bson.Serialization.Serializers.SerializerHelper;

namespace library
{
    public partial class Addbook : Form
    {
        Librarian librarian;
        public Addbook(Librarian librarian)
        {
            InitializeComponent();
            this.librarian = librarian;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBookPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            string Bookname = this.textBookName.Text;
            string Authorname = this.textAuthorName.Text;
            string ISBN = this.ISBNnumbertxt.Text;
            Book book = new Book(ISBN, Bookname, Authorname, true);
            librarian.addBook(book);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
