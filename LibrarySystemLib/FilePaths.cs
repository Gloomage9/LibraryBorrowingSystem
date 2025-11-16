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
        private static readonly string RootFolder =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                         "LibraryBorrowingSystem_Data");

        static FilePaths()
        {   
            if (!Directory.Exists(RootFolder))
                Directory.CreateDirectory(RootFolder);
        }

        public static readonly string BooksFile =
            Path.Combine(RootFolder, "Books.txt");

        public static readonly string StudentsFile =
            Path.Combine(RootFolder, "Students.txt");

        public static readonly string AccountsFile =
            Path.Combine(RootFolder, "Accounts.txt");

        public static readonly string TransactionsFile =
            Path.Combine(RootFolder, "Transactions.txt");
    }
}