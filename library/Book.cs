using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 public class Book
{
    [BsonId]
    [BsonRepresentation(BsonType.String)]
    string Isbn;
    string title;
    string author;
    DateTime borrowedDate;
    bool availability;

    public Book(string isbn, string title, string author, bool availability)
    {
        Isbn = isbn;
        this.title = title;
        this.author = author;
        this.availability = availability;
    }

    public string ISBN
    {
        get { return Isbn; }
        set { Isbn = value; }
    }
    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; } 
        set { author = value; }
    }

    public bool Availability
    {
        get { return availability; }
        set { availability = value; }
    }

    public DateTime BorrowedDate
    {
        get { return borrowedDate; }
        set { borrowedDate = value; }
    }
}
