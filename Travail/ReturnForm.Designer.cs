namespace Travail
{
    partial class ReturnForm
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
            btnReturnBook = new Button();
            label2 = new Label();
            btnBackToMainForm = new Button();
            dgvBorrowedBooks = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).BeginInit();
            SuspendLayout();
            // 
            // btnReturnBook
            // 
            btnReturnBook.Location = new Point(56, 251);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new Size(132, 50);
            btnReturnBook.TabIndex = 3;
            btnReturnBook.Text = "Return Book";
            btnReturnBook.UseVisualStyleBackColor = true;
            btnReturnBook.Click += btnReturnBook_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 31);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 11;
            label2.Text = "Borrowed Books";
            // 
            // btnBackToMainForm
            // 
            btnBackToMainForm.Location = new Point(337, 251);
            btnBackToMainForm.Name = "btnBackToMainForm";
            btnBackToMainForm.Size = new Size(132, 50);
            btnBackToMainForm.TabIndex = 4;
            btnBackToMainForm.Text = "Back MainForm";
            btnBackToMainForm.UseVisualStyleBackColor = true;
            btnBackToMainForm.Click += btnBackToMainForm_Click;
            // 
            // dgvBorrowedBooks
            // 
            dgvBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowedBooks.Location = new Point(56, 49);
            dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            dgvBorrowedBooks.RowTemplate.Height = 25;
            dgvBorrowedBooks.Size = new Size(413, 150);
            dgvBorrowedBooks.TabIndex = 2;
            // 
            // ReturnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvBorrowedBooks);
            Controls.Add(btnBackToMainForm);
            Controls.Add(btnReturnBook);
            Controls.Add(label2);
            Name = "ReturnForm";
            Text = "Return Form";
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReturnBook;
        private Label label2;
        private Button btnBackToMainForm;
        private DataGridView dgvBorrowedBooks;
    }
}