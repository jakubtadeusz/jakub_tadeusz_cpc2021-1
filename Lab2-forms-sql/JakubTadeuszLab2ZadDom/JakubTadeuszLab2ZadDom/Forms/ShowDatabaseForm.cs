using JakubTadeuszLab2ZadDom.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JakubTadeuszLab2ZadDom
{
    public partial class ShowDatabaseForm : Form
    {
        /// <summary> 
        /// Database connection repository
        /// </summary>
        Repository repository = new Repository();
        public ShowDatabaseForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handle button to show all the users
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUsers_Click(object sender, EventArgs e)
        {
            dataGridViewTable.DataSource = repository.GetAllFromTable("Users");
        }

        /// <summary>
        /// Handle button to show all the Employees
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            dataGridViewTable.DataSource = repository.GetAllFromTable("Employees");
        }

        /// <summary>
        /// Handle button to show all the Clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClients_Click(object sender, EventArgs e)
        {
            dataGridViewTable.DataSource = repository.GetAllFromTable("Clients");
        }

        /// <summary>
        /// Handle button to show all the (Document) contract templates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonContractTemplates_Click(object sender, EventArgs e)
        {
            dataGridViewTable.DataSource = repository.GetAllFromTable("ContractTemplates");
        }

        /// <summary>
        /// Handle button to show all the contracts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonContracts_Click(object sender, EventArgs e)
        {
            dataGridViewTable.DataSource = repository.GetAllFromTable("Contracts");
        }

        /// <summary>
        /// Handle button to show all the contract operations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonContractOperations_Click(object sender, EventArgs e)
        {
            dataGridViewTable.DataSource = repository.GetAllFromTable("ContractOperations");
        }

        /// <summary>
        /// Handle button to show all the client contact history
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonContactHistory_Click(object sender, EventArgs e)
        {
            dataGridViewTable.DataSource = repository.GetAllFromTable("ClientContactHistory");
        }

        /// <summary>
        /// Handle button to show all the contact types
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonContactTypes_Click(object sender, EventArgs e)
        {
            dataGridViewTable.DataSource = repository.GetAllFromTable("ContactTypes");
        }

        /// <summary>
        /// Handle button to show all the deposits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeposits_Click(object sender, EventArgs e)
        {
            dataGridViewTable.DataSource = repository.GetAllFromTable("Deposits");
        }
    }
}
