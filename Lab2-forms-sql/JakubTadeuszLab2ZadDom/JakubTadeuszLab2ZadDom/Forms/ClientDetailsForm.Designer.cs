
namespace JakubTadeuszLab2ZadDom
{
    partial class ClientDetailsForm
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
            this.labelClientInfo = new System.Windows.Forms.Label();
            this.dataGridViewContracts = new System.Windows.Forms.DataGridView();
            this.labelContracts = new System.Windows.Forms.Label();
            this.buttonPay = new System.Windows.Forms.Button();
            this.labelAmount = new System.Windows.Forms.Label();
            this.numericUpDownPaidAmount = new System.Windows.Forms.NumericUpDown();
            this.labelDeposits = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.buttonCall = new System.Windows.Forms.Button();
            this.buttonSMS = new System.Windows.Forms.Button();
            this.buttonEmail = new System.Windows.Forms.Button();
            this.dataGridViewDeposits = new System.Windows.Forms.DataGridView();
            this.labelContactHistory = new System.Windows.Forms.Label();
            this.dataGridViewContactHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPaidAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeposits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContactHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // labelClientInfo
            // 
            this.labelClientInfo.AutoSize = true;
            this.labelClientInfo.Location = new System.Drawing.Point(12, 9);
            this.labelClientInfo.Name = "labelClientInfo";
            this.labelClientInfo.Size = new System.Drawing.Size(36, 13);
            this.labelClientInfo.TabIndex = 0;
            this.labelClientInfo.Text = "Klient:";
            // 
            // dataGridViewContracts
            // 
            this.dataGridViewContracts.AllowUserToAddRows = false;
            this.dataGridViewContracts.AllowUserToDeleteRows = false;
            this.dataGridViewContracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContracts.Location = new System.Drawing.Point(12, 72);
            this.dataGridViewContracts.Name = "dataGridViewContracts";
            this.dataGridViewContracts.ReadOnly = true;
            this.dataGridViewContracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewContracts.Size = new System.Drawing.Size(426, 413);
            this.dataGridViewContracts.TabIndex = 1;
            this.dataGridViewContracts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContracts_CellClick);
            // 
            // labelContracts
            // 
            this.labelContracts.AutoSize = true;
            this.labelContracts.Location = new System.Drawing.Point(13, 56);
            this.labelContracts.Name = "labelContracts";
            this.labelContracts.Size = new System.Drawing.Size(87, 13);
            this.labelContracts.TabIndex = 2;
            this.labelContracts.Text = "Aktywne umowy:";
            // 
            // buttonPay
            // 
            this.buttonPay.Location = new System.Drawing.Point(16, 517);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(422, 23);
            this.buttonPay.TabIndex = 3;
            this.buttonPay.Text = "Wpłać";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(17, 493);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(40, 13);
            this.labelAmount.TabIndex = 4;
            this.labelAmount.Text = "Kwota:";
            // 
            // numericUpDownPaidAmount
            // 
            this.numericUpDownPaidAmount.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownPaidAmount.Location = new System.Drawing.Point(63, 491);
            this.numericUpDownPaidAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownPaidAmount.Name = "numericUpDownPaidAmount";
            this.numericUpDownPaidAmount.Size = new System.Drawing.Size(375, 20);
            this.numericUpDownPaidAmount.TabIndex = 5;
            // 
            // labelDeposits
            // 
            this.labelDeposits.AutoSize = true;
            this.labelDeposits.Location = new System.Drawing.Point(820, 56);
            this.labelDeposits.Name = "labelDeposits";
            this.labelDeposits.Size = new System.Drawing.Size(54, 13);
            this.labelDeposits.TabIndex = 7;
            this.labelDeposits.Text = "Depozyty:";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Location = new System.Drawing.Point(444, 56);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(208, 13);
            this.labelContact.TabIndex = 8;
            this.labelContact.Text = "Skontaktuj się w sprawie wybranej umowy:";
            // 
            // buttonCall
            // 
            this.buttonCall.Location = new System.Drawing.Point(447, 72);
            this.buttonCall.Name = "buttonCall";
            this.buttonCall.Size = new System.Drawing.Size(370, 23);
            this.buttonCall.TabIndex = 9;
            this.buttonCall.Text = "Telefon";
            this.buttonCall.UseVisualStyleBackColor = true;
            this.buttonCall.Click += new System.EventHandler(this.buttonCall_Click);
            // 
            // buttonSMS
            // 
            this.buttonSMS.Location = new System.Drawing.Point(447, 101);
            this.buttonSMS.Name = "buttonSMS";
            this.buttonSMS.Size = new System.Drawing.Size(370, 23);
            this.buttonSMS.TabIndex = 10;
            this.buttonSMS.Text = "SMS";
            this.buttonSMS.UseVisualStyleBackColor = true;
            this.buttonSMS.Click += new System.EventHandler(this.buttonSMS_Click);
            // 
            // buttonEmail
            // 
            this.buttonEmail.Location = new System.Drawing.Point(447, 130);
            this.buttonEmail.Name = "buttonEmail";
            this.buttonEmail.Size = new System.Drawing.Size(370, 23);
            this.buttonEmail.TabIndex = 11;
            this.buttonEmail.Text = "Email";
            this.buttonEmail.UseVisualStyleBackColor = true;
            this.buttonEmail.Click += new System.EventHandler(this.buttonEmail_Click);
            // 
            // dataGridViewDeposits
            // 
            this.dataGridViewDeposits.AllowUserToAddRows = false;
            this.dataGridViewDeposits.AllowUserToDeleteRows = false;
            this.dataGridViewDeposits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDeposits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeposits.Location = new System.Drawing.Point(823, 72);
            this.dataGridViewDeposits.Name = "dataGridViewDeposits";
            this.dataGridViewDeposits.ReadOnly = true;
            this.dataGridViewDeposits.Size = new System.Drawing.Size(346, 413);
            this.dataGridViewDeposits.TabIndex = 6;
            // 
            // labelContactHistory
            // 
            this.labelContactHistory.AutoSize = true;
            this.labelContactHistory.Location = new System.Drawing.Point(444, 156);
            this.labelContactHistory.Name = "labelContactHistory";
            this.labelContactHistory.Size = new System.Drawing.Size(90, 13);
            this.labelContactHistory.TabIndex = 12;
            this.labelContactHistory.Text = "Historia kontaktu:";
            // 
            // dataGridViewContactHistory
            // 
            this.dataGridViewContactHistory.AllowUserToAddRows = false;
            this.dataGridViewContactHistory.AllowUserToDeleteRows = false;
            this.dataGridViewContactHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewContactHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContactHistory.Location = new System.Drawing.Point(447, 172);
            this.dataGridViewContactHistory.Name = "dataGridViewContactHistory";
            this.dataGridViewContactHistory.ReadOnly = true;
            this.dataGridViewContactHistory.Size = new System.Drawing.Size(370, 313);
            this.dataGridViewContactHistory.TabIndex = 13;
            // 
            // ClientDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 552);
            this.Controls.Add(this.dataGridViewContactHistory);
            this.Controls.Add(this.labelContactHistory);
            this.Controls.Add(this.buttonEmail);
            this.Controls.Add(this.buttonSMS);
            this.Controls.Add(this.buttonCall);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.labelDeposits);
            this.Controls.Add(this.dataGridViewDeposits);
            this.Controls.Add(this.numericUpDownPaidAmount);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.labelContracts);
            this.Controls.Add(this.dataGridViewContracts);
            this.Controls.Add(this.labelClientInfo);
            this.Name = "ClientDetailsForm";
            this.Text = "ClientDetailsForm";
            this.Load += new System.EventHandler(this.ClientDetailsForm_Load);
            this.Enter += new System.EventHandler(this.ClientDetailsForm_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPaidAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeposits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContactHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClientInfo;
        private System.Windows.Forms.DataGridView dataGridViewContracts;
        private System.Windows.Forms.Label labelContracts;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownPaidAmount;
        private System.Windows.Forms.Label labelDeposits;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Button buttonCall;
        private System.Windows.Forms.Button buttonSMS;
        private System.Windows.Forms.Button buttonEmail;
        private System.Windows.Forms.DataGridView dataGridViewDeposits;
        private System.Windows.Forms.Label labelContactHistory;
        private System.Windows.Forms.DataGridView dataGridViewContactHistory;
    }
}