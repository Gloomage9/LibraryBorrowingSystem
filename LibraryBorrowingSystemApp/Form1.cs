using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarySystemLib;

namespace LibraryBorrowingSystemApp
{
    public partial class Form1 : Form
    {
        private LibraryManager manager;

        public Form1()
        {
            InitializeComponent();

            this.Text = "Library Borrowing System - Main Menu";

            manager = new LibraryManager();

            LoadBookDataGrid();
            LoadStudentDataGrids();
            LoadBorrowedList();
            InitializeReportComboBox(); // Final Setup
        }

        // =================================================================
        // DISPLAY / UI HELPER METHODS
        // =================================================================

        private void LoadBookDataGrid()
        {
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = manager.Books;
            dgvBooks.AutoResizeColumns();
        }

        private void LoadStudentDataGrids()
        {
            dgvActiveStudents.DataSource = null;
            dgvActiveStudents.DataSource = manager.Students.Where(s => s.Status == "Active").ToList();

            dgvBannedStudents.DataSource = null;
            dgvBannedStudents.DataSource = manager.Students.Where(s => s.Status == "Banned").ToList();

            dgvActiveStudents.AutoResizeColumns();
            dgvBannedStudents.AutoResizeColumns();
        }

        private void LoadBorrowedList()
        {
            var currentlyBorrowed = manager.Transactions.Where(t => t.DateReturned == null).ToList();

            dgvBorrowedList.DataSource = null;
            dgvBorrowedList.DataSource = currentlyBorrowed;
            dgvBorrowedList.AutoResizeColumns();

            lblTotalBorrowed.Text = currentlyBorrowed.Count.ToString();
        }

        private void InitializeReportComboBox()
        {
            cmbReportType.Items.Add("List of All Borrowed Books (History)");
            cmbReportType.Items.Add("List of Unreturned Books by Borrowers");
            cmbReportType.Items.Add("Most & Least Borrowed Books");

            cmbReportType.SelectedIndex = 0;
        }

        // =================================================================
        // BOOK MANAGEMENT MODULE
        // =================================================================

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookCode.Text) ||
                string.IsNullOrWhiteSpace(txtBookTitle.Text) ||
                string.IsNullOrWhiteSpace(txtBookAuthor.Text))
            {
                MessageBox.Show("Please fill in all required fields (Code, Title, Author).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtBookQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Quantity must be a valid whole number greater than zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBookQuantity.Clear();
                return;
            }

            if (manager.Books.Any(b => b.Code.Equals(txtBookCode.Text, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Book Code already exists. Please use a unique code.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Book newBook = new Book(txtBookCode.Text, txtBookTitle.Text, txtBookAuthor.Text, quantity);
                manager.Books.Add(newBook);

                FileHandler.SaveBooks(manager.Books);

                MessageBox.Show("New Book Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtBookCode.Clear();
                txtBookTitle.Clear();
                txtBookAuthor.Clear();
                txtBookQuantity.Clear();

                LoadBookDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A system error occurred while saving the book: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateQty_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookCode.Text))
            {
                MessageBox.Show("Please enter the Book Code to update.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtBookQuantity.Text, out int newQuantity) || newQuantity < 0)
            {
                MessageBox.Show("New Quantity must be a valid whole number (0 or greater).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBookQuantity.Clear();
                return;
            }

            Book bookToUpdate = manager.Books.FirstOrDefault(b => b.Code.Equals(txtBookCode.Text, StringComparison.OrdinalIgnoreCase));

            if (bookToUpdate == null)
            {
                MessageBox.Show("Book Code not found. Cannot update.", "Book Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bookToUpdate.Quantity = newQuantity;
                bookToUpdate.UpdateStatus();

                FileHandler.SaveBooks(manager.Books);

                MessageBox.Show($"Quantity for {bookToUpdate.Title} updated to {newQuantity}.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtBookCode.Clear();
                txtBookQuantity.Clear();
                LoadBookDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A system error occurred during update: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =================================================================
        // STUDENT MANAGEMENT MODULE
        // =================================================================

        private void btnRegisterStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) || string.IsNullOrWhiteSpace(txtStudentName.Text))
            {
                MessageBox.Show("Please enter both Student ID and Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (manager.Students.Any(s => s.UniqueID.Equals(txtStudentID.Text, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Student ID already exists. Cannot register duplicate.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Student newStudent = new Student(txtStudentID.Text, txtStudentName.Text);
                manager.Students.Add(newStudent);

                FileHandler.SaveStudents(manager.Students);

                MessageBox.Show("Student Registered Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtStudentID.Clear();
                txtStudentName.Clear();

                LoadStudentDataGrids();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A system error occurred while registering: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) || string.IsNullOrWhiteSpace(txtStudentName.Text))
            {
                MessageBox.Show("Please enter both the Student ID (to find) and the New Name (to update).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student studentToUpdate = manager.Students.FirstOrDefault(s => s.UniqueID.Equals(txtStudentID.Text, StringComparison.OrdinalIgnoreCase));

            if (studentToUpdate == null)
            {
                MessageBox.Show("Student ID not found. Cannot update.", "Student Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                studentToUpdate.Name = txtStudentName.Text;
                FileHandler.SaveStudents(manager.Students);

                MessageBox.Show($"Student {studentToUpdate.UniqueID} name updated to {studentToUpdate.Name}.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtStudentID.Clear();
                txtStudentName.Clear();

                LoadStudentDataGrids();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A system error occurred during update: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnToggleBan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                MessageBox.Show("Please enter the Student ID to ban or unban.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student studentToToggle = manager.Students.FirstOrDefault(s => s.UniqueID.Equals(txtStudentID.Text, StringComparison.OrdinalIgnoreCase));

            if (studentToToggle == null)
            {
                MessageBox.Show("Student ID not found. Cannot change status.", "Student Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newStatus;

            if (studentToToggle.Status == "Active")
            {
                studentToToggle.BanStudent();
                newStatus = "BANNED";
            }
            else
            {
                studentToToggle.UnbanStudent();
                newStatus = "ACTIVE";
            }

            try
            {
                FileHandler.SaveStudents(manager.Students);

                MessageBox.Show($"Student {studentToToggle.UniqueID} status changed to {newStatus}.", "Status Change Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtStudentID.Clear();
                txtStudentName.Clear();

                LoadStudentDataGrids();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A system error occurred during status change: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =================================================================
        // BORROW / RETURN TRANSACTION MODULE
        // =================================================================

        private void btnProcessBorrow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBorrowStudentID.Text) || string.IsNullOrWhiteSpace(txtBorrowBookCode.Text))
            {
                MessageBox.Show("Please enter both Student ID and Book Code.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string result = manager.BorrowBook(txtBorrowStudentID.Text, txtBorrowBookCode.Text);

            if (result.StartsWith("SUCCESS!"))
            {
                MessageBox.Show(result, "Borrow Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadBookDataGrid();
                LoadStudentDataGrids();
                LoadBorrowedList();
            }
            else
            {
                MessageBox.Show(result, "Borrow Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtBorrowStudentID.Clear();
            txtBorrowBookCode.Clear();
        }

        private void btnProcessReturn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReturnStudentID.Text) || string.IsNullOrWhiteSpace(txtReturnBookCode.Text))
            {
                MessageBox.Show("Please enter both Student ID and Book Code.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string result = manager.ReturnBook(txtReturnStudentID.Text, txtReturnBookCode.Text);

            if (result.StartsWith("SUCCESS!"))
            {
                MessageBox.Show(result, "Return Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadBookDataGrid();
                LoadStudentDataGrids();
                LoadBorrowedList();
            }
            else
            {
                MessageBox.Show(result, "Return Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtReturnStudentID.Clear();
            txtReturnBookCode.Clear();
        }

        // =================================================================
        // REPORT MODULE
        // =================================================================

        private void CalculateAndDisplayStatistics()
        {
            var borrowingCounts = manager.Transactions
                .GroupBy(t => t.BookCode)
                .Select(g => new {
                    BookCode = g.Key,
                    BorrowCount = g.Count()
                })
                .OrderByDescending(x => x.BorrowCount)
                .ToList();

            if (borrowingCounts.Count == 0)
            {
                lblMostBorrowed.Text = "N/A";
                lblLeastBorrowed.Text = "N/A";
                return;
            }

            var mostBorrowed = borrowingCounts.First();
            var leastBorrowed = borrowingCounts.Last();

            Book mostBook = manager.Books.FirstOrDefault(b => b.Code == mostBorrowed.BookCode);
            Book leastBook = manager.Books.FirstOrDefault(b => b.Code == leastBorrowed.BookCode);

            lblMostBorrowed.Text = $"{mostBook?.Title} ({mostBorrowed.BorrowCount} borrows)";
            lblLeastBorrowed.Text = $"{leastBook?.Title} ({leastBorrowed.BorrowCount} borrows)";

            dgvReportOutput.DataSource = null;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (cmbReportType.SelectedItem == null)
            {
                MessageBox.Show("Please select a report type.");
                return;
            }
            dgvReportOutput.DataSource = null;
            lblMostBorrowed.Text = "";
            lblLeastBorrowed.Text = "";

            string selectedReport = cmbReportType.SelectedItem.ToString();

            try
            {
                if (selectedReport == "List of All Borrowed Books (History)")
                {
                    dgvReportOutput.DataSource = manager.Transactions.ToList();
                }
                else if (selectedReport == "List of Unreturned Books by Borrowers")
                {
                    dgvReportOutput.DataSource = manager.Transactions.Where(t => t.DateReturned == null).ToList();
                }
                else if (selectedReport == "Most & Least Borrowed Books")
                {
                    CalculateAndDisplayStatistics();
                }

                dgvReportOutput.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Report generation failed: {ex.Message}", "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}