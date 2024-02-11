using MongoDB.Driver;

namespace library
{
    static class databaseConnection
    {
        static private IMongoDatabase database = new MongoClient().GetDatabase("LIBRARY"); //getting database
        static private IMongoCollection<User> userColletion = database.GetCollection<User>("Users");//adding collection
        static private IMongoCollection<Book> bookCollection = database.GetCollection<Book>("Books");
        static private IMongoCollection<Transaction> transactions = database.GetCollection<Transaction>("Transaction");

        //Adding data to the database
        static public void addToDatabase<T>(T item)
        {
            if (item is Book)
            {
                try
                {
                    bookCollection.InsertOne(item as Book);
                    MessageBox.Show("Book saved!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Duplicated information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (item is Member)
            {
                try
                {
                    userColletion.InsertOne(item as Member);
                    MessageBox.Show("Member saved!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Duplicated information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (item is Transaction)
            {
                transactions.InsertOne(item as Transaction);
            }
            else
            {
                MessageBox.Show("Invalid Operation!");
            }
        }

        //removing data from database
        static public void removeFromDatabase<T>(T item)
        {
            if (item is Book)
            {
                Book book = item as Book;
                var filter = Builders<Book>.Filter.Eq(b => b.ISBN, book.ISBN);
                bookCollection.DeleteOne(filter);
                MessageBox.Show("Book is Deleted!");
            }
            else if (item is Member)
            {
                Member user = item as Member;
                var filter = Builders<User>.Filter.Eq(u => u.UserID, user.UserID);
                userColletion.DeleteOne(filter);
                MessageBox.Show("Member is Deleted!");

            }
        }
        //updating the database table
        static public void updateDatabase<T>(T item)
        {
            if (item is Book)
            {
                Book book = item as Book;
                var filter = Builders<Book>.Filter.Eq(b => b.ISBN, book.ISBN);
                bookCollection.ReplaceOne(filter, book);
                MessageBox.Show("Book is updated!");
            }
            else if (item is Member)
            {
                Member user = item as Member;
                var filter = Builders<User>.Filter.Eq(u => u.UserID, user.UserID);
                userColletion.ReplaceOne(filter, user);
                MessageBox.Show("Member is updated!");
            }
        }
        //reading data from the database
        static public T readFromDatabase<T>(string keyword, string attribute, string collection)
        {
            var filter = Builders<T>.Filter.Eq(attribute, keyword);
            return database.GetCollection<T>(collection).Find(filter).FirstOrDefault();
        }

        //reading all data from database
        static public List<T> readAllFromDatabase<T>(string collection)
        {
            return database.GetCollection<T>(collection).Find(_ => true).ToList();
        }

        static public List<T> filterFromDatabase<T>(string collection, string searchFrom, string keyword)
        {
            var filter = Builders<T>.Filter.Eq(searchFrom, keyword);
            return database.GetCollection<T>(collection).Find(filter).ToList();
        }



    }
}