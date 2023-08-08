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
    public partial class ReturnForm : Form
    {
        public ReturnForm()
        {
            InitializeComponent();
            dgvBorrowedBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnBackToMainForm_Click(object sender, EventArgs e)
        {
            // Create a new instance of MainForm and show it
            MainForm mainForm = new MainForm();
            mainForm.Show();

            // Close the current form (the current form will be closed when the user goes back to the MainForm)
            this.Close();
        }

        // Declare a delegate for handling the book returned event
        public delegate void BookReturnedEventHandler(Livre book);

        // Declare the event for book returned
        public event BookReturnedEventHandler? BookReturned;

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            //if (dgvBorrowedBooks.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow selectedRow = dgvBorrowedBooks.SelectedRows[0];
            //    Livre selectedBook = ((KeyValuePair<Livre, Personne>)selectedRow.DataBoundItem).Key;

            //    // Return the selected borrowed book using MainForm.library
            //    if (MainForm.library.ReturnBook(selectedBook))
            //    {
            //        // Refresh the DataGridView after returning the book
            //        dgvBorrowedBooks.DataSource = new BindingSource(MainForm.library.GetBorrowedBooks(), null);
            //        // Update Available Books DataGridView in MainForm (if MainForm is kept open)
            //    }
            //    else
            //    {
            //        MessageBox.Show("Unable to return the selected book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please select a borrowed book to return.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            if (dgvBorrowedBooks.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvBorrowedBooks.SelectedRows[0];
                Livre selectedBook = new Livre
                {
                    Name = selectedRow.Cells[0].Value?.ToString() ?? "",
                    Author = selectedRow.Cells[1].Value?.ToString() ?? "",
                    PublicationDate = DateTime.TryParse(selectedRow.Cells[2].Value?.ToString(), out DateTime publicationDate) ? publicationDate : DateTime.Now
                };

                // Return the selected book
                if (MainForm.library.ReturnBook(selectedBook))
                {
                    // Remove the returned book from the ReturnForm's DataGridView
                    dgvBorrowedBooks.Rows.Remove(selectedRow);

                    // Remove the returned book from the MainForm's borrowedBooks list
                    //MainForm.Instance.RemoveReturnedBook(selectedBook);
                }
                else
                {
                    MessageBox.Show("Unable to return the selected book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a book to return.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Method to raise the BookReturned event
        protected virtual void OnBookReturned(Livre book)
        {
            BookReturned?.Invoke(book);
        }

        // Method to update the DataGridView in ReturnForm
        public void UpdateReturnDataGridView(Livre borrowedBook)
        {
            // Add the borrowed book back to the DataGridView
            dgvBorrowedBooks.Rows.Add(borrowedBook.Name, borrowedBook.Author, borrowedBook.PublicationDate);
        }
    }
}
