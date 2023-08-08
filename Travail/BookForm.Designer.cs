namespace Travail
{
    partial class BookForm
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
            dgvBooks = new DataGridView();
            btnAddBook = new Button();
            btnDeleteBook = new Button();
            label4 = new Label();
            btnBackToMainForm = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(65, 72);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowTemplate.Height = 25;
            dgvBooks.Size = new Size(475, 150);
            dgvBooks.TabIndex = 1;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(65, 259);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(132, 50);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(408, 259);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(132, 50);
            btnDeleteBook.TabIndex = 3;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 54);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 4;
            label4.Text = "List of Books";
            // 
            // btnBackToMainForm
            // 
            btnBackToMainForm.Location = new Point(580, 125);
            btnBackToMainForm.Name = "btnBackToMainForm";
            btnBackToMainForm.Size = new Size(132, 50);
            btnBackToMainForm.TabIndex = 4;
            btnBackToMainForm.Text = "Back MainForm";
            btnBackToMainForm.UseVisualStyleBackColor = true;
            btnBackToMainForm.Click += btnBackToMainForm_Click;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBackToMainForm);
            Controls.Add(label4);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnAddBook);
            Controls.Add(dgvBooks);
            Name = "BookForm";
            Text = "Book Form";
            Load += BookForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBooks;
        private Button btnAddBook;
        private Button btnDeleteBook;
        private Label label4;
        private Button btnBackToMainForm;
    }
}