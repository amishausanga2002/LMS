using library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Member : User
{
    List<Book> borrowedBooks;
    public Member(string userID, string password, string name, string contactNo, string email) : base(userID, password, name, contactNo, email)
    {
        this.IsLibrarian = false;
        this.borrowedBooks = new List<Book>();
    }

    public List<Book> BorrowedBooks
    {
        get { return borrowedBooks; }
        set { borrowedBooks = value; }
    }
}