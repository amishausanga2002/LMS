using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Transaction
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    private string id;
    private string memberName;
    private string bookISBN;
    private string bookTitle;
    private DateTime date;
    private string transactionName;

    public Transaction(string memberName, string bookISBN, string bookTitle, DateTime date, string transactionName)
    {
        this.memberName = memberName;
        this.bookISBN = bookISBN;
        this.bookTitle = bookTitle;
        this.date = date;
        this.transactionName = transactionName;
    }

    public string Id
    {
        get { return id; }
        set { id = value; }
    }    
    
    public string BookTitle
    {
        get { return bookTitle; }
        set { bookTitle = value; }
    }

    public string MemberName
    {
        get { return memberName; }
        set { memberName = value; }
    }
    public string BookISBN
    {
        get { return bookISBN; }
        set { bookISBN = value; }
    }
    public DateTime Date
    {
        get { return date; }
        set { date = value; }
    }
    public string TransactionName
    {
        get { return transactionName; }
        set { transactionName = value; }
    }
}