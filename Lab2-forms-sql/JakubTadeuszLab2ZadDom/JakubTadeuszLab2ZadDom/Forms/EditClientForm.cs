using JakubTadeuszLab2ZadDom.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JakubTadeuszLab2ZadDom.Forms
{
    public partial class EditClientForm : Form
    {
        /// <summary> 
        /// Database connection repository
        /// </summary>
        Repository repository = new Repository();
        /// <summary>
        /// Id of the client to edit
        /// </summary>
        int clientId;
        public EditClientForm(int selectedClientId)
        {
            InitializeComponent();
            clientId = selectedClientId;
        }

        /// <summary>
        /// Load info about client to the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditClientForm_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = repository.GetClient(clientId);
            textBoxFirstName.Text = (string)reader["FirstName"];
            textBoxLastName.Text = (string)reader["LastName"];
            textBoxPESEL.Text = ((Int64)reader["PESEL"]).ToString();
            textBoxStreet.Text = (string)reader["Street"];
            textBoxFlatNumber.Text = (string)reader["FlatNumber"];
            textBoxCity.Text = (string)reader["City"];
            textBoxPostalCode.Text = ((int)reader["PostalCode"]).ToString();
        }

        /// <summary>
        /// handle button to update client data in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditClient_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            long PESEL = Convert.ToInt64(textBoxPESEL.Text);
            string street = textBoxStreet.Text;
            string flatNumber = textBoxFlatNumber.Text;
            string city = textBoxCity.Text;
            int postalCode = Convert.ToInt32(textBoxPostalCode.Text);
            repository.EditClient(clientId, firstName, lastName, PESEL, street, flatNumber, city, postalCode);
            Close();
        }
    }
}
