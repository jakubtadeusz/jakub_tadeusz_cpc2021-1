
namespace JakubTadeuszLab2ZadDom
{
    partial class MainForm
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
            this.labelUserInfo = new System.Windows.Forms.Label();
            this.buttonDepositMoney = new System.Windows.Forms.Button();
            this.labelCashRegister = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.buttonPayoutMoney = new System.Windows.Forms.Button();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.buttonShowOperations = new System.Windows.Forms.Button();
            this.buttonContracts = new System.Windows.Forms.Button();
            this.buttonShowClients = new System.Windows.Forms.Button();
            this.buttonShowDocuments = new System.Windows.Forms.Button();
            this.buttonShowDeposits = new System.Windows.Forms.Button();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.buttonAddContract = new System.Windows.Forms.Button();
            this.buttonAddDocument = new System.Windows.Forms.Button();
            this.buttonShowUserDetails = new System.Windows.Forms.Button();
            this.buttonEditClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserInfo
            // 
            this.labelUserInfo.AutoSize = true;
            this.labelUserInfo.Location = new System.Drawing.Point(12, 9);
            this.labelUserInfo.Name = "labelUserInfo";
            this.labelUserInfo.Size = new System.Drawing.Size(140, 13);
            this.labelUserInfo.TabIndex = 0;
            this.labelUserInfo.Text = "Zalogowano: Imię Nazwisko";
            // 
            // buttonDepositMoney
            // 
            this.buttonDepositMoney.Location = new System.Drawing.Point(311, 22);
            this.buttonDepositMoney.Name = "buttonDepositMoney";
            this.buttonDepositMoney.Size = new System.Drawing.Size(75, 20);
            this.buttonDepositMoney.TabIndex = 1;
            this.buttonDepositMoney.Text = "Wpłać";
            this.buttonDepositMoney.UseVisualStyleBackColor = true;
            this.buttonDepositMoney.Click += new System.EventHandler(this.buttonDepositMoney_Click);
            // 
            // labelCashRegister
            // 
            this.labelCashRegister.AutoSize = true;
            this.labelCashRegister.Location = new System.Drawing.Point(12, 26);
            this.labelCashRegister.Name = "labelCashRegister";
            this.labelCashRegister.Size = new System.Drawing.Size(66, 13);
            this.labelCashRegister.TabIndex = 2;
            this.labelCashRegister.Text = "Stan kasy: 0";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(165, 22);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(140, 20);
            this.textBoxAmount.TabIndex = 3;
            // 
            // buttonPayoutMoney
            // 
            this.buttonPayoutMoney.Location = new System.Drawing.Point(392, 22);
            this.buttonPayoutMoney.Name = "buttonPayoutMoney";
            this.buttonPayoutMoney.Size = new System.Drawing.Size(75, 20);
            this.buttonPayoutMoney.TabIndex = 4;
            this.buttonPayoutMoney.Text = "Wypłać";
            this.buttonPayoutMoney.UseVisualStyleBackColor = true;
            this.buttonPayoutMoney.Click += new System.EventHandler(this.buttonPayoutMoney_Click);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.AllowUserToOrderColumns = true;
            this.dataGridViewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(165, 48);
            this.dataGridViewMain.MultiSelect = false;
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMain.Size = new System.Drawing.Size(1009, 591);
            this.dataGridViewMain.TabIndex = 5;
            // 
            // buttonShowOperations
            // 
            this.buttonShowOperations.Location = new System.Drawing.Point(15, 48);
            this.buttonShowOperations.Name = "buttonShowOperations";
            this.buttonShowOperations.Size = new System.Drawing.Size(75, 23);
            this.buttonShowOperations.TabIndex = 6;
            this.buttonShowOperations.Text = "Operacje";
            this.buttonShowOperations.UseVisualStyleBackColor = true;
            this.buttonShowOperations.Click += new System.EventHandler(this.buttonShowOperations_Click);
            // 
            // buttonContracts
            // 
            this.buttonContracts.Location = new System.Drawing.Point(15, 77);
            this.buttonContracts.Name = "buttonContracts";
            this.buttonContracts.Size = new System.Drawing.Size(75, 23);
            this.buttonContracts.TabIndex = 7;
            this.buttonContracts.Text = "Umowy";
            this.buttonContracts.UseVisualStyleBackColor = true;
            this.buttonContracts.Click += new System.EventHandler(this.buttonContracts_Click);
            // 
            // buttonShowClients
            // 
            this.buttonShowClients.Location = new System.Drawing.Point(15, 106);
            this.buttonShowClients.Name = "buttonShowClients";
            this.buttonShowClients.Size = new System.Drawing.Size(75, 23);
            this.buttonShowClients.TabIndex = 9;
            this.buttonShowClients.Text = "Klienci";
            this.buttonShowClients.UseVisualStyleBackColor = true;
            this.buttonShowClients.Click += new System.EventHandler(this.buttonShowClients_Click);
            // 
            // buttonShowDocuments
            // 
            this.buttonShowDocuments.Location = new System.Drawing.Point(15, 135);
            this.buttonShowDocuments.Name = "buttonShowDocuments";
            this.buttonShowDocuments.Size = new System.Drawing.Size(75, 23);
            this.buttonShowDocuments.TabIndex = 10;
            this.buttonShowDocuments.Text = "Dokumenty";
            this.buttonShowDocuments.UseVisualStyleBackColor = true;
            this.buttonShowDocuments.Click += new System.EventHandler(this.buttonShowDocuments_Click);
            // 
            // buttonShowDeposits
            // 
            this.buttonShowDeposits.Location = new System.Drawing.Point(15, 164);
            this.buttonShowDeposits.Name = "buttonShowDeposits";
            this.buttonShowDeposits.Size = new System.Drawing.Size(75, 23);
            this.buttonShowDeposits.TabIndex = 11;
            this.buttonShowDeposits.Text = "Magazyn";
            this.buttonShowDeposits.UseVisualStyleBackColor = true;
            this.buttonShowDeposits.Click += new System.EventHandler(this.buttonShowDeposits_Click);
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(165, 22);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(101, 20);
            this.buttonAddClient.TabIndex = 12;
            this.buttonAddClient.Text = "Dodaj klienta";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Visible = false;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // buttonAddContract
            // 
            this.buttonAddContract.Location = new System.Drawing.Point(272, 22);
            this.buttonAddContract.Name = "buttonAddContract";
            this.buttonAddContract.Size = new System.Drawing.Size(101, 20);
            this.buttonAddContract.TabIndex = 13;
            this.buttonAddContract.Text = "Dodaj umowę";
            this.buttonAddContract.UseVisualStyleBackColor = true;
            this.buttonAddContract.Visible = false;
            this.buttonAddContract.Click += new System.EventHandler(this.buttonAddContract_Click);
            // 
            // buttonAddDocument
            // 
            this.buttonAddDocument.Location = new System.Drawing.Point(165, 22);
            this.buttonAddDocument.Name = "buttonAddDocument";
            this.buttonAddDocument.Size = new System.Drawing.Size(101, 20);
            this.buttonAddDocument.TabIndex = 14;
            this.buttonAddDocument.Text = "Dodaj dokument";
            this.buttonAddDocument.UseVisualStyleBackColor = true;
            this.buttonAddDocument.Visible = false;
            this.buttonAddDocument.Click += new System.EventHandler(this.buttonAddDocument_Click);
            // 
            // buttonShowUserDetails
            // 
            this.buttonShowUserDetails.Location = new System.Drawing.Point(379, 22);
            this.buttonShowUserDetails.Name = "buttonShowUserDetails";
            this.buttonShowUserDetails.Size = new System.Drawing.Size(120, 20);
            this.buttonShowUserDetails.TabIndex = 15;
            this.buttonShowUserDetails.Text = "Wyswietl informacje";
            this.buttonShowUserDetails.UseVisualStyleBackColor = true;
            this.buttonShowUserDetails.Visible = false;
            this.buttonShowUserDetails.Click += new System.EventHandler(this.buttonShowUserDetails_Click);
            // 
            // buttonEditClient
            // 
            this.buttonEditClient.Location = new System.Drawing.Point(505, 22);
            this.buttonEditClient.Name = "buttonEditClient";
            this.buttonEditClient.Size = new System.Drawing.Size(101, 20);
            this.buttonEditClient.TabIndex = 16;
            this.buttonEditClient.Text = "Edytuj klienta";
            this.buttonEditClient.UseVisualStyleBackColor = true;
            this.buttonEditClient.Visible = false;
            this.buttonEditClient.Click += new System.EventHandler(this.buttonEditClient_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1186, 651);
            this.Controls.Add(this.buttonEditClient);
            this.Controls.Add(this.buttonShowUserDetails);
            this.Controls.Add(this.buttonAddDocument);
            this.Controls.Add(this.buttonAddContract);
            this.Controls.Add(this.buttonAddClient);
            this.Controls.Add(this.buttonShowDeposits);
            this.Controls.Add(this.buttonShowDocuments);
            this.Controls.Add(this.buttonShowClients);
            this.Controls.Add(this.buttonContracts);
            this.Controls.Add(this.buttonShowOperations);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.buttonPayoutMoney);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.labelCashRegister);
            this.Controls.Add(this.buttonDepositMoney);
            this.Controls.Add(this.labelUserInfo);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserInfo;
        private System.Windows.Forms.Button buttonDepositMoney;
        private System.Windows.Forms.Label labelCashRegister;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button buttonPayoutMoney;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button buttonShowOperations;
        private System.Windows.Forms.Button buttonContracts;
        private System.Windows.Forms.Button buttonShowClients;
        private System.Windows.Forms.Button buttonShowDocuments;
        private System.Windows.Forms.Button buttonShowDeposits;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.Button buttonAddContract;
        private System.Windows.Forms.Button buttonAddDocument;
        private System.Windows.Forms.Button buttonShowUserDetails;
        private System.Windows.Forms.Button buttonEditClient;
    }
}