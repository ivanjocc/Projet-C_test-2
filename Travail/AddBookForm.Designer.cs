namespace Travail
{
    partial class AddBookForm
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
            btnCancel = new Button();
            btnOK = new Button();
            dtpPublicationDate = new DateTimePicker();
            label3 = new Label();
            txtAuthorName = new TextBox();
            label2 = new Label();
            txtBookName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(244, 240);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(101, 50);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(82, 240);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(101, 50);
            btnOK.TabIndex = 4;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // dtpPublicationDate
            // 
            dtpPublicationDate.Location = new Point(145, 163);
            dtpPublicationDate.Name = "dtpPublicationDate";
            dtpPublicationDate.Size = new Size(200, 23);
            dtpPublicationDate.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 171);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 11;
            label3.Text = "Publication Date";
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(145, 112);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(200, 23);
            txtAuthorName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 120);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 12;
            label2.Text = "Author";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(145, 59);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(200, 23);
            txtBookName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 67);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 13;
            label1.Text = "Book Name";
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(dtpPublicationDate);
            Controls.Add(label3);
            Controls.Add(txtAuthorName);
            Controls.Add(label2);
            Controls.Add(txtBookName);
            Controls.Add(label1);
            Name = "AddBookForm";
            Text = "AddBookForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnOK;
        private DateTimePicker dtpPublicationDate;
        private Label label3;
        private TextBox txtAuthorName;
        private Label label2;
        private TextBox txtBookName;
        private Label label1;
    }
}