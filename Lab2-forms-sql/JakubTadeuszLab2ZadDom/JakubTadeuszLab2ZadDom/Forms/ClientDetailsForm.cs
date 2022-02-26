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
    public partial class ClientDetailsForm : Form
    {
        /// <summary> 
        /// Database connection repository
        /// </summary>
        Repository repository = new Repository();

        private const int CALL = 2;
        private const int SMS = 1;
        private const int EMAIL = 3;

        /// <summary>
        /// selected contract id
        /// </summary>
        int contractId;
        /// <summary>
        /// employee id
        /// </summary>
        public int UserId { get; }
        /// <summary>
        /// selected client id
        /// </summary>
        public int SelectedClientId { get; }
        public ClientDetailsForm()
        {
            InitializeComponent();
        }

        public ClientDetailsForm(int userId, int selectedClientId)
        {
            InitializeComponent();
            UserId = userId;
            SelectedClientId = selectedClientId;
        }

        /// <summary>
        /// Loads all the client info and data about the contracts, client contacts and deposits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientDetailsForm_Load(object sender, EventArgs e)
        {
            labelClientInfo.Text = "Imię, nazwisko: " + repository.GetClientInfo(SelectedClientId);
            dataGridViewContracts.DataSource = repository.GetClientActiveContracts(SelectedClientId);
            dataGridViewDeposits.DataSource = repository.GetClientDeposits(SelectedClientId);
            refreshContactHistory();
        }

        /// <summary>
        /// Refreshes info about contact history
        /// </summary>
        private void refreshContactHistory()
        {
            
            dataGridViewContactHistory.DataSource = repository.GetClientContacts(contractId, SelectedClientId);
        }

        /// <summary>
        /// Handle button about phone contact with client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCall_Click(object sender, EventArgs e)
        {
            repository.AddClientContact(contractId, SelectedClientId, UserId, CALL);
            refreshContactHistory();
        }

        /// <summary>
        /// Handle button about SMS contact with client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSMS_Click(object sender, EventArgs e)
        {
            repository.AddClientContact(contractId, SelectedClientId, UserId, SMS);
            refreshContactHistory();
        }

        /// <summary>
        /// Handle button about email contact with client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEmail_Click(object sender, EventArgs e)
        {
            repository.AddClientContact(contractId, SelectedClientId, UserId, EMAIL);
            refreshContactHistory();
        }

        /// <summary>
        /// After cell click, refresh selected contact history
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewContracts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            contractId = (int)dataGridViewContracts.SelectedRows[0].Cells["Id"].Value;
            refreshContactHistory();
        }

        /// <summary>
        /// Handle button to add client payment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPay_Click(object sender, EventArgs e)
        {
            Decimal paidValue = numericUpDownPaidAmount.Value;

            repository.AddContractOperation(UserId, SelectedClientId, contractId, paidValue);
            dataGridViewContracts.DataSource = repository.GetClientActiveContracts(SelectedClientId);
        }

        /// <summary>
        /// Refresh all DataGridViews
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientDetailsForm_Enter(object sender, EventArgs e)
        {
            refreshContactHistory();
            dataGridViewContracts.DataSource = repository.GetClientActiveContracts(SelectedClientId);
            dataGridViewDeposits.DataSource = repository.GetClientDeposits(SelectedClientId);
        }
    }
}
