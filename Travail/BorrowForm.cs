using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travail
{
    public partial class BorrowForm : Form
    {

        // List to store available books
        private List<Livre> availableBooks = new List<Livre>();
        // List to store borrowed books
        private List<Livre> borrowedBooks = new List<Livre>();

        public BorrowForm()
        {
            InitializeComponent();
            LoadData();
            //dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadData()
        {
            // Load available books
            dgvAvailableBooks.Rows.Clear();
            foreach (Livre book in availableBooks)
            {
                dgvAvailableBooks.Rows.Add(book.Name, book.Author, book.PublicationDate);
            }

            // Load borrowed books
            dgvBorrowedBooks.Rows.Clear();
            foreach (Livre book in borrowedBooks)
            {
                dgvBorrowedBooks.Rows.Add(book.Name, book.Author, book.PublicationDate);
            }
        }

        private void btnBackToMainForm_Click(object sender, EventArgs e)
        {
            // Create a new instance of MainForm and show it
            MainForm mainForm = new MainForm();
            mainForm.Show();

            // Close the current form (the current form will be closed when the user goes back to the MainForm)
            this.Close();
        }

        //private void BorrowForm_Load(object sender, EventArgs e)
        //{
        //    // Load the list of available books into the DataGridView
        //    RefreshDataGridView();

        //    // Assume you have a list of available books and borrowed books
        //    // For demonstration purposes, let's initialize them here.
        //    availableBooks = new List<Livre>
        //{
        //    new Livre { Name = "Book 1", Author = "Author 1", PublicationDate = new DateTime(2020, 1, 1) },
        //    new Livre { Name = "Book 2", Author = "Author 2", PublicationDate = new DateTime(2019, 5, 15) },
        //    new Livre { Name = "Book 3", Author = "Author 3", PublicationDate = new DateTime(2021, 10, 30) }
        //};

        //    LoadData();
        //}

        public void RefreshDataGridView()
        {
            // Refresh the DataGridView with the latest list of available books
            dgvAvailableBooks.DataSource = MainForm.library.GetAvailableBooks();
        }

        // Declare a delegate for handling the book borrowed event
        public delegate void BookBorrowedEventHandler(Livre book);

        // Declare the event for book borrowed
        public event BookBorrowedEventHandler? BookBorrowed;

        private void btnBorrow_Click_1(object sender, EventArgs e)
        {
            //if (dgvBooks.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow selectedRow = dgvBooks.SelectedRows[0];
            //    Livre selectedBook = (Livre)selectedRow.DataBoundItem;

            //    // Borrow the selected book (passing null for AuthorizedPerson as we are not selecting one)
            //    if (MainForm.library.BorrowBook(selectedBook, null)) // Pass null for person
            //    {
            //        // Refresh the DataGridView after borrowing the book
            //        RefreshDataGridView();

            //        // Close the BorrowForm after borrowing the book
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Unable to borrow the selected book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please select a book to borrow.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            if (dgvAvailableBooks.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvAvailableBooks.SelectedRows[0];
                Livre selectedBook = availableBooks[selectedRow.Index];

                // Borrow the selected book
                if (BorrowBook(selectedBook))
                {
                    LoadData(); // Update DataGridViews
                }
                else
                {
                    MessageBox.Show("The selected book couldn't be borrowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a book to borrow.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Method to raise the BookBorrowed event
        protected virtual void OnBookBorrowed(Livre book)
        {
            BookBorrowed?.Invoke(book);
        }

        // Method to update the DataGridView in BorrowForm
        public void UpdateBorrowDataGridView(Livre returnedBook)
        {
            // Add the returned book back to the DataGridView
            dgvAvailableBooks.Rows.Add(returnedBook.Name, returnedBook.Author, returnedBook.PublicationDate);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dgvBorrowedBooks.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvBorrowedBooks.SelectedRows[0];
                Livre selectedBook = borrowedBooks[selectedRow.Index];

                // Return the selected book
                if (ReturnBook(selectedBook))
                {
                    LoadData(); // Update DataGridViews
                }
                else
                {
                    MessageBox.Show("The selected book couldn't be returned.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a book to return.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Method to borrow a book
        private bool BorrowBook(Livre book)
        {
            // Here, we implement the logic to borrow a book.
            // We can use the list of available books and borrowed books to manage the borrowing process.
            // Let's assume a book can be borrowed if it's in the list of available books.
            // After borrowing the book, we remove it from the list of available books and add it to the list of borrowed books.

            if (availableBooks.Contains(book))
            {
                availableBooks.Remove(book);
                borrowedBooks.Add(book);
                return true;
            }

            return false; // The book couldn't be borrowed (not available).
        }

        // Method to return a book
        private bool ReturnBook(Livre book)
        {
            // Here, we implement the logic to return a book.
            // Let's assume a book can be returned if it's in the list of borrowed books.
            // After returning the book, we remove it from the list of borrowed books and add it to the list of available books.

            if (borrowedBooks.Contains(book))
            {
                borrowedBooks.Remove(book);
                availableBooks.Add(book);
                return true;
            }

            return false; // The book couldn't be returned (not borrowed).
        }
    }
}
