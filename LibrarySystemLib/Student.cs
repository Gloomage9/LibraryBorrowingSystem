using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemLib
{
    public class Student : Person
    {
        public string Status { get; set; }

        public int BooksBorrowedCount { get; set; }
        private const int MAX_BOOKS_ALLOWED = 3;


        public Student(string studentID, string name) : base(name, studentID)
        {
            Status = "Active";
            BooksBorrowedCount = 0;
        }

        public bool CanBorrow()
        {
            if (Status == "Banned")
            {
                return false;
            }

            if (BooksBorrowedCount >= MAX_BOOKS_ALLOWED)
            {
                return false;
            }

            return true;
        }

        public void RecordBorrow()
        {
            if (CanBorrow())
            {
                BooksBorrowedCount++;
            }
        }

        public void RecordReturn()
        {
            if (BooksBorrowedCount > 0)
            {
                BooksBorrowedCount--;
            }
        }

        public void BanStudent()
        {
            Status = "Banned";
        }

        public void UnbanStudent()
        {
            Status = "Active";
        }

        public override string ToString()
        {
            return $"ID: {UniqueID} | Name: {Name} | Status: {Status} | Books Borrowed: {BooksBorrowedCount}";
        }
    }
}
