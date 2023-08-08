namespace Travail
{
    public partial class MainForm : Form
    {
        private Biblioteque biblioteque = new Biblioteque();

        private List<Livre> borrowedBooksList = new List<Livre>();

        // Make the library variable static
        public static Biblioteque library = new Biblioteque();

        // Declare a list to store borrowed books
        private List<Livre> borrowedBooks = new List<Livre>();

        // Method to add a borrowed book to the list and update BorrowForm and ReturnForm
        public void AddBorrowedBook(Livre book)
        {
            borrowedBooks.Add(book);
            //borrowForm.UpdateBorrowDataGridView(book);
            //returnForm.UpdateReturnDataGridView(book);
        }

        // Method to remove a returned book from the list and update BorrowForm and ReturnForm
        public void RemoveReturnedBook(Livre book)
        {
            borrowedBooks.Remove(book);
            //borrowForm.UpdateBorrowDataGridView(book);
            //returnForm.UpdateReturnDataGridView(book);
        }

        public MainForm()
        {
            InitializeComponent();

            // Initialize the BookForm and AuthForm instances
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            // Show the BookForm with the MainForm as the owner
            BookForm bookForm = new BookForm();
            bookForm.ShowDialog(this);
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            // Create a new instance of BorrowForm and show it
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.ShowDialog();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // Create a new instance of ReturnForm and show it
            ReturnForm returnForm = new ReturnForm();
            returnForm.Show();
        }

        private void btnManageAuthorizedPersons_Click(object sender, EventArgs e)
        {
            // Show the AuthForm with the MainForm as the owner
            AuthForm authForm = new AuthForm();
            authForm.ShowDialog(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //public void UpdateBorrowedBooksDataGridView(Livre borrowedBook, Livre returnedBook)
        //{
        //    // Add the borrowed book to the DataGridView in ReturnForm
        //    if (borrowedBook != null)
        //    {
        //        ReturnForm form = Application.OpenForms[nameof(ReturnForm)] as ReturnForm;
        //        form?.dgvBorrowedBooks.Rows.Add(borrowedBook.Title, borrowedBook.Author, borrowedBook.PublicationDate.ToShortDateString());
        //    }

        //    // Remove the returned book from the DataGridView in ReturnForm and add it to the DataGridView in BorrowForm
        //    if (returnedBook != null)
        //    {
        //        ReturnForm returnForm = Application.OpenForms[nameof(ReturnForm)] as ReturnForm;
        //        if (returnForm != null)
        //        {
        //            foreach (DataGridViewRow row in returnForm.dgvBorrowedBooks.Rows)
        //            {
        //                if (row.Cells[0].Value?.ToString() == returnedBook.Name)
        //                {
        //                    returnForm.dgvBorrowedBooks.Rows.Remove(row);
        //                    break;
        //                }
        //            }
        //        }

        //        BorrowForm borrowForm = Application.OpenForms[nameof(BorrowForm)] as BorrowForm;
        //        borrowForm?.dgvBooks.Rows.Add(returnedBook.Title, returnedBook.Author, returnedBook.PublicationDate.ToShortDateString());
        //    }
        //}
    }
}