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
    public partial class viewbook : Form
    {
        List<Book> books;
        public viewbook(List<Book> books)
        {
            this.books = books;
            InitializeComponent();
        }

        private void viewbook_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ISBN");
            dt.Columns.Add("Title");
            dt.Columns.Add("Author");
            dt.Columns.Add("Availability");
            

            foreach (Book book in books)
            {
                dt.Rows.Add(book.ISBN, book.Title, book.Author, book.Availability);
            }

            this.dataGridView1.DataSource = dt;
        }
    }
}
