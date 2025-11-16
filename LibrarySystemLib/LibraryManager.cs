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
            Transactions = new List<Borrow>();

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
                Accounts.Add(new Account("manager", "Mr. Ilaoo", "pass123", "Manager"));
                FileHandler.SaveAccounts(Accounts);
            }
        }

        // LibraryManager.cs - BorrowBook (FINAL VALIDATED VERSION)

        public string BorrowBook(string studentId, string bookCode)
        {
            try
            {
                // 1. Validation: Find the Student and Book objects 
                Student student = Students.FirstOrDefault(s => s.UniqueID == studentId);
                Book book = Books.FirstOrDefault(b => b.Code == bookCode);

                // 2. Specific Check: Does the Student ID exist?
                if (student == null)
                {
                    return "ERROR: Student ID was not found in the system.";
                }

                // 3. Specific Check: Does the Book Code exist?
                if (book == null)
                {
                    return "ERROR: Book Code was not found in the inventory.";
                }

                // 4. Business Policy Check: Is the Student Banned or at the limit?
                if (!student.CanBorrow())
                {
                    if (student.Status == "Banned")
                        return "ERROR: Student is currently BANNED and cannot borrow.";

                    // This handles the limit check (max 3 books)
                    if (student.BooksBorrowedCount >= 3)
                        return "ERROR: Student has reached the maximum limit of 3 borrowed books.";
                }

                // 5. Business Policy Check: Is there stock?
                if (book.Quantity < 1)
                {
                    return "ERROR: Book stock is zero. No available copies to borrow.";
                }

                // 6. Perform the Transaction and Save
                if (book.BorrowCopy())
                {
                    student.RecordBorrow();
                    Borrow newTransaction = new Borrow(studentId, bookCode);
                    Transactions.Add(newTransaction);

                    // SAVE CHANGES TO DISK:
                    FileHandler.AppendTransaction(newTransaction);
                    FileHandler.SaveBooks(Books);
                    FileHandler.SaveStudents(Students);

                    // Success message
                    return $"SUCCESS! Borrowed: {book.Title}. Remaining Stock: {book.Quantity}.";
                }

                // Final Fallback Error (Shouldn't be reached)
                return "ERROR: Borrowing failed for an unknown reason.";
            }
            catch (Exception ex)
            {
                // General catch for unexpected system errors (e.g., file system crash)
                return $"SYSTEM FAILURE! Transaction aborted. Details: {ex.Message}";
            }
        }

        public bool ReturnBook(string studentId, string bookCode)
        {
            Book book = Books.FirstOrDefault(b => b.Code == bookCode);
            Student student = Students.FirstOrDefault(s => s.UniqueID == studentId);

            Borrow transaction = Transactions
                .FirstOrDefault(t => t.StudentID == studentId && t.BookCode == bookCode && t.IsUnreturned());

            if (book == null || student == null || transaction == null)
            {
                return false;
            }

            
            book.ReturnCopy();          
            student.RecordReturn();     
            transaction.RecordReturn(); 

            return true;
        }
    }
}
