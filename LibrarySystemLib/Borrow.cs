using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemLib
{
    public class Borrow
    {
        public string TransactionID {  get; set; }
        public string StudentID { get; set; }
        public string BookCode { get; set; }

        public DateTime DateBorrowed { get; set; }
        public DateTime? DateReturned { get; set; }

        public Borrow(string studentID, string bookCode)
        {
            TransactionID = Guid.NewGuid().ToString();
            StudentID = studentID;
            BookCode = bookCode;
            DateBorrowed = DateTime.Now;
            DateReturned = null;
        }

        public void RecordReturn()
        {
            if (DateReturned.HasValue)
            {
                DateReturned = DateTime.Now;
            }
        }
        public bool IsUnreturned()
        {
            return DateReturned == null;
        }

        public override string ToString()
        {
            string returnDateString = DateReturned.HasValue
                ? DateReturned.Value.ToShortDateString()
                : "PENDING";
            return $"ID: {TransactionID.Substring(0, 8)} | Student: {StudentID} | Book: {BookCode} | Borrowed: {DateBorrowed.ToShortDateString()} | Returned: {returnDateString}";
        }
    }
}
