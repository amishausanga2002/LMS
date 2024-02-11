using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace library
{

    public partial class borrowedbookinterface : Form
    {
        List<Book> books;

        public borrowedbookinterface(List<Book> books)
        {
            InitializeComponent();
            this.books = books;
            
        }

        private void borrowedbookinterface_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ISBN");
            dt.Columns.Add("Title");
            dt.Columns.Add("Borrwed Date");
            dt.Columns.Add("Due Date");

            if (books != null)
            {
                foreach (Book book in books)
                {
                    dt.Rows.Add(book.ISBN, book.Title, book.BorrowedDate);

                }
                this.dataGridView3.DataSource = dt;
            }
            else
            {
                MessageBox.Show("You haven't borrwed any book!");
            }
                
            

        }
    }

}
