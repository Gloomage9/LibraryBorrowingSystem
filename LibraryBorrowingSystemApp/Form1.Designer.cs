namespace LibraryBorrowingSystemApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.tabPageBook = new System.Windows.Forms.TabPage();
            this.tabPageStudent = new System.Windows.Forms.TabPage();
            this.groupBoxStudentInfo = new System.Windows.Forms.GroupBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.tabPageTransaction = new System.Windows.Forms.TabPage();
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.btnRegisterStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnToggleBan = new System.Windows.Forms.Button();
            this.dgvActiveStudents = new System.Windows.Forms.DataGridView();
            this.lblActiveStudents = new System.Windows.Forms.Label();
            this.dgvBannedStudents = new System.Windows.Forms.DataGridView();
            this.lblBannedStudents = new System.Windows.Forms.Label();
            this.groupBoxBorrow = new System.Windows.Forms.GroupBox();
            this.groupBoxReturn = new System.Windows.Forms.GroupBox();
            this.btnProcessBorrow = new System.Windows.Forms.Button();
            this.txtBorrowStudentID = new System.Windows.Forms.TextBox();
            this.txtBorrowBookCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReturnStudentID = new System.Windows.Forms.TextBox();
            this.txtReturnBookCode = new System.Windows.Forms.TextBox();
            this.btnProcessReturn = new System.Windows.Forms.Button();
            this.groupBoxBookInfo = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBookCode = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.txtBookQuantity = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnUpdateQty = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalBorrowed = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvBorrowedList = new System.Windows.Forms.DataGridView();
            this.groupBoxStats = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblMostBorrowed = new System.Windows.Forms.Label();
            this.lblLeastBorrowed = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvReportOutput = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageHome.SuspendLayout();
            this.tabPageBook.SuspendLayout();
            this.tabPageStudent.SuspendLayout();
            this.groupBoxStudentInfo.SuspendLayout();
            this.tabPageTransaction.SuspendLayout();
            this.tabPageReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBannedStudents)).BeginInit();
            this.groupBoxBorrow.SuspendLayout();
            this.groupBoxReturn.SuspendLayout();
            this.groupBoxBookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedList)).BeginInit();
            this.groupBoxStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageHome);
            this.tabControlMain.Controls.Add(this.tabPageBook);
            this.tabControlMain.Controls.Add(this.tabPageStudent);
            this.tabControlMain.Controls.Add(this.tabPageTransaction);
            this.tabControlMain.Controls.Add(this.tabPageReport);
            this.tabControlMain.Location = new System.Drawing.Point(1, 1);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(795, 446);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageHome
            // 
            this.tabPageHome.Controls.Add(this.dgvBorrowedList);
            this.tabPageHome.Controls.Add(this.label13);
            this.tabPageHome.Controls.Add(this.lblTotalBorrowed);
            this.tabPageHome.Controls.Add(this.label11);
            this.tabPageHome.Controls.Add(this.label10);
            this.tabPageHome.Controls.Add(this.label9);
            this.tabPageHome.Location = new System.Drawing.Point(4, 25);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(787, 417);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Home/Dashboard";
            this.tabPageHome.UseVisualStyleBackColor = true;
            // 
            // tabPageBook
            // 
            this.tabPageBook.Controls.Add(this.dgvBooks);
            this.tabPageBook.Controls.Add(this.btnUpdateQty);
            this.tabPageBook.Controls.Add(this.btnAddBook);
            this.tabPageBook.Controls.Add(this.groupBoxBookInfo);
            this.tabPageBook.Location = new System.Drawing.Point(4, 25);
            this.tabPageBook.Name = "tabPageBook";
            this.tabPageBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBook.Size = new System.Drawing.Size(787, 417);
            this.tabPageBook.TabIndex = 1;
            this.tabPageBook.Text = "Book Management";
            this.tabPageBook.UseVisualStyleBackColor = true;
            // 
            // tabPageStudent
            // 
            this.tabPageStudent.Controls.Add(this.lblBannedStudents);
            this.tabPageStudent.Controls.Add(this.dgvBannedStudents);
            this.tabPageStudent.Controls.Add(this.lblActiveStudents);
            this.tabPageStudent.Controls.Add(this.dgvActiveStudents);
            this.tabPageStudent.Controls.Add(this.groupBoxStudentInfo);
            this.tabPageStudent.Location = new System.Drawing.Point(4, 25);
            this.tabPageStudent.Name = "tabPageStudent";
            this.tabPageStudent.Size = new System.Drawing.Size(787, 417);
            this.tabPageStudent.TabIndex = 2;
            this.tabPageStudent.Text = "Student Management";
            this.tabPageStudent.UseVisualStyleBackColor = true;
            // 
            // groupBoxStudentInfo
            // 
            this.groupBoxStudentInfo.Controls.Add(this.label18);
            this.groupBoxStudentInfo.Controls.Add(this.label12);
            this.groupBoxStudentInfo.Controls.Add(this.btnToggleBan);
            this.groupBoxStudentInfo.Controls.Add(this.btnUpdateStudent);
            this.groupBoxStudentInfo.Controls.Add(this.btnRegisterStudent);
            this.groupBoxStudentInfo.Controls.Add(this.txtStudentName);
            this.groupBoxStudentInfo.Controls.Add(this.txtStudentID);
            this.groupBoxStudentInfo.Location = new System.Drawing.Point(4, 3);
            this.groupBoxStudentInfo.Name = "groupBoxStudentInfo";
            this.groupBoxStudentInfo.Size = new System.Drawing.Size(397, 168);
            this.groupBoxStudentInfo.TabIndex = 0;
            this.groupBoxStudentInfo.TabStop = false;
            this.groupBoxStudentInfo.Text = "Student Information";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(17, 120);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(166, 22);
            this.txtStudentName.TabIndex = 1;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(17, 59);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(166, 22);
            this.txtStudentID.TabIndex = 0;
            // 
            // tabPageTransaction
            // 
            this.tabPageTransaction.Controls.Add(this.groupBoxReturn);
            this.tabPageTransaction.Controls.Add(this.groupBoxBorrow);
            this.tabPageTransaction.Location = new System.Drawing.Point(4, 25);
            this.tabPageTransaction.Name = "tabPageTransaction";
            this.tabPageTransaction.Size = new System.Drawing.Size(787, 417);
            this.tabPageTransaction.TabIndex = 3;
            this.tabPageTransaction.Text = "Borrow / Return";
            this.tabPageTransaction.UseVisualStyleBackColor = true;
            // 
            // tabPageReport
            // 
            this.tabPageReport.Controls.Add(this.dgvReportOutput);
            this.tabPageReport.Controls.Add(this.label17);
            this.tabPageReport.Controls.Add(this.btnGenerateReport);
            this.tabPageReport.Controls.Add(this.cmbReportType);
            this.tabPageReport.Controls.Add(this.label16);
            this.tabPageReport.Controls.Add(this.groupBoxStats);
            this.tabPageReport.Location = new System.Drawing.Point(4, 25);
            this.tabPageReport.Name = "tabPageReport";
            this.tabPageReport.Size = new System.Drawing.Size(787, 417);
            this.tabPageReport.TabIndex = 4;
            this.tabPageReport.Text = "Reports";
            this.tabPageReport.UseVisualStyleBackColor = true;
            // 
            // btnRegisterStudent
            // 
            this.btnRegisterStudent.Location = new System.Drawing.Point(208, 33);
            this.btnRegisterStudent.Name = "btnRegisterStudent";
            this.btnRegisterStudent.Size = new System.Drawing.Size(129, 23);
            this.btnRegisterStudent.TabIndex = 2;
            this.btnRegisterStudent.Text = "Register Student";
            this.btnRegisterStudent.UseVisualStyleBackColor = true;
            this.btnRegisterStudent.Click += new System.EventHandler(this.btnRegisterStudent_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(208, 78);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(159, 23);
            this.btnUpdateStudent.TabIndex = 3;
            this.btnUpdateStudent.Text = "Update Student Info";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnToggleBan
            // 
            this.btnToggleBan.Location = new System.Drawing.Point(208, 120);
            this.btnToggleBan.Name = "btnToggleBan";
            this.btnToggleBan.Size = new System.Drawing.Size(147, 23);
            this.btnToggleBan.TabIndex = 4;
            this.btnToggleBan.Text = "Ban/Unban Student";
            this.btnToggleBan.UseVisualStyleBackColor = true;
            this.btnToggleBan.Click += new System.EventHandler(this.btnToggleBan_Click);
            // 
            // dgvActiveStudents
            // 
            this.dgvActiveStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveStudents.Location = new System.Drawing.Point(10, 199);
            this.dgvActiveStudents.Name = "dgvActiveStudents";
            this.dgvActiveStudents.RowHeadersWidth = 51;
            this.dgvActiveStudents.RowTemplate.Height = 24;
            this.dgvActiveStudents.Size = new System.Drawing.Size(331, 150);
            this.dgvActiveStudents.TabIndex = 1;
            // 
            // lblActiveStudents
            // 
            this.lblActiveStudents.AutoSize = true;
            this.lblActiveStudents.Location = new System.Drawing.Point(7, 180);
            this.lblActiveStudents.Name = "lblActiveStudents";
            this.lblActiveStudents.Size = new System.Drawing.Size(122, 16);
            this.lblActiveStudents.TabIndex = 2;
            this.lblActiveStudents.Text = "Active Students List";
            // 
            // dgvBannedStudents
            // 
            this.dgvBannedStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBannedStudents.Location = new System.Drawing.Point(405, 199);
            this.dgvBannedStudents.Name = "dgvBannedStudents";
            this.dgvBannedStudents.RowHeadersWidth = 51;
            this.dgvBannedStudents.RowTemplate.Height = 24;
            this.dgvBannedStudents.Size = new System.Drawing.Size(331, 150);
            this.dgvBannedStudents.TabIndex = 3;
            // 
            // lblBannedStudents
            // 
            this.lblBannedStudents.AutoSize = true;
            this.lblBannedStudents.Location = new System.Drawing.Point(402, 180);
            this.lblBannedStudents.Name = "lblBannedStudents";
            this.lblBannedStudents.Size = new System.Drawing.Size(132, 16);
            this.lblBannedStudents.TabIndex = 4;
            this.lblBannedStudents.Text = "Banned Students List";
            // 
            // groupBoxBorrow
            // 
            this.groupBoxBorrow.Controls.Add(this.label2);
            this.groupBoxBorrow.Controls.Add(this.label1);
            this.groupBoxBorrow.Controls.Add(this.txtBorrowBookCode);
            this.groupBoxBorrow.Controls.Add(this.txtBorrowStudentID);
            this.groupBoxBorrow.Controls.Add(this.btnProcessBorrow);
            this.groupBoxBorrow.Location = new System.Drawing.Point(7, 3);
            this.groupBoxBorrow.Name = "groupBoxBorrow";
            this.groupBoxBorrow.Size = new System.Drawing.Size(372, 409);
            this.groupBoxBorrow.TabIndex = 0;
            this.groupBoxBorrow.TabStop = false;
            this.groupBoxBorrow.Text = "Borrow Book";
            // 
            // groupBoxReturn
            // 
            this.groupBoxReturn.Controls.Add(this.btnProcessReturn);
            this.groupBoxReturn.Controls.Add(this.txtReturnBookCode);
            this.groupBoxReturn.Controls.Add(this.txtReturnStudentID);
            this.groupBoxReturn.Controls.Add(this.label4);
            this.groupBoxReturn.Controls.Add(this.label3);
            this.groupBoxReturn.Location = new System.Drawing.Point(385, 3);
            this.groupBoxReturn.Name = "groupBoxReturn";
            this.groupBoxReturn.Size = new System.Drawing.Size(398, 409);
            this.groupBoxReturn.TabIndex = 1;
            this.groupBoxReturn.TabStop = false;
            this.groupBoxReturn.Text = "Return Book";
            // 
            // btnProcessBorrow
            // 
            this.btnProcessBorrow.Location = new System.Drawing.Point(80, 138);
            this.btnProcessBorrow.Name = "btnProcessBorrow";
            this.btnProcessBorrow.Size = new System.Drawing.Size(141, 23);
            this.btnProcessBorrow.TabIndex = 0;
            this.btnProcessBorrow.Text = "Process Borrow";
            this.btnProcessBorrow.UseVisualStyleBackColor = true;
            this.btnProcessBorrow.Click += new System.EventHandler(this.btnProcessBorrow_Click);
            // 
            // txtBorrowStudentID
            // 
            this.txtBorrowStudentID.Location = new System.Drawing.Point(99, 36);
            this.txtBorrowStudentID.Name = "txtBorrowStudentID";
            this.txtBorrowStudentID.Size = new System.Drawing.Size(100, 22);
            this.txtBorrowStudentID.TabIndex = 1;
            // 
            // txtBorrowBookCode
            // 
            this.txtBorrowBookCode.Location = new System.Drawing.Point(99, 78);
            this.txtBorrowBookCode.Name = "txtBorrowBookCode";
            this.txtBorrowBookCode.Size = new System.Drawing.Size(100, 22);
            this.txtBorrowBookCode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Book Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Student ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Book Code:";
            // 
            // txtReturnStudentID
            // 
            this.txtReturnStudentID.Location = new System.Drawing.Point(98, 36);
            this.txtReturnStudentID.Name = "txtReturnStudentID";
            this.txtReturnStudentID.Size = new System.Drawing.Size(100, 22);
            this.txtReturnStudentID.TabIndex = 5;
            // 
            // txtReturnBookCode
            // 
            this.txtReturnBookCode.Location = new System.Drawing.Point(98, 78);
            this.txtReturnBookCode.Name = "txtReturnBookCode";
            this.txtReturnBookCode.Size = new System.Drawing.Size(100, 22);
            this.txtReturnBookCode.TabIndex = 6;
            // 
            // btnProcessReturn
            // 
            this.btnProcessReturn.Location = new System.Drawing.Point(73, 138);
            this.btnProcessReturn.Name = "btnProcessReturn";
            this.btnProcessReturn.Size = new System.Drawing.Size(141, 23);
            this.btnProcessReturn.TabIndex = 5;
            this.btnProcessReturn.Text = "Process Return";
            this.btnProcessReturn.UseVisualStyleBackColor = true;
            this.btnProcessReturn.Click += new System.EventHandler(this.btnProcessReturn_Click);
            // 
            // groupBoxBookInfo
            // 
            this.groupBoxBookInfo.Controls.Add(this.txtBookQuantity);
            this.groupBoxBookInfo.Controls.Add(this.txtBookAuthor);
            this.groupBoxBookInfo.Controls.Add(this.txtBookTitle);
            this.groupBoxBookInfo.Controls.Add(this.txtBookCode);
            this.groupBoxBookInfo.Controls.Add(this.label8);
            this.groupBoxBookInfo.Controls.Add(this.label7);
            this.groupBoxBookInfo.Controls.Add(this.label6);
            this.groupBoxBookInfo.Controls.Add(this.label5);
            this.groupBoxBookInfo.Location = new System.Drawing.Point(8, 4);
            this.groupBoxBookInfo.Name = "groupBoxBookInfo";
            this.groupBoxBookInfo.Size = new System.Drawing.Size(296, 172);
            this.groupBoxBookInfo.TabIndex = 0;
            this.groupBoxBookInfo.TabStop = false;
            this.groupBoxBookInfo.Text = "Book Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Book Code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Title:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Author:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Quantity:";
            // 
            // txtBookCode
            // 
            this.txtBookCode.Location = new System.Drawing.Point(117, 33);
            this.txtBookCode.Name = "txtBookCode";
            this.txtBookCode.Size = new System.Drawing.Size(100, 22);
            this.txtBookCode.TabIndex = 4;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(117, 62);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(100, 22);
            this.txtBookTitle.TabIndex = 5;
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Location = new System.Drawing.Point(117, 94);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(100, 22);
            this.txtBookAuthor.TabIndex = 6;
            // 
            // txtBookQuantity
            // 
            this.txtBookQuantity.Location = new System.Drawing.Point(117, 129);
            this.txtBookQuantity.Name = "txtBookQuantity";
            this.txtBookQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtBookQuantity.TabIndex = 7;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(350, 52);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(138, 36);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "Add New Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnUpdateQty
            // 
            this.btnUpdateQty.Location = new System.Drawing.Point(350, 98);
            this.btnUpdateQty.Name = "btnUpdateQty";
            this.btnUpdateQty.Size = new System.Drawing.Size(138, 36);
            this.btnUpdateQty.TabIndex = 2;
            this.btnUpdateQty.Text = "Update Quantity";
            this.btnUpdateQty.UseVisualStyleBackColor = true;
            this.btnUpdateQty.Click += new System.EventHandler(this.btnUpdateQty_Click);
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(17, 209);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(750, 150);
            this.dgvBooks.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Welcome to the Library System!";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(290, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Today\'s Books Out Report";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(273, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(199, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Total Books Currently Borrowed:";
            // 
            // lblTotalBorrowed
            // 
            this.lblTotalBorrowed.AutoSize = true;
            this.lblTotalBorrowed.Location = new System.Drawing.Point(372, 143);
            this.lblTotalBorrowed.Name = "lblTotalBorrowed";
            this.lblTotalBorrowed.Size = new System.Drawing.Size(14, 16);
            this.lblTotalBorrowed.TabIndex = 3;
            this.lblTotalBorrowed.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(273, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(202, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "List of Currently Borrowed Books:";
            // 
            // dgvBorrowedList
            // 
            this.dgvBorrowedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowedList.Location = new System.Drawing.Point(98, 215);
            this.dgvBorrowedList.Name = "dgvBorrowedList";
            this.dgvBorrowedList.RowHeadersWidth = 51;
            this.dgvBorrowedList.RowTemplate.Height = 24;
            this.dgvBorrowedList.Size = new System.Drawing.Size(569, 150);
            this.dgvBorrowedList.TabIndex = 5;
            // 
            // groupBoxStats
            // 
            this.groupBoxStats.Controls.Add(this.lblLeastBorrowed);
            this.groupBoxStats.Controls.Add(this.lblMostBorrowed);
            this.groupBoxStats.Controls.Add(this.label15);
            this.groupBoxStats.Controls.Add(this.label14);
            this.groupBoxStats.Location = new System.Drawing.Point(4, 4);
            this.groupBoxStats.Name = "groupBoxStats";
            this.groupBoxStats.Size = new System.Drawing.Size(673, 108);
            this.groupBoxStats.TabIndex = 0;
            this.groupBoxStats.TabStop = false;
            this.groupBoxStats.Text = "System Statistics";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Most Borrowed Book:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 16);
            this.label15.TabIndex = 1;
            this.label15.Text = "Least Borrowed Book:";
            // 
            // lblMostBorrowed
            // 
            this.lblMostBorrowed.AutoSize = true;
            this.lblMostBorrowed.Location = new System.Drawing.Point(147, 39);
            this.lblMostBorrowed.Name = "lblMostBorrowed";
            this.lblMostBorrowed.Size = new System.Drawing.Size(14, 16);
            this.lblMostBorrowed.TabIndex = 2;
            this.lblMostBorrowed.Text = "n";
            // 
            // lblLeastBorrowed
            // 
            this.lblLeastBorrowed.AutoSize = true;
            this.lblLeastBorrowed.Location = new System.Drawing.Point(151, 69);
            this.lblLeastBorrowed.Name = "lblLeastBorrowed";
            this.lblLeastBorrowed.Size = new System.Drawing.Size(14, 16);
            this.lblLeastBorrowed.TabIndex = 3;
            this.lblLeastBorrowed.Text = "n";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 131);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 16);
            this.label16.TabIndex = 1;
            this.label16.Text = "Select Report Type:";
            // 
            // cmbReportType
            // 
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Location = new System.Drawing.Point(141, 128);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(172, 24);
            this.cmbReportType.TabIndex = 2;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(140, 171);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(122, 23);
            this.btnGenerateReport.TabIndex = 3;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(319, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 16);
            this.label17.TabIndex = 4;
            this.label17.Text = "Report Output:";
            // 
            // dgvReportOutput
            // 
            this.dgvReportOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportOutput.Location = new System.Drawing.Point(322, 142);
            this.dgvReportOutput.Name = "dgvReportOutput";
            this.dgvReportOutput.RowHeadersWidth = 51;
            this.dgvReportOutput.RowTemplate.Height = 24;
            this.dgvReportOutput.Size = new System.Drawing.Size(450, 257);
            this.dgvReportOutput.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "Student ID:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 98);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 16);
            this.label18.TabIndex = 6;
            this.label18.Text = "Student Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.Text = "Library Borrowing System - Main Menu";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageHome.ResumeLayout(false);
            this.tabPageHome.PerformLayout();
            this.tabPageBook.ResumeLayout(false);
            this.tabPageStudent.ResumeLayout(false);
            this.tabPageStudent.PerformLayout();
            this.groupBoxStudentInfo.ResumeLayout(false);
            this.groupBoxStudentInfo.PerformLayout();
            this.tabPageTransaction.ResumeLayout(false);
            this.tabPageReport.ResumeLayout(false);
            this.tabPageReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBannedStudents)).EndInit();
            this.groupBoxBorrow.ResumeLayout(false);
            this.groupBoxBorrow.PerformLayout();
            this.groupBoxReturn.ResumeLayout(false);
            this.groupBoxReturn.PerformLayout();
            this.groupBoxBookInfo.ResumeLayout(false);
            this.groupBoxBookInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedList)).EndInit();
            this.groupBoxStats.ResumeLayout(false);
            this.groupBoxStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.TabPage tabPageBook;
        private System.Windows.Forms.TabPage tabPageStudent;
        private System.Windows.Forms.TabPage tabPageTransaction;
        private System.Windows.Forms.TabPage tabPageReport;
        private System.Windows.Forms.GroupBox groupBoxStudentInfo;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Button btnToggleBan;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnRegisterStudent;
        private System.Windows.Forms.Label lblActiveStudents;
        private System.Windows.Forms.DataGridView dgvActiveStudents;
        private System.Windows.Forms.DataGridView dgvBannedStudents;
        private System.Windows.Forms.Label lblBannedStudents;
        private System.Windows.Forms.GroupBox groupBoxReturn;
        private System.Windows.Forms.GroupBox groupBoxBorrow;
        private System.Windows.Forms.Button btnProcessBorrow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBorrowBookCode;
        private System.Windows.Forms.TextBox txtBorrowStudentID;
        private System.Windows.Forms.Button btnProcessReturn;
        private System.Windows.Forms.TextBox txtReturnBookCode;
        private System.Windows.Forms.TextBox txtReturnStudentID;
        private System.Windows.Forms.GroupBox groupBoxBookInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.TextBox txtBookCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBookQuantity;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Button btnUpdateQty;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label lblTotalBorrowed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvBorrowedList;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBoxStats;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblLeastBorrowed;
        private System.Windows.Forms.Label lblMostBorrowed;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvReportOutput;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
    }
}

