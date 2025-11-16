using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibrarySystemLib
{
    public static class FileHandler
    {
        public static void SaveBooks(List<Book> books)
        {
            try
            {
                string directoryPath = Path.GetDirectoryName(FilePaths.BooksFile);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                using (StreamWriter writer = new StreamWriter(FilePaths.BooksFile, false))
                {
                    foreach (Book b in books)
                    {
                        writer.WriteLine($"{b.Code},{b.Title},{b.Author},{b.Quantity},{b.Status}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: Could not save Books. Details: {ex.Message}");
            }
        }

        public static List<Book> LoadBooks()
        {
            List<Book> books = new List<Book>();

            if (!File.Exists(FilePaths.BooksFile)) return books;

            try
            {
                using (StreamReader reader = new StreamReader(FilePaths.BooksFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        if (data.Length == 5)
                        {
                            if (int.TryParse(data[3], out int quantity))
                            {
                                Book book = new Book(data[0], data[1], data[2], quantity);
                                book.Status = data[4];
                                books.Add(book);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading books: {ex.Message}");
            }

            return books;
        }

        public static void SaveStudents(List<Student> students)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(FilePaths.StudentsFile, false))
                {
                    foreach (Student s in students)
                    {
                        writer.WriteLine($"{s.UniqueID},{s.Name},{s.Status},{s.BooksBorrowedCount}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: Could not save Students. Details: {ex.Message}");
            }
        }

        public static List<Student> LoadStudents()
        {
            List<Student> students = new List<Student>();
            if (!File.Exists(FilePaths.StudentsFile)) return students;

            try
            {
                using (StreamReader reader = new StreamReader(FilePaths.StudentsFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        if (data.Length == 4)
                        {
                            if (int.TryParse(data[3], out int count))
                            {
                                Student student = new Student(data[0], data[1]);
                                student.Status = data[2];
                                student.BooksBorrowedCount = count;
                                students.Add(student);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading students: {ex.Message}");
            }
            return students;
        }

        public static void SaveAccounts(List<Account> accounts)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(FilePaths.AccountsFile, false))
                {
                    foreach (Account a in accounts)
                    {
                        writer.WriteLine($"{a.UniqueID},{a.Name},{a.Password},{a.Role},{a.Status}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: Could not save Accounts. Details: {ex.Message}");
            }
        }

        public static List<Account> LoadAccounts()
        {
            List<Account> accounts = new List<Account>();
            if (!File.Exists(FilePaths.AccountsFile)) return accounts;

            try
            {
                using (StreamReader reader = new StreamReader(FilePaths.AccountsFile))

                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        if (data.Length == 5)
                        {
                            Account account = new Account(data[0], data[1], data[2], data[3]);
                            account.Status = data[4];
                            accounts.Add(account);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading accounts: {ex.Message}");
            }
            return accounts;
        }

        public static void AppendTransaction(Borrow transaction)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(FilePaths.TransactionsFile, true))
                {
                    writer.WriteLine($"{transaction.TransactionID},{transaction.StudentID},{transaction.BookCode},{transaction.DateBorrowed},{transaction.DateReturned}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: Could not append Transaction. Details: {ex.Message}");
            }
        }

        public static void SaveTransactions(List<Borrow> transactions)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(FilePaths.TransactionsFile, false))
                {
                    foreach (Borrow t in transactions)
                    {
                        writer.WriteLine($"{t.TransactionID},{t.StudentID},{t.BookCode},{t.DateBorrowed},{t.DateReturned}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: Could not save Transactions. Details: {ex.Message}");
            }
        }

        public static List<Borrow> LoadTransactions()
        {
            List<Borrow> transactions = new List<Borrow>();
            if (!File.Exists(FilePaths.TransactionsFile)) return transactions;

            try
            {
                using (StreamReader reader = new StreamReader(FilePaths.TransactionsFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        if (data.Length == 5)
                        {
                            if (DateTime.TryParse(data[3], out DateTime borrowDate))
                            {
                                Borrow borrow = new Borrow(data[1], data[2]);
                                borrow.TransactionID = data[0];
                                borrow.DateBorrowed = borrowDate;

                                if (data[4] != "")
                                {
                                    if (DateTime.TryParse(data[4], out DateTime returnDate))
                                    {
                                        borrow.DateReturned = returnDate;
                                    }
                                }
                                transactions.Add(borrow);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading transactions: {ex.Message}");
            }
            return transactions;
        }
    }
}