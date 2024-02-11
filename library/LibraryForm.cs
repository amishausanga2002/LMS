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
    public partial class LibraryForm : Form
    {
        User user;
        List<Book> books = new List<Book>();

        public LibraryForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        // View book button click event handler
        private void button1_Click(object sender, EventArgs e)
        {
            refreshBooks();
            viewbook VB = new viewbook(books);
            VB.Show();
        }

        private void ViewStudentsBtn_Click(object sender, EventArgs e)
        {
            Librarian librarian = user as Librarian;
            viewstudent VS = new viewstudent(librarian.viewMembers());
            VS.Show();
        }

        private void AddBooksBtn_Click(object sender, EventArgs e)
        {
            Librarian librarian = user as Librarian;
            Addbook AB = new Addbook(librarian);
            AB.Show();
        }

        private void AddStudentsBtn_Click(object sender, EventArgs e)
        {
            Librarian librarian = user as Librarian;
            addstudent AS = new addstudent(librarian);
            AS.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            IssueBook IB = new IssueBook(user);
            IB.Show();
        }

        private void ReturnBookBtn_Click(object sender, EventArgs e)
        {
            ReturnBook RB = new ReturnBook(user);
            RB.Show();
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {
            books = user.viewBooks();

            if (this.user is Member)
            {

                this.AddBooksBtn.Hide();
                this.AddStudentsBtn.Hide();
                this.ViewStudentsBtn.Hide();
                this.TranactionBtn.Hide();
                IssueBooksBtn.Text = "Borrow Book";

            }
            else
            {
                this.button1.Hide();
            }
        }

        private void refreshBooks()

        {
            books = user.viewBooks();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Member member = user as Member;
            borrowedbookinterface BBI = new borrowedbookinterface(member.BorrowedBooks);
            BBI.Show();
        }

        private void TranactionBtn_Click(object sender, EventArgs e)
        {
            TransactionWindow transactionForm = new TransactionWindow();
            transactionForm.Show();
        }
    }
}
