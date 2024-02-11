using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB;
using MongoDB.Driver;

namespace library
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            passwordText.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var loginUser = databaseConnection.readFromDatabase<User>(this.usernametext.Text, "UserID", "Users");


            if (loginUser != null && loginUser.login(this.usernametext.Text, this.passwordText.Text))
            {

                if (loginUser.IsLibrarian)
                {
                    LibraryForm form = new LibraryForm(loginUser);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    LibraryForm form = new LibraryForm(loginUser);
                    form.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid User name or Password");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {


        }

        private void usernametext_MouseEnter(object sender, EventArgs e)
        {

        }

        private void usernametext_MouseClick(object sender, MouseEventArgs e)
        {
            if (usernametext.Text == "Username")
            {
                usernametext.Clear();
            }
        }

        private void passwordText_MouseClick(object sender, MouseEventArgs e)
        {
            if (passwordText.Text == "Password")
            {
                passwordText.Clear();
            }

        }

        private void usernametext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
