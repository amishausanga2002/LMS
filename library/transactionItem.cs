using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace library
{
    public partial class transactionItem : UserControl
    {
        Transaction transaction;

        public transactionItem(Transaction transaction)
        {
            InitializeComponent();
            this.transaction = transaction;
        }

        private void transactionItem_Load(object sender, EventArgs e)
        {
            this.id.Text = transaction.Id;
            this.type.Text = transaction.TransactionName;
            this.name.Text = transaction.MemberName;
            this.date.Text = transaction.Date.ToString();
            this.title.Text = transaction.BookTitle;
            this.isbn.Text = transaction.BookISBN;
        }
    }
}
