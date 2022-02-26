
namespace JakubTadeuszLab2ZadDom
{
    partial class ShowDatabaseForm
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
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonContractTemplates = new System.Windows.Forms.Button();
            this.buttonContracts = new System.Windows.Forms.Button();
            this.buttonContractOperations = new System.Windows.Forms.Button();
            this.buttonContactHistory = new System.Windows.Forms.Button();
            this.buttonContactTypes = new System.Windows.Forms.Button();
            this.buttonDeposits = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.AllowUserToAddRows = false;
            this.dataGridViewTable.AllowUserToDeleteRows = false;
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Location = new System.Drawing.Point(265, 12);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.ReadOnly = true;
            this.dataGridViewTable.Size = new System.Drawing.Size(828, 604);
            this.dataGridViewTable.TabIndex = 0;
            // 
            // buttonUsers
            // 
            this.buttonUsers.Location = new System.Drawing.Point(12, 12);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(247, 28);
            this.buttonUsers.TabIndex = 1;
            this.buttonUsers.Text = "Użytkownicy";
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.Location = new System.Drawing.Point(12, 46);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Size = new System.Drawing.Size(247, 28);
            this.buttonEmployees.TabIndex = 2;
            this.buttonEmployees.Text = "Pracownicy";
            this.buttonEmployees.UseVisualStyleBackColor = true;
            this.buttonEmployees.Click += new System.EventHandler(this.buttonEmployees_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.Location = new System.Drawing.Point(12, 80);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(247, 28);
            this.buttonClients.TabIndex = 3;
            this.buttonClients.Text = "Klienci";
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonContractTemplates
            // 
            this.buttonContractTemplates.Location = new System.Drawing.Point(12, 114);
            this.buttonContractTemplates.Name = "buttonContractTemplates";
            this.buttonContractTemplates.Size = new System.Drawing.Size(247, 28);
            this.buttonContractTemplates.TabIndex = 4;
            this.buttonContractTemplates.Text = "Wzory umów";
            this.buttonContractTemplates.UseVisualStyleBackColor = true;
            this.buttonContractTemplates.Click += new System.EventHandler(this.buttonContractTemplates_Click);
            // 
            // buttonContracts
            // 
            this.buttonContracts.Location = new System.Drawing.Point(12, 148);
            this.buttonContracts.Name = "buttonContracts";
            this.buttonContracts.Size = new System.Drawing.Size(247, 28);
            this.buttonContracts.TabIndex = 5;
            this.buttonContracts.Text = "Umowy";
            this.buttonContracts.UseVisualStyleBackColor = true;
            this.buttonContracts.Click += new System.EventHandler(this.buttonContracts_Click);
            // 
            // buttonContractOperations
            // 
            this.buttonContractOperations.Location = new System.Drawing.Point(12, 182);
            this.buttonContractOperations.Name = "buttonContractOperations";
            this.buttonContractOperations.Size = new System.Drawing.Size(247, 28);
            this.buttonContractOperations.TabIndex = 6;
            this.buttonContractOperations.Text = "Operacje związane z umowami";
            this.buttonContractOperations.UseVisualStyleBackColor = true;
            this.buttonContractOperations.Click += new System.EventHandler(this.buttonContractOperations_Click);
            // 
            // buttonContactHistory
            // 
            this.buttonContactHistory.Location = new System.Drawing.Point(12, 216);
            this.buttonContactHistory.Name = "buttonContactHistory";
            this.buttonContactHistory.Size = new System.Drawing.Size(247, 28);
            this.buttonContactHistory.TabIndex = 7;
            this.buttonContactHistory.Text = "Historia kontaktu z klientami";
            this.buttonContactHistory.UseVisualStyleBackColor = true;
            this.buttonContactHistory.Click += new System.EventHandler(this.buttonContactHistory_Click);
            // 
            // buttonContactTypes
            // 
            this.buttonContactTypes.Location = new System.Drawing.Point(12, 250);
            this.buttonContactTypes.Name = "buttonContactTypes";
            this.buttonContactTypes.Size = new System.Drawing.Size(247, 28);
            this.buttonContactTypes.TabIndex = 8;
            this.buttonContactTypes.Text = "Typy kontaktu";
            this.buttonContactTypes.UseVisualStyleBackColor = true;
            this.buttonContactTypes.Click += new System.EventHandler(this.buttonContactTypes_Click);
            // 
            // buttonDeposits
            // 
            this.buttonDeposits.Location = new System.Drawing.Point(12, 284);
            this.buttonDeposits.Name = "buttonDeposits";
            this.buttonDeposits.Size = new System.Drawing.Size(247, 28);
            this.buttonDeposits.TabIndex = 9;
            this.buttonDeposits.Text = "Depozyty";
            this.buttonDeposits.UseVisualStyleBackColor = true;
            this.buttonDeposits.Click += new System.EventHandler(this.buttonDeposits_Click);
            // 
            // ShowDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 628);
            this.Controls.Add(this.buttonDeposits);
            this.Controls.Add(this.buttonContactTypes);
            this.Controls.Add(this.buttonContactHistory);
            this.Controls.Add(this.buttonContractOperations);
            this.Controls.Add(this.buttonContracts);
            this.Controls.Add(this.buttonContractTemplates);
            this.Controls.Add(this.buttonClients);
            this.Controls.Add(this.buttonEmployees);
            this.Controls.Add(this.buttonUsers);
            this.Controls.Add(this.dataGridViewTable);
            this.Name = "ShowDatabaseForm";
            this.Text = "ShowDatabaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonEmployees;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonContractTemplates;
        private System.Windows.Forms.Button buttonContracts;
        private System.Windows.Forms.Button buttonContractOperations;
        private System.Windows.Forms.Button buttonContactHistory;
        private System.Windows.Forms.Button buttonContactTypes;
        private System.Windows.Forms.Button buttonDeposits;
    }
}