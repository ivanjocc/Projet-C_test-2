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
    public partial class AddBookForm : Form
    {
        private BookForm bookForm;

        public AddBookForm(BookForm bookForm)
        {
            InitializeComponent();
            this.bookForm = bookForm;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Save the book details from the textboxes and datepicker
            string title = txtBookName.Text;
            string author = txtAuthorName.Text;
            DateTime publicationDate = dtpPublicationDate.Value;

            // Validate input if needed

            // Create a new book object with the input details
            Livre newBook = new Livre(title, author, publicationDate);

            // Add the new book to the library
            MainForm.library.AddBook(newBook);

            // Refresh the BookForm's DataGridView to reflect the changes
            bookForm.RefreshDataGridView();

            // Close the AddBookForm
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form with DialogResult.Cancel
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
