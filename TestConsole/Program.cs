using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarySystemLib;


namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Test 1L Creating Book ---");
            Book oopBook = new Book("IT001", "OOP Concepts", "Bjarne Stroustrup", 5);

            Console.WriteLine("New Book Added:");
            Console.WriteLine(oopBook.ToString());
            Console.WriteLine("---------------------------------\n");

            Console.WriteLine("--- Test 2: Borrowing Copy ---");
            if (oopBook.BorrowCopy())
            {
                Console.WriteLine("Borrow successful! Stock decreased by 1.");
            }
            else
            {
                Console.WriteLine("Borrow FAILED! No stock available.");
            }
            Console.WriteLine(oopBook.ToString()); // Shows new quantity (4) and status
            Console.WriteLine("---------------------------------\n");

            // ----------------------------------------------------
            // TEST 3: Returning a Copy 
            // ----------------------------------------------------
            Console.WriteLine("--- Test 3: Returning Copy ---");
            oopBook.ReturnCopy(); // No need for an 'if' check, return always succeeds (void method)
            Console.WriteLine("Return successful! Stock increased by 1.");
            Console.WriteLine(oopBook.ToString()); // Shows new quantity (5) and status
            Console.WriteLine("---------------------------------\n");


            Console.WriteLine("\n=================================");
            Console.WriteLine("--- Day 3 Tests: Student Class ---");
            Console.WriteLine("=================================");

            // ----------------------------------------------------
            // TEST 4: Creating a New Student and Testing Limits
            // ----------------------------------------------------
            Student michael = new Student("12345", "Michael Angelo Ravanera");
            Console.WriteLine("Initial Student: " + michael.ToString()); // Count should be 0

            // Record three successful borrows
            michael.RecordBorrow();
            michael.RecordBorrow();
            michael.RecordBorrow();

            Console.WriteLine("\n-- After 3 Successful Borrows --");
            Console.WriteLine(michael.ToString()); // Count should be 3

            // Check if they can borrow a 4th book (Should be FALSE)
            Console.WriteLine("Can Michael borrow a 4th book? " + michael.CanBorrow());
            Console.WriteLine("---------------------------------\n");

            // ----------------------------------------------------
            // TEST 5: Banning and Unbanning Status Check
            // ----------------------------------------------------
            michael.BanStudent();
            Console.WriteLine("Banned Status: " + michael.ToString());

            // Check if they can borrow while Banned (Should be FALSE)
            Console.WriteLine("Can Michael borrow while Banned? " + michael.CanBorrow());

            michael.UnbanStudent();
            Console.WriteLine("Unbanned Status: " + michael.ToString());

            // Should still be FALSE because BooksBorrowedCount is 3
            Console.WriteLine("Can Michael borrow after Unban? " + michael.CanBorrow());
            Console.WriteLine("---------------------------------\n");

            Console.WriteLine("\n=================================");
            Console.WriteLine("--- Day 4 Tests: Account Class ---");
            Console.WriteLine("=================================");

            // ----------------------------------------------------
            // TEST 6: Creating Account and Deactivation
            // ----------------------------------------------------
            // Creates a new Manager account (Username, Name, Password, Role)
            Account manager = new Account("admin01", "Adomar Ilao", "ILAO123", "Manager");
            Console.WriteLine("Initial Account: " + manager.ToString());

            // Deactivate the account (Professor's requirement)
            manager.DeactivateAccount();
            Console.WriteLine("After Deactivation: " + manager.ToString());

            // Activate the account
            manager.ActivateAccount();
            Console.WriteLine("After Activation: " + manager.ToString());
            Console.WriteLine("---------------------------------\n");

            // ----------------------------------------------------
            // TEST 7: Password Update
            // ----------------------------------------------------
            Console.WriteLine("Current Password (Internal Check): " + manager.Password);

            manager.UpdatePassword("NEW_SECURE_PASS");
            Console.WriteLine("Password updated to NEW_SECURE_PASS.");
            Console.WriteLine("New Password (Internal Check): " + manager.Password);
            Console.WriteLine("---------------------------------\n");

            Console.ReadKey();
        }
    }
}
