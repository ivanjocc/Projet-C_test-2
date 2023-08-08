using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Travail
{
    public partial class AddPersonForm : Form
    {
        private AuthForm authForm;

        public AddPersonForm(AuthForm authForm)
        {
            InitializeComponent();
            this.authForm = authForm;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form with DialogResult.Cancel
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Save the person details from the textboxes and datepicker
            string name = txtFirstName.Text;
            string lastName = txtLastName.Text;
            DateTime birthDate = dtpDateOfBirth.Value;

            // Validate input if needed

            // Create a new authorized person object with the input details
            Personne newPerson = new Personne(name, lastName, birthDate);

            // Add the new authorized person to the library
            MainForm.library.AddAuthorizedPerson(newPerson);

            // Refresh the AuthForm's DataGridView to reflect the changes
            authForm.RefreshDataGridView();

            // Close the AddPersonForm
            this.Close();
        }
    }
}
