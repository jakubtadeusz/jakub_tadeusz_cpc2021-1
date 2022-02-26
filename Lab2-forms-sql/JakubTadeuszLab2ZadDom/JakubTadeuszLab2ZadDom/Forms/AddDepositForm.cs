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
    public partial class AddDepositForm : Form
    {
        /// <summary> 
        /// Database connection repository
        /// </summary>
        Repository repository = new Repository();
        /// <summary>
        /// Id of the employee who deposits cash
        /// </summary>
        public int EmployeeId { get; }
        /// <summary>
        /// Id of the selected client
        /// </summary>
        public int SelectedClientId { get; }
        /// <summary>
        /// Contract object deposit will be added
        /// </summary>
        public Contract Contract { get; }
        public AddDepositForm()
        {
            InitializeComponent();
        }

        public AddDepositForm(int employeeId, int selectedClientId, Contract contract)
        {
            InitializeComponent();
            EmployeeId = employeeId;
            SelectedClientId = selectedClientId;
            Contract = contract;
        }

        /// <summary>
        /// Add contract with deposit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonnAddDeposit_Click(object sender, EventArgs e)
        {
            string depositName = textBoxDepositName.Text;
            Decimal depositValue = numericUpDownDepositValue.Value;

            repository.AddContractWithDeposit(Contract, depositName, depositValue);
            Close();
        }
    }
}
