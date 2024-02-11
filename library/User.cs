using library;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[BsonDiscriminator(RootClass = true)]
[BsonKnownTypes(typeof(Member), typeof(Librarian))]
abstract public class User
{
    [BsonId]
    [BsonRepresentation(BsonType.String)]
    string userID;

    string password;

    string name;
    string contactNo;
    string email;
    bool isLibrarian;

    public User(string userID, string password, string name, string contactNo, string email)
    {
        this.userID = userID;
        this.password = password;
        this.name = name;
        this.contactNo = contactNo;
        this.email = email;
    }
    public string UserID
    {
        get { return userID; }
        set { userID = value; }
    }
    public string Password
    {
        get { return password; }
        set { password = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string ContactNo
    {
        get { return contactNo; }
        set { contactNo = value; }
    }
    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public bool IsLibrarian
    {
        get { return isLibrarian; }
        set { isLibrarian = value; }
    }

    public bool login(string id, string pwd)
    {
        if (this.userID == id && this.password == pwd)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public List<Book> viewBooks()
    {
        List<Book> viewBooks = databaseConnection.readAllFromDatabase<Book>("Books");
        return viewBooks;
    }

    public void IssueBook(string bookISBN, string ID)
    {
        Member member = databaseConnection.readFromDatabase<User>(ID, "UserID", "Users") as Member;
        Book book = databaseConnection.readFromDatabase<Book>(bookISBN, "ISBN", "Books");

        if (member == null || book == null)
        {
            MessageBox.Show("Invalid Member!");
        }
        else
        {
            if (book.Availability && !member.BorrowedBooks.Exists(b => b.ISBN == book.ISBN))
            {
                book.BorrowedDate = DateTime.Now;
                book.Availability = false;
                databaseConnection.updateDatabase<Book>(book);
                member.BorrowedBooks.Add(book);
                databaseConnection.updateDatabase<Member>(member);
                Transaction transaction = new Transaction(member.name, book.ISBN, book.Title, book.BorrowedDate, "Borrow Book");
                databaseConnection.addToDatabase<Transaction>(transaction);
            }
            else
            {
                MessageBox.Show("Book is not available to borrow!");
            }
        }

    }

    public void ReturnBook(string bookISBN, string ID)
    {
        Member member = databaseConnection.readFromDatabase<User>(ID, "UserID", "Users") as Member;
        Book book = databaseConnection.readFromDatabase<Book>(bookISBN, "ISBN", "Books");

        if (member.BorrowedBooks.Exists(b => b.ISBN == book.ISBN))
        {
            book.BorrowedDate = new DateTime();
            book.Availability = true;
            databaseConnection.updateDatabase<Book>(book);
            member.BorrowedBooks.RemoveAll(b => b.ISBN == book.ISBN);
            databaseConnection.updateDatabase<Member>(member);
            Transaction transaction = new Transaction(member.name, book.ISBN, book.Title, book.BorrowedDate, "Return Book");
            databaseConnection.addToDatabase<Transaction>(transaction);
        }
        else
        {
            MessageBox.Show("Invalid Operation!");
        }
    }
}