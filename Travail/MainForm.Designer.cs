namespace Travail
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnManageBooks = new Button();
            btnManageAuthorizedPersons = new Button();
            btnBorrow = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnManageBooks
            // 
            btnManageBooks.Location = new Point(91, 55);
            btnManageBooks.Name = "btnManageBooks";
            btnManageBooks.Size = new Size(150, 50);
            btnManageBooks.TabIndex = 1;
            btnManageBooks.Text = "Manage Book";
            btnManageBooks.UseVisualStyleBackColor = true;
            btnManageBooks.Click += btnManageBooks_Click;
            // 
            // btnManageAuthorizedPersons
            // 
            btnManageAuthorizedPersons.Location = new Point(287, 55);
            btnManageAuthorizedPersons.Name = "btnManageAuthorizedPersons";
            btnManageAuthorizedPersons.Size = new Size(150, 50);
            btnManageAuthorizedPersons.TabIndex = 2;
            btnManageAuthorizedPersons.Text = "Manage Auth Persons";
            btnManageAuthorizedPersons.UseVisualStyleBackColor = true;
            btnManageAuthorizedPersons.Click += btnManageAuthorizedPersons_Click;
            // 
            // btnBorrow
            // 
            btnBorrow.Location = new Point(91, 145);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(150, 50);
            btnBorrow.TabIndex = 3;
            btnBorrow.Text = "Borrow Book";
            btnBorrow.UseVisualStyleBackColor = true;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.IndianRed;
            btnExit.Location = new Point(189, 254);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 50);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnBorrow);
            Controls.Add(btnManageAuthorizedPersons);
            Controls.Add(btnManageBooks);
            Name = "MainForm";
            Text = "Main Form";
            ResumeLayout(false);
        }

        #endregion

        private Button btnManageBooks;
        private Button btnManageAuthorizedPersons;
        private Button btnBorrow;
        private Button btnExit;
    }
}