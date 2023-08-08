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
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        private void btnBackToMainForm_Click(object sender, EventArgs e)
        {
            // Create a new instance of MainForm and show it
            MainForm mainForm = new MainForm();
            mainForm.Show();

            // Close the current form (the current form will be closed when the user goes back to the MainForm)
            this.Close();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            // Show the AddBookForm with the MainForm as the owner
            AddBookForm addBookForm = new AddBookForm(this);
            addBookForm.ShowDialog();

            // Refresh the DataGridView after adding a new book
            RefreshDataGridView();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                dgvBooks.Rows.RemoveAt(dgvBooks.SelectedRows[0].Index);
            }
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            // Load the list of available books into the DataGridView
            //dgvBooks.DataSource = MainForm.library.GetAvailableBooks();

            // Load the list of available books into the DataGridView
            RefreshDataGridView();
        }

        public void RefreshDataGridView()
        {
            // Refresh the DataGridView with the latest list of available books
            dgvBooks.DataSource = MainForm.library.GetAvailableBooks();
        }
    }
}
