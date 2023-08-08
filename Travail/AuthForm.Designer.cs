namespace Travail
{
    partial class AuthForm
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
            label4 = new Label();
            btnDeleteAuthorizedPerson = new Button();
            btnAddAuthorizedPerson = new Button();
            btnBackToMainForm = new Button();
            dgvAuthorizedPeople = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAuthorizedPeople).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 46);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 9;
            label4.Text = "List of Auth Persons";
            // 
            // btnDeleteAuthorizedPerson
            // 
            btnDeleteAuthorizedPerson.Location = new Point(413, 251);
            btnDeleteAuthorizedPerson.Name = "btnDeleteAuthorizedPerson";
            btnDeleteAuthorizedPerson.Size = new Size(132, 50);
            btnDeleteAuthorizedPerson.TabIndex = 3;
            btnDeleteAuthorizedPerson.Text = "Delete Person";
            btnDeleteAuthorizedPerson.UseVisualStyleBackColor = true;
            btnDeleteAuthorizedPerson.Click += btnDeleteAuthorizedPerson_Click;
            // 
            // btnAddAuthorizedPerson
            // 
            btnAddAuthorizedPerson.Location = new Point(70, 251);
            btnAddAuthorizedPerson.Name = "btnAddAuthorizedPerson";
            btnAddAuthorizedPerson.Size = new Size(132, 50);
            btnAddAuthorizedPerson.TabIndex = 2;
            btnAddAuthorizedPerson.Text = "Add Person";
            btnAddAuthorizedPerson.UseVisualStyleBackColor = true;
            btnAddAuthorizedPerson.Click += btnAddAuthorizedPerson_Click;
            // 
            // btnBackToMainForm
            // 
            btnBackToMainForm.Location = new Point(590, 116);
            btnBackToMainForm.Name = "btnBackToMainForm";
            btnBackToMainForm.Size = new Size(132, 50);
            btnBackToMainForm.TabIndex = 4;
            btnBackToMainForm.Text = "Back MainForm";
            btnBackToMainForm.UseVisualStyleBackColor = true;
            btnBackToMainForm.Click += btnBackToMainForm_Click;
            // 
            // dgvAuthorizedPeople
            // 
            dgvAuthorizedPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuthorizedPeople.Location = new Point(70, 64);
            dgvAuthorizedPeople.Name = "dgvAuthorizedPeople";
            dgvAuthorizedPeople.RowTemplate.Height = 25;
            dgvAuthorizedPeople.Size = new Size(475, 161);
            dgvAuthorizedPeople.TabIndex = 10;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvAuthorizedPeople);
            Controls.Add(label4);
            Controls.Add(btnBackToMainForm);
            Controls.Add(btnDeleteAuthorizedPerson);
            Controls.Add(btnAddAuthorizedPerson);
            Name = "AuthForm";
            Text = "Auth Form";
            Load += AuthForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAuthorizedPeople).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button btnDeleteAuthorizedPerson;
        private Button btnAddAuthorizedPerson;
        private Button btnBackToMainForm;
        private DataGridView dgvAuthorizedPeople;
    }
}