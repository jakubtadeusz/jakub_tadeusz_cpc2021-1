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
    public partial class AddContractOperationForm : Form
    {
        /// <summary>
        /// Database connection repository
        /// </summary>
        readonly Repository repository = new Repository();
        /// <summary>
        /// Id of selected client
        /// </summary>
        private int selectedClientId;
        /// <summary>
        /// Id of employee
        /// </summary>
        private int employeeId;
        /// <summary>
        /// Row with the choosen contract template
        /// </summary>
        DataGridViewRow selectedRow;

        public AddContractOperationForm(int employeeId, int selectedClientId)
        {
            InitializeComponent();
            this.selectedClientId = selectedClientId;
            this.employeeId = employeeId;
        }

        /// <summary>
        /// Loads client info and contract templates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContractForm_Load(object sender, EventArgs e)
        {
            string clientInfo = repository.GetClientInfo(selectedClientId);
            labelClientInfo.Text = "Imię, nazwisko: " + clientInfo;
            dataGridViewContractAddForm.DataSource = repository.GetDocuments();
        }

        /// <summary>
        /// Handle button to add new contract
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNext_Click(object sender, EventArgs e)   
        {
            panelContractInfo.Visible = false;

            if(selectedRow != null)
            {
                int contractTemplateId = (int)selectedRow.Cells["Id"].Value;
                bool depositRequired = (bool)selectedRow.Cells["Wymagany depozyt"].Value;

                DateTime startDate = dateTimePickerDateStart.Value;
                int contractLength = Decimal.ToInt32(numericUpDownContractLength.Value);
                Decimal contractAmount = numericUpDownContractAmount.Value;

                Contract contract = new Contract(selectedClientId, employeeId, contractTemplateId, startDate, contractLength, contractAmount);

                if (depositRequired)
                {
                    AddDepositForm addDepositForm = new AddDepositForm(employeeId, selectedClientId, contract);
                    addDepositForm.ShowDialog();
                }
                else
                {
                    repository.AddContract(contract);
                }
                Close();
            }
            else
            {
                MessageBox.Show("Wybierz umowę");
            }
        }

        /// <summary>
        /// Set contract template after click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewContractAddForm_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewContractAddForm.SelectedRows.Count != 0)
            {
                selectedRow = dataGridViewContractAddForm.SelectedRows[0];
                try
                {
                    numericUpDownContractLength.Minimum = (int)selectedRow.Cells["Minimalna długość"].Value;
                    numericUpDownContractLength.Maximum = (int)selectedRow.Cells["Maksymalna długość"].Value;
                }
                catch
                {

                }
            }
        }
    }
}
