using System.Runtime.InteropServices;

namespace library
{
    internal static class Program
    {
        [DllImport("kernel32.dll")]
        private static extern bool FreeConsole();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            while (true)
            {
                try
                {

                    Console.WriteLine("LIBRARY MANAGEMENT SYSTEM");
                    Console.WriteLine();
                    Console.WriteLine("1. Console App");
                    Console.WriteLine("2. GUI Application");
                    Console.WriteLine();
                    Console.Write("Enter Option: ");
                    int option = int.Parse(Console.ReadLine());

                    if (option == 1)
                    {
                        ConsoleApp();
                        break;
                    }
                    else if (option == 2)
                    {
                        FreeConsole();
                        //// To customize application configuration such as set high DPI settings or default font,
                        ////// see https://aka.ms/applicationconfiguration.
                        ApplicationConfiguration.Initialize();
                        Application.Run(new Form1());
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input!");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid Input");
                }
            }

        }


        static void ConsoleApp()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            bool running = true;
            do
            {
                Console.Clear();
                Console.WriteLine("LIBRARY MANAGEMENT SYSTEM");
                Console.WriteLine();
                Console.WriteLine("User Login...");
                Console.WriteLine();
                Console.Write("\t1. User Name: ");
                string username = Console.ReadLine();
                Console.Write("\t2. Password: ");
                string password = Console.ReadLine();
                Console.WriteLine();

                var user = databaseConnection.readFromDatabase<User>(username, "UserID", "Users");
                if (user != null)
                {
                    if (user.login(username, password))
                    {
                        if (user.IsLibrarian)
                        {
                            librarianConsole(user as Librarian);
                        }
                        else
                        {
                            memberConsole(user as Member);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid User name or password!");
                }
            }
            while (running);
        }

        static void memberConsole(Member member)
        {
            bool running = true;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine($"Hello {member.Name}");
                    Console.WriteLine();
                    Console.WriteLine("\t1. Show Book");
                    Console.WriteLine("\t2. Return Book");
                    Console.WriteLine("\t3. Borrow Book");
                    Console.WriteLine("\t4. View Borrowed Books");
                    Console.WriteLine("\t5. EXIT");
                    Console.WriteLine();

                    Console.Write("Select option: ");
                    int option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            showBooks(member);
                            break;

                        case 2:
                            returnBook(member);
                            break;

                        case 3:
                            borrowBook(member);
                            break;

                        case 4:
                            viewBorrowedBooks(member);
                            break;

                        case 5:
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Invalid");
                            Console.ReadKey();
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Error!");
                    Console.ReadKey();
                }
            } while (running);

        }

        static void showBooks(User user)
        {
            try
            {
                List<Book> books = user.viewBooks();
                if (books != null)
                {
                    Console.Clear();
                    Console.WriteLine("Show Books");
                    Console.WriteLine();

                    foreach (Book book in books)
                    {
                        Console.WriteLine($"Book Title : {book.Title}");
                        Console.WriteLine($"Book Author : {book.Author}");
                        Console.WriteLine($"Book ISBN Number : {book.ISBN}");

                        Console.WriteLine();

                    }
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("Book catalog is empty!");
                    Console.ReadKey();
                }


            }
            catch
            {
                Console.WriteLine("invalid");
                Console.ReadKey();
            }

        }

        static void returnBook(User user)
        {
            Console.Clear();
            if (user.IsLibrarian)
            {
                Console.WriteLine();
                Console.WriteLine("Return Book");
                Console.WriteLine();
                Console.WriteLine("Enter Book ISBN number: ");
                string isbn = Console.ReadLine();
                Console.WriteLine("Enter Member ID: ");
                string id = Console.ReadLine();

                user.ReturnBook(isbn, id);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Return Book");
                Console.WriteLine();
                Console.WriteLine("Enter Book ISBN number: ");
                string isbn = Console.ReadLine();

                user.ReturnBook(isbn, user.UserID);
                Console.ReadKey();
            }
        }

        static void borrowBook(User user)
        {
            Console.Clear();
            if (user.IsLibrarian)
            {
                Console.WriteLine();
                Console.WriteLine("Borrow Book");
                Console.WriteLine();
                Console.WriteLine("Enter Book ISBN number: ");
                string isbn = Console.ReadLine();
                Console.WriteLine("Enter Member ID: ");
                string id = Console.ReadLine();

                user.IssueBook(isbn, id);
                Console.ReadKey();


            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Borrow Book");
                Console.WriteLine();
                Console.WriteLine("Enter Book ISBN number: ");
                string isbn = Console.ReadLine();

                user.IssueBook(isbn, user.UserID);
                Console.ReadKey();

            }
        }

        static void viewBorrowedBooks(Member member)
        {
            Console.Clear();
            List<Book> books = member.BorrowedBooks;
            Console.WriteLine("View Borrowed Books");
            Console.WriteLine();
            Console.WriteLine();
            if (books != null)
            {
                foreach (Book book in books)
                {

                    Console.WriteLine($"Title: {book.Title}");
                    Console.WriteLine($"ISBN: {book.ISBN}");
                    Console.WriteLine($"Author: {book.Author}");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No any borrowed books!");
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void librarianConsole(Librarian librarian)
        {
            bool running = true;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine($"Hello {librarian.Name}");
                    Console.WriteLine();
                    Console.WriteLine("\t1. View Books");
                    Console.WriteLine("\t2. Return Book");
                    Console.WriteLine("\t3. Issue Book");
                    Console.WriteLine("\t4. Add Book");
                    Console.WriteLine("\t5. Add Student");
                    Console.WriteLine("\t6. View Students");
                    Console.WriteLine("\t7. View Transactions");
                    Console.WriteLine("\t8. EXIT");
                    Console.WriteLine();

                    Console.Write("Select option: ");
                    int option = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (option)
                    {
                        case 1:
                            showBooks(librarian);
                            break;

                        case 2:
                            returnBook(librarian);
                            break;

                        case 3:
                            borrowBook(librarian);
                            break;

                        case 4:
                            addBook(librarian);
                            break;

                        case 5:
                            addMember(librarian);
                            break;

                        case 6:
                            showMembers(librarian);
                            break;

                        case 7:
                            showTransactions(librarian);
                            break;

                        case 8:
                            running = false;
                            break;

                        default:
                            Console.WriteLine("Invalid");
                            Console.ReadKey();
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Error!");
                }
            } while (running);
        }

        static void addMember(Librarian librarian)
        {
            Console.WriteLine("Add new Member");
            Console.WriteLine();
            Console.WriteLine("User ID: ");
            string userID = Console.ReadLine();

            Console.WriteLine("Password: ");
            string password = Console.ReadLine();

            Console.WriteLine("User Name: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Contact no: ");
            string contactNo = Console.ReadLine();

            Console.WriteLine("Email: ");
            string email = Console.ReadLine();

            Console.WriteLine();

            if (userID.Trim() != "" && password.Trim() != "" && userName.Trim() != "" && contactNo.Trim() != "" && email.Trim() != "")
            {
                Member member = new Member(userID, password, userName, contactNo, email);
                librarian.addmember(member);
            }
            Console.ReadKey();

        }

        static void showTransactions(Librarian librarian)
        {
            List<Transaction> transactions = databaseConnection.readAllFromDatabase<Transaction>("Transaction");

            if (transactions != null)
            {
                foreach (Transaction transaction in transactions)
                {
                    Console.WriteLine($"Transaction Id: {transaction.Id}");
                    Console.WriteLine($"Transaction Type: {transaction.TransactionName}");
                    Console.WriteLine($"Date: {transaction.Date}");
                    Console.WriteLine($"Member name: {transaction.MemberName}");
                    Console.WriteLine($"Book title: {transaction.BookTitle}");
                    Console.WriteLine($"Book ISBN: {transaction.BookISBN}");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Transaction list is empty!");
            }
            Console.ReadKey();

        }

        static void showMembers(Librarian librarian)
        {
            List<Member> members = librarian.viewMembers();

            if (members != null)
            {
                foreach (Member member in members)
                {
                    Console.WriteLine($"Member Id: {member.UserID}");
                    Console.WriteLine($"Member name: {member.Name}");
                    Console.WriteLine($"Contact no: {member.ContactNo}");
                    Console.WriteLine($"Email: {member.Email}");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Members list is empty!");

            }
            Console.ReadKey();

        }

        static void addBook(Librarian librarian)
        {
            Console.WriteLine("Add new Book");
            Console.WriteLine();
            Console.Write("Book ISBN: ");
            string isbn = Console.ReadLine();

            Console.Write("Book Title: ");
            string title = Console.ReadLine();

            Console.Write("Book Author: ");
            string author = Console.ReadLine();


            Console.WriteLine();
            if (isbn.Trim() != "" && title.Trim() != "" && author.Trim() != "")
            {
                Book book = new Book(isbn, title, author, true);
                librarian.addBook(book);
                Console.ReadKey();
            }

        }
    }

}
