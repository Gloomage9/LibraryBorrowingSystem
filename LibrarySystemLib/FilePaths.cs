using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibrarySystemLib
{
    public static class FilePaths
    {
        // Get the base folder where the application is running (e.g., bin/Debug/)
        private static readonly string BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;

        // Go two levels up (to the main LibraryBorrowingSystem folder) for guaranteed saving location
        private static readonly string BasePath = Path.GetFullPath(Path.Combine(BaseDirectory, @"..\..\"));

        // Combine the stable BasePath with the file names
        public static readonly string BooksFile = Path.Combine(BasePath, "Books.txt");
        public static readonly string StudentsFile = Path.Combine(BasePath, "Students.txt");
        public static readonly string AccountsFile = Path.Combine(BasePath, "Accounts.txt");
        public static readonly string TransactionsFile = Path.Combine(BasePath, "Transactions.txt");
    }
}