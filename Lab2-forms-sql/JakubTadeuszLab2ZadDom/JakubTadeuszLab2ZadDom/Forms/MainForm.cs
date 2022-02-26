using JakubTadeuszLab2ZadDom.Database;
using JakubTadeuszLab2ZadDom.Forms;
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
    public partial class MainForm : Form
    {
        /// <summary>
        /// Database connection repository
        /// </summary>
        private readonly Repository repository = new Repository();
        /// <summary>
        /// id of the logged employee
        /// </summary>
        public int userId;
        /// <summary>
        /// cash register amount
        /// </summary>
        Decimal cashRegisterAmount = 0;
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// refresh data on form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            string userInfo = repository.GetUserInfo(userId);
            labelUserInfo.Text = "Zalogowano jako " + userInfo;
            RefreshCashRegister();
            RefreshDataGridViewOperations();
        }

        /// <summary>
        /// refresh cash register
        /// </summary>
        private void RefreshCashRegister()
        {
            cashRegisterAmount = repository.GetCachRegisterSum();
            labelCashRegister.Text = "Stan kasy: " + cashRegisterAmount.ToString();
        }

        /// <summary>
        /// Refresh operations DataGridView
        /// </summary>
        private void RefreshDataGridViewOperations()
        {
            DataTable operations = repository.GetOperations();
            dataGridViewMain.DataSource = operations;
        }

        /// <summary>
        /// Refresh contracts DataGridView
        /// </summary>
        private void RefreshDataGridViewContracts()
        {
            DataTable contracts = repository.GetContracts();
            dataGridViewMain.DataSource = contracts;
        }

        /// <summary>
        /// Handle button to deposit money
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDepositMoney_Click(object sender, EventArgs e)
        {
            try
            {
                Decimal amount = Decimal.Parse(textBoxAmount.Text);

                repository.DepositCash(amount, userId);

                RefreshCashRegister();

                RefreshDataGridViewOperations();
            }
            catch
            {
                MessageBox.Show("Nieprawidłowa wartość!");
                textBoxAmount.Text = "";
            }
        }

        /// <summary>
        /// Handle button to withdraw money from the register
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPayoutMoney_Click(object sender, EventArgs e)
        {
            Decimal amount = Decimal.Parse(textBoxAmount.Text);
            if (amount > cashRegisterAmount)
            {
                MessageBox.Show("Zbyt niski stan kasy!");
                return;
            }

            repository.PayoutCash(amount, userId);
            RefreshCashRegister();
            RefreshDataGridViewOperations();
        }

        /// <summary>
        /// Handle button to show client operations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowOperations_Click(object sender, EventArgs e)
        {
            RefreshDataGridViewOperations();
            HideTopControls();
            buttonDepositMoney.Visible = true;
            buttonPayoutMoney.Visible = true;
            textBoxAmount.Visible = true;
        }

        /// <summary>
        /// Hide all the selected option specific controls
        /// </summary>
        private void HideTopControls()
        {
            buttonAddClient.Visible = false;
            buttonDepositMoney.Visible = false;
            buttonPayoutMoney.Visible = false;
            textBoxAmount.Visible = false;
            buttonAddContract.Visible = false;
            buttonAddDocument.Visible = false;
            buttonShowUserDetails.Visible = false;
            buttonEditClient.Visible = false;
        }

        /// <summary>
        /// Handle button to show contracts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonContracts_Click(object sender, EventArgs e)
        {
            RefreshDataGridViewContracts();
            HideTopControls();
           
        }

        /// <summary>
        /// Handle button to show clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowClients_Click(object sender, EventArgs e)
        {
            RefreshDataGridViewClients();
            HideTopControls();
            buttonAddClient.Visible = true;
            buttonAddContract.Visible = true;
            buttonShowUserDetails.Visible = true;
            buttonEditClient.Visible = true;
        }

        /// <summary>
        /// wyświetl informacje dotyczace klientów
        /// </summary>
        private void RefreshDataGridViewClients()
        {
            DataTable clients = repository.GetClients();
            dataGridViewMain.DataSource = clients;
        }

        /// <summary>
        /// Handle button to show contract templates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowDocuments_Click(object sender, EventArgs e)
        {
            RefreshDataGridViewDocuments();
            HideTopControls();
            buttonAddDocument.Visible = true;
        }

        /// <summary>
        /// Refresh contract templates DataGridView
        /// </summary>
        private void RefreshDataGridViewDocuments()
        {
            DataTable documents = repository.GetDocuments();
            dataGridViewMain.DataSource = documents;
        }

        /// <summary>
        /// Handle button to show deposits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowDeposits_Click(object sender, EventArgs e)
        {
            RefreshDataGridViewDeposits();
            HideTopControls();
        }

        /// <summary>
        /// Refresh deposits DataGridView
        /// </summary>
        private void RefreshDataGridViewDeposits()
        {
            DataTable deposits = repository.GetDeposits();
            dataGridViewMain.DataSource = deposits;
        }

        /// <summary>
        /// Handle button to show client add form dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            AddClientForm addClient = new AddClientForm();
            addClient.ShowDialog();
        }

        /// <summary>
        /// Handle button to add new contract
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddContract_Click(object sender, EventArgs e)
        {

            if(dataGridViewMain.SelectedRows.Count == 0)
            {
                MessageBox.Show("Zaznacz klienta");
            }
            int selectedClientId = (int)dataGridViewMain.SelectedRows[0].Cells["Id"].Value;
            AddContractOperationForm addContract = new AddContractOperationForm(userId, selectedClientId);
            addContract.ShowDialog();

        }

        /// <summary>
        /// Handle button to create the new contract template
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddDocument_Click(object sender, EventArgs e)
        {
            AddDocumentForm addDocument = new AddDocumentForm();
            addDocument.ShowDialog();
        }

        /// <summary>
        /// Handle button to show all the details of selected user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowUserDetails_Click(object sender, EventArgs e)
        {
            if (dataGridViewMain.SelectedRows.Count == 0)
            {
                MessageBox.Show("Zaznacz klienta");
            }
            int selectedClientId = (int)dataGridViewMain.SelectedRows[0].Cells["Id"].Value;
            ClientDetailsForm clientDetails = new ClientDetailsForm(userId, selectedClientId);
            clientDetails.ShowDialog();
        }

        /// <summary>
        /// Handle button to open the client edit form dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewMain.SelectedRows.Count == 0)
            {
                MessageBox.Show("Zaznacz klienta");
            }
            int selectedClientId = (int)dataGridViewMain.SelectedRows[0].Cells["Id"].Value;
            EditClientForm editClientForm = new EditClientForm(selectedClientId);
            editClientForm.ShowDialog();
        }
    }
}
