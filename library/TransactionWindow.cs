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
    public partial class TransactionWindow : Form
    {
        List<Transaction> transactions;
        public TransactionWindow()
        {
            InitializeComponent();
        }

        private void TransactionWindow_Load(object sender, EventArgs e)
        {
            transactions = databaseConnection.readAllFromDatabase<Transaction>("Transaction");
            if (transactions != null)
            {
                foreach (Transaction transaction in transactions)
                {
                    this.flowLayoutPanel1.Controls.Add(new transactionItem(transaction));
                }

            }
            else
            {
                MessageBox.Show("Empty!");
            }
        }
    }
}
