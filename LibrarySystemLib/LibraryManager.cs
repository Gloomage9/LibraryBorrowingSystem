using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibrarySystemLib
{
    public class LibraryManager
    {
        public List<Book> Books { get; set; }
        public List<Student> Students { get; set; }
        public List<Account> Accounts { get; set; }
        public List<Borrow> Transactions { get; set; }


        public LibraryManager()
        {
            Books = FileHandler.LoadBooks();
            Students = FileHandler.LoadStudents();
            Accounts = FileHandler.LoadAccounts();
            Transactions = FileHandler.LoadTransactions();

            if (Books.Count == 0)
            {
                Books.Add(new Book("IT001", "OOP Concepts", "Bjarne", 5));
                FileHandler.SaveBooks(Books);
            }

            if (Students.Count == 0)
            {
                Students.Add(new Student("1001", "Michael Ravanera"));
                FileHandler.SaveStudents(Students);
            }

            if (Accounts.Count == 0)
            {
                Accounts.Add(new Account("manager", "Mr. Ilao", "pass123", "Manager"));
                FileHandler.SaveAccounts(Accounts);
            }
        }


        public string BorrowBook(string studentId, string bookCode)
        {
            try
            {
                Student student = Students.FirstOrDefault(s => s.UniqueID == studentId);
                Book book = Books.FirstOrDefault(b => b.Code == bookCode);

                if (student == null)
                {
                    return "ERROR: Student ID was not found in the system.";
                }

                if (book == null)
                {
                    return "ERROR: Book Code was not found in the inventory.";
                }

                if (!student.CanBorrow())
                {
                    if (student.Status == "Banned")
                        return "ERROR: Student is currently BANNED and cannot borrow.";

                    if (student.BooksBorrowedCount >= 3)
                        return "ERROR: Student has reached the maximum limit of 3 borrowed books.";
                }

                if (book.Quantity < 1)
                {
                    return "ERROR: Book stock is zero. No available copies to borrow.";
                }

                if (book.BorrowCopy())
                {
                    student.RecordBorrow();
                    Borrow newTransaction = new Borrow(studentId, bookCode);
                    Transactions.Add(newTransaction);

                    FileHandler.AppendTransaction(newTransaction);
                    FileHandler.SaveBooks(Books);
                    FileHandler.SaveStudents(Students);

                    return $"SUCCESS! Borrowed: {book.Title}. Remaining Stock: {book.Quantity}.";
                }

                return "ERROR: Borrowing failed for an unknown reason.";
            }
            catch (Exception ex)
            {
                return $"SYSTEM FAILURE! Transaction aborted. Details: {ex.Message}";
            }
        }

        public string ReturnBook(string studentId, string bookCode)
        {
            try
            {
                Book book = Books.FirstOrDefault(b => b.Code == bookCode);
                Student student = Students.FirstOrDefault(s => s.UniqueID == studentId);

                Borrow transaction = Transactions
                    .FirstOrDefault(t => t.StudentID == studentId && t.BookCode == bookCode && t.IsUnreturned());

                if (book == null)
                {
                    return "ERROR: Book Code not found in inventory.";
                }
                if (student == null)
                {
                    return "ERROR: Student ID not found in system.";
                }
                if (transaction == null)
                {
                    return "ERROR: No unreturned loan found for this student and book.";
                }

                book.ReturnCopy();
                student.RecordReturn();
                transaction.RecordReturn();

                FileHandler.SaveBooks(Books);
                FileHandler.SaveStudents(Students);
                FileHandler.SaveTransactions(Transactions);

                return "SUCCESS! Book returned. Stock quantity increased.";
            }
            catch (Exception ex)
            {
                return $"SYSTEM FAILURE! Return transaction aborted. Details: {ex.Message}";
            }
        }
    }
}
