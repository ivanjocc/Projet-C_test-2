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
    public partial class AuthForm : Form
    {
        public AuthForm()
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

        private void btnAddAuthorizedPerson_Click(object sender, EventArgs e)
        {
            // Show the AddPersonForm with the MainForm as the owner
            AddPersonForm addPersonForm = new AddPersonForm(this);
            addPersonForm.ShowDialog();

            // Refresh the DataGridView after adding a new authorized person
            RefreshDataGridView();
        }

        private void btnDeleteAuthorizedPerson_Click(object sender, EventArgs e)
        {
            if (dgvAuthorizedPeople.SelectedRows.Count > 0)
            {
                dgvAuthorizedPeople.Rows.RemoveAt(dgvAuthorizedPeople.SelectedRows[0].Index);
            }
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            // Load the list of authorized persons into the DataGridView
            //dgvAuthorizedPeople.DataSource = MainForm.library.GetAuthorizedPeople();

            // Load the list of authorized persons into the DataGridView
            RefreshDataGridView();
        }

        public void RefreshDataGridView()
        {
            // Refresh the DataGridView with the latest list of authorized persons
            dgvAuthorizedPeople.DataSource = MainForm.library.GetAuthorizedPeople();
        }
    }
}
