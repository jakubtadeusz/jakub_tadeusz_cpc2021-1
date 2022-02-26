using JakubTadeuszLab2ZadDom.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JakubTadeuszLab2ZadDom
{
    public partial class AddDocumentForm : Form
    {
        /// <summary> 
        /// Database connection repository
        /// </summary>
        Repository repository = new Repository();
        public AddDocumentForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handle button to add pdf to the contract
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddDocFile_Click(object sender, EventArgs e)
        {
            openFileDialogDocument.ShowDialog();

            labelDocumentFileLocation.Text = openFileDialogDocument.FileName.Replace(Directory.GetCurrentDirectory(), "");
        }

        /// <summary>
        /// Handle button to add contract template
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddDocument_Click(object sender, EventArgs e)
        {
            //utwórz obiekt dokumentu
            string contractName = textBoxDocumentName.Text;
            Document document = new Document(contractName)
            {
                ContractMonthlyPercentageInterest = numericUpDownInterestPercentage.Value,
                ContractMinimumMonthDuration = Decimal.ToInt32(numericUpDownMinimumContractLength.Value),
                ContractMaximumMonthDuration = Decimal.ToInt32(numericUpDownMaximumContractLength.Value),
                DepositRequired = checkBoxDepositRequired.Checked,
                ContractMonthlyOperatingCost = numericUpDownMonthlyOperatingCost.Value,
                ContractDocumentLocation = labelDocumentFileLocation.Text
            };

            repository.AddDocument(document);
            Close();
        }  
    }
}
