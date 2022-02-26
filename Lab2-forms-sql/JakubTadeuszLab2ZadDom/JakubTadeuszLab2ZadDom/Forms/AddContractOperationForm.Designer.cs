
namespace JakubTadeuszLab2ZadDom
{
    partial class AddContractOperationForm
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
            this.dataGridViewContractAddForm = new System.Windows.Forms.DataGridView();
            this.labelContractAddDataGrid = new System.Windows.Forms.Label();
            this.panelContractInfo = new System.Windows.Forms.Panel();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelPLN = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.numericUpDownContractAmount = new System.Windows.Forms.NumericUpDown();
            this.labelAmount = new System.Windows.Forms.Label();
            this.numericUpDownContractLength = new System.Windows.Forms.NumericUpDown();
            this.labelMonthLength = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerDateStart = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContractAddForm)).BeginInit();
            this.panelContractInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContractAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContractLength)).BeginInit();
            this.SuspendLayout();
            // 
            // labelClientInfo
            // 
            this.labelClientInfo.AutoSize = true;
            this.labelClientInfo.Location = new System.Drawing.Point(12, 9);
            this.labelClientInfo.Name = "labelClientInfo";
            this.labelClientInfo.Size = new System.Drawing.Size(39, 13);
            this.labelClientInfo.TabIndex = 0;
            this.labelClientInfo.Text = "Klient: ";
            // 
            // dataGridViewContractAddForm
            // 
            this.dataGridViewContractAddForm.AllowUserToAddRows = false;
            this.dataGridViewContractAddForm.AllowUserToDeleteRows = false;
            this.dataGridViewContractAddForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewContractAddForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContractAddForm.Location = new System.Drawing.Point(15, 83);
            this.dataGridViewContractAddForm.MultiSelect = false;
            this.dataGridViewContractAddForm.Name = "dataGridViewContractAddForm";
            this.dataGridViewContractAddForm.ReadOnly = true;
            this.dataGridViewContractAddForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewContractAddForm.Size = new System.Drawing.Size(891, 355);
            this.dataGridViewContractAddForm.TabIndex = 1;
            this.dataGridViewContractAddForm.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContractAddForm_RowEnter);
            // 
            // labelContractAddDataGrid
            // 
            this.labelContractAddDataGrid.AutoSize = true;
            this.labelContractAddDataGrid.Location = new System.Drawing.Point(12, 67);
            this.labelContractAddDataGrid.Name = "labelContractAddDataGrid";
            this.labelContractAddDataGrid.Size = new System.Drawing.Size(64, 13);
            this.labelContractAddDataGrid.TabIndex = 3;
            this.labelContractAddDataGrid.Text = "Typ umowy:";
            // 
            // panelContractInfo
            // 
            this.panelContractInfo.Controls.Add(this.buttonNext);
            this.panelContractInfo.Controls.Add(this.labelPLN);
            this.panelContractInfo.Controls.Add(this.labelMonth);
            this.panelContractInfo.Controls.Add(this.numericUpDownContractAmount);
            this.panelContractInfo.Controls.Add(this.labelAmount);
            this.panelContractInfo.Controls.Add(this.numericUpDownContractLength);
            this.panelContractInfo.Controls.Add(this.labelMonthLength);
            this.panelContractInfo.Controls.Add(this.labelStartDate);
            this.panelContractInfo.Controls.Add(this.dateTimePickerDateStart);
            this.panelContractInfo.Location = new System.Drawing.Point(911, 76);
            this.panelContractInfo.Name = "panelContractInfo";
            this.panelContractInfo.Size = new System.Drawing.Size(230, 172);
            this.panelContractInfo.TabIndex = 12;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(6, 131);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(218, 30);
            this.buttonNext.TabIndex = 20;
            this.buttonNext.Text = "Dalej";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelPLN
            // 
            this.labelPLN.AutoSize = true;
            this.labelPLN.Location = new System.Drawing.Point(196, 107);
            this.labelPLN.Name = "labelPLN";
            this.labelPLN.Size = new System.Drawing.Size(28, 13);
            this.labelPLN.TabIndex = 19;
            this.labelPLN.Text = "PLN";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(105, 68);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(47, 13);
            this.labelMonth.TabIndex = 18;
            this.labelMonth.Text = "miesięcy";
            // 
            // numericUpDownContractAmount
            // 
            this.numericUpDownContractAmount.DecimalPlaces = 2;
            this.numericUpDownContractAmount.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownContractAmount.Location = new System.Drawing.Point(6, 105);
            this.numericUpDownContractAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownContractAmount.Name = "numericUpDownContractAmount";
            this.numericUpDownContractAmount.Size = new System.Drawing.Size(184, 20);
            this.numericUpDownContractAmount.TabIndex = 17;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(6, 89);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(40, 13);
            this.labelAmount.TabIndex = 16;
            this.labelAmount.Text = "Kwota:";
            // 
            // numericUpDownContractLength
            // 
            this.numericUpDownContractLength.Location = new System.Drawing.Point(9, 66);
            this.numericUpDownContractLength.Name = "numericUpDownContractLength";
            this.numericUpDownContractLength.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownContractLength.TabIndex = 15;
            // 
            // labelMonthLength
            // 
            this.labelMonthLength.AutoSize = true;
            this.labelMonthLength.Location = new System.Drawing.Point(6, 50);
            this.labelMonthLength.Name = "labelMonthLength";
            this.labelMonthLength.Size = new System.Drawing.Size(87, 13);
            this.labelMonthLength.TabIndex = 14;
            this.labelMonthLength.Text = "Długość umowy:";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(6, 11);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(93, 13);
            this.labelStartDate.TabIndex = 13;
            this.labelStartDate.Text = "Data rozpoczęcia:";
            // 
            // dateTimePickerDateStart
            // 
            this.dateTimePickerDateStart.Location = new System.Drawing.Point(9, 27);
            this.dateTimePickerDateStart.Name = "dateTimePickerDateStart";
            this.dateTimePickerDateStart.Size = new System.Drawing.Size(215, 20);
            this.dateTimePickerDateStart.TabIndex = 12;
            // 
            // AddContractOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 450);
            this.Controls.Add(this.panelContractInfo);
            this.Controls.Add(this.labelContractAddDataGrid);
            this.Controls.Add(this.dataGridViewContractAddForm);
            this.Controls.Add(this.labelClientInfo);
            this.Name = "AddContractOperationForm";
            this.Text = "Dodaj umowę";
            this.Load += new System.EventHandler(this.AddContractForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContractAddForm)).EndInit();
            this.panelContractInfo.ResumeLayout(false);
            this.panelContractInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContractAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContractLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClientInfo;
        private System.Windows.Forms.DataGridView dataGridViewContractAddForm;
        private System.Windows.Forms.Label labelContractAddDataGrid;
        private System.Windows.Forms.Panel panelContractInfo;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelPLN;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.NumericUpDown numericUpDownContractAmount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownContractLength;
        private System.Windows.Forms.Label labelMonthLength;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateStart;
    }
}