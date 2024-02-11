using library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Librarian : User
{
    public Librarian(string userID, string password, string name, string contactNo, string email) : base(userID, password, name, contactNo, email)
    {
        this.IsLibrarian = true;
    }

    public List<Member> viewMembers()
    {
        List<User> users = databaseConnection.readAllFromDatabase<User>("Users");
        List<Member> members = new List<Member>();

        foreach (User user in users)
        {
            if (!user.IsLibrarian)
            {
                members.Add(user as Member);
            }
        }
        return members;
    }

    public void addmember(Member member)
    {
        databaseConnection.addToDatabase(member);
    }

    public void removemember(Member member)
    {
        databaseConnection.removeFromDatabase(member);
    }

    public void addBook(Book book)
    {
        databaseConnection.addToDatabase<Book>(book);
    }

    public void removeBook(Book book)
    {
        databaseConnection.removeFromDatabase<Book>(book);
    }





}
