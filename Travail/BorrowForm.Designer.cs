namespace Travail
{
    partial class BorrowForm
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
            btnBackToMainForm = new Button();
            label3 = new Label();
            dgvAvailableBooks = new DataGridView();
            btnBorrow = new Button();
            dgvBorrowedBooks = new DataGridView();
            label1 = new Label();
            btnReturn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).BeginInit();
            SuspendLayout();
            // 
            // btnBackToMainForm
            // 
            btnBackToMainForm.Location = new Point(312, 313);
            btnBackToMainForm.Name = "btnBackToMainForm";
            btnBackToMainForm.Size = new Size(132, 50);
            btnBackToMainForm.TabIndex = 5;
            btnBackToMainForm.Text = "Back MainForm";
            btnBackToMainForm.UseVisualStyleBackColor = true;
            btnBackToMainForm.Click += btnBackToMainForm_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 43);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Books";
            // 
            // dgvAvailableBooks
            // 
            dgvAvailableBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailableBooks.Location = new Point(71, 61);
            dgvAvailableBooks.Name = "dgvAvailableBooks";
            dgvAvailableBooks.RowTemplate.Height = 25;
            dgvAvailableBooks.Size = new Size(290, 155);
            dgvAvailableBooks.TabIndex = 6;
            // 
            // btnBorrow
            // 
            btnBorrow.Location = new Point(71, 246);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(132, 50);
            btnBorrow.TabIndex = 7;
            btnBorrow.Text = "Borrow";
            btnBorrow.UseVisualStyleBackColor = true;
            btnBorrow.Click += btnBorrow_Click_1;
            // 
            // dgvBorrowedBooks
            // 
            dgvBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowedBooks.Location = new Point(395, 61);
            dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            dgvBorrowedBooks.RowTemplate.Height = 25;
            dgvBorrowedBooks.Size = new Size(278, 150);
            dgvBorrowedBooks.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(395, 43);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 9;
            label1.Text = "Borrowed Books";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(534, 246);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(139, 50);
            btnReturn.TabIndex = 10;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // BorrowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReturn);
            Controls.Add(label1);
            Controls.Add(dgvBorrowedBooks);
            Controls.Add(btnBorrow);
            Controls.Add(dgvAvailableBooks);
            Controls.Add(btnBackToMainForm);
            Controls.Add(label3);
            Name = "BorrowForm";
            Text = "Borrow Form";
            ((System.ComponentModel.ISupportInitialize)dgvAvailableBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBackToMainForm;
        private Label label3;
        private DataGridView dgvAvailableBooks;
        private Button btnBorrow;
        private DataGridView dgvBorrowedBooks;
        private Label label1;
        private Button btnReturn;
    }
}