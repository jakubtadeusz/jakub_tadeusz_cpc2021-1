
namespace JakubTadeuszLab2ZadDom
{
    partial class AddDocumentForm
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
            this.labelDocumentName = new System.Windows.Forms.Label();
            this.textBoxDocumentName = new System.Windows.Forms.TextBox();
            this.labelMonthlyPercentageCost = new System.Windows.Forms.Label();
            this.labelPercent = new System.Windows.Forms.Label();
            this.numericUpDownInterestPercentage = new System.Windows.Forms.NumericUpDown();
            this.labelMinimumContractLength = new System.Windows.Forms.Label();
            this.numericUpDownMinimumContractLength = new System.Windows.Forms.NumericUpDown();
            this.labelMonthsMin = new System.Windows.Forms.Label();
            this.labelMonthsMax = new System.Windows.Forms.Label();
            this.numericUpDownMaximumContractLength = new System.Windows.Forms.NumericUpDown();
            this.labelMaximumContractLength = new System.Windows.Forms.Label();
            this.numericUpDownMonthlyOperatingCost = new System.Windows.Forms.NumericUpDown();
            this.labelOperatingCost = new System.Windows.Forms.Label();
            this.labelPLN = new System.Windows.Forms.Label();
            this.checkBoxDepositRequired = new System.Windows.Forms.CheckBox();
            this.openFileDialogDocument = new System.Windows.Forms.OpenFileDialog();
            this.buttonAddDocFile = new System.Windows.Forms.Button();
            this.labelDocumentFileLocation = new System.Windows.Forms.Label();
            this.buttonAddDocument = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterestPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinimumContractLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaximumContractLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonthlyOperatingCost)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDocumentName
            // 
            this.labelDocumentName.AutoSize = true;
            this.labelDocumentName.Location = new System.Drawing.Point(12, 9);
            this.labelDocumentName.Name = "labelDocumentName";
            this.labelDocumentName.Size = new System.Drawing.Size(99, 13);
            this.labelDocumentName.TabIndex = 0;
            this.labelDocumentName.Text = "Nazwa dokumentu:";
            // 
            // textBoxDocumentName
            // 
            this.textBoxDocumentName.Location = new System.Drawing.Point(15, 25);
            this.textBoxDocumentName.Name = "textBoxDocumentName";
            this.textBoxDocumentName.Size = new System.Drawing.Size(180, 20);
            this.textBoxDocumentName.TabIndex = 1;
            // 
            // labelMonthlyPercentageCost
            // 
            this.labelMonthlyPercentageCost.AutoSize = true;
            this.labelMonthlyPercentageCost.Location = new System.Drawing.Point(12, 48);
            this.labelMonthlyPercentageCost.Name = "labelMonthlyPercentageCost";
            this.labelMonthlyPercentageCost.Size = new System.Drawing.Size(100, 13);
            this.labelMonthlyPercentageCost.TabIndex = 2;
            this.labelMonthlyPercentageCost.Text = "Miesięczne odsetki:";
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPercent.Location = new System.Drawing.Point(82, 66);
            this.labelPercent.Margin = new System.Windows.Forms.Padding(0);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(20, 16);
            this.labelPercent.TabIndex = 6;
            this.labelPercent.Text = "%";
            // 
            // numericUpDownInterestPercentage
            // 
            this.numericUpDownInterestPercentage.DecimalPlaces = 2;
            this.numericUpDownInterestPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownInterestPercentage.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownInterestPercentage.Location = new System.Drawing.Point(15, 64);
            this.numericUpDownInterestPercentage.Name = "numericUpDownInterestPercentage";
            this.numericUpDownInterestPercentage.Size = new System.Drawing.Size(64, 22);
            this.numericUpDownInterestPercentage.TabIndex = 7;
            // 
            // labelMinimumContractLength
            // 
            this.labelMinimumContractLength.AutoSize = true;
            this.labelMinimumContractLength.Location = new System.Drawing.Point(12, 153);
            this.labelMinimumContractLength.Name = "labelMinimumContractLength";
            this.labelMinimumContractLength.Size = new System.Drawing.Size(135, 13);
            this.labelMinimumContractLength.TabIndex = 8;
            this.labelMinimumContractLength.Text = "Minimalna długość umowy:";
            // 
            // numericUpDownMinimumContractLength
            // 
            this.numericUpDownMinimumContractLength.Location = new System.Drawing.Point(15, 169);
            this.numericUpDownMinimumContractLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMinimumContractLength.Name = "numericUpDownMinimumContractLength";
            this.numericUpDownMinimumContractLength.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownMinimumContractLength.TabIndex = 9;
            // 
            // labelMonthsMin
            // 
            this.labelMonthsMin.AutoSize = true;
            this.labelMonthsMin.Location = new System.Drawing.Point(108, 171);
            this.labelMonthsMin.Name = "labelMonthsMin";
            this.labelMonthsMin.Size = new System.Drawing.Size(47, 13);
            this.labelMonthsMin.TabIndex = 10;
            this.labelMonthsMin.Text = "miesięcy";
            // 
            // labelMonthsMax
            // 
            this.labelMonthsMax.AutoSize = true;
            this.labelMonthsMax.Location = new System.Drawing.Point(108, 210);
            this.labelMonthsMax.Name = "labelMonthsMax";
            this.labelMonthsMax.Size = new System.Drawing.Size(47, 13);
            this.labelMonthsMax.TabIndex = 13;
            this.labelMonthsMax.Text = "miesięcy";
            // 
            // numericUpDownMaximumContractLength
            // 
            this.numericUpDownMaximumContractLength.Location = new System.Drawing.Point(15, 208);
            this.numericUpDownMaximumContractLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaximumContractLength.Name = "numericUpDownMaximumContractLength";
            this.numericUpDownMaximumContractLength.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownMaximumContractLength.TabIndex = 12;
            // 
            // labelMaximumContractLength
            // 
            this.labelMaximumContractLength.AutoSize = true;
            this.labelMaximumContractLength.Location = new System.Drawing.Point(12, 192);
            this.labelMaximumContractLength.Name = "labelMaximumContractLength";
            this.labelMaximumContractLength.Size = new System.Drawing.Size(147, 13);
            this.labelMaximumContractLength.TabIndex = 11;
            this.labelMaximumContractLength.Text = "Maksymalna długość umowy:";
            // 
            // numericUpDownMonthlyOperatingCost
            // 
            this.numericUpDownMonthlyOperatingCost.DecimalPlaces = 2;
            this.numericUpDownMonthlyOperatingCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownMonthlyOperatingCost.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownMonthlyOperatingCost.Location = new System.Drawing.Point(15, 105);
            this.numericUpDownMonthlyOperatingCost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownMonthlyOperatingCost.Name = "numericUpDownMonthlyOperatingCost";
            this.numericUpDownMonthlyOperatingCost.Size = new System.Drawing.Size(87, 22);
            this.numericUpDownMonthlyOperatingCost.TabIndex = 14;
            // 
            // labelOperatingCost
            // 
            this.labelOperatingCost.AutoSize = true;
            this.labelOperatingCost.Location = new System.Drawing.Point(12, 89);
            this.labelOperatingCost.Name = "labelOperatingCost";
            this.labelOperatingCost.Size = new System.Drawing.Size(151, 13);
            this.labelOperatingCost.TabIndex = 15;
            this.labelOperatingCost.Text = "Miesięczne koszty operacyjne:";
            // 
            // labelPLN
            // 
            this.labelPLN.AutoSize = true;
            this.labelPLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPLN.Location = new System.Drawing.Point(105, 107);
            this.labelPLN.Margin = new System.Windows.Forms.Padding(0);
            this.labelPLN.Name = "labelPLN";
            this.labelPLN.Size = new System.Drawing.Size(34, 16);
            this.labelPLN.TabIndex = 16;
            this.labelPLN.Text = "PLN";
            // 
            // checkBoxDepositRequired
            // 
            this.checkBoxDepositRequired.AutoSize = true;
            this.checkBoxDepositRequired.Location = new System.Drawing.Point(15, 133);
            this.checkBoxDepositRequired.Name = "checkBoxDepositRequired";
            this.checkBoxDepositRequired.Size = new System.Drawing.Size(119, 17);
            this.checkBoxDepositRequired.TabIndex = 18;
            this.checkBoxDepositRequired.Text = "Wymagany depozyt";
            this.checkBoxDepositRequired.UseVisualStyleBackColor = true;
            // 
            // openFileDialogDocument
            // 
            this.openFileDialogDocument.Filter = "PDF|*.pdf";
            this.openFileDialogDocument.Title = "Wybierz plik dokumentu";
            // 
            // buttonAddDocFile
            // 
            this.buttonAddDocFile.Location = new System.Drawing.Point(15, 234);
            this.buttonAddDocFile.Name = "buttonAddDocFile";
            this.buttonAddDocFile.Size = new System.Drawing.Size(75, 23);
            this.buttonAddDocFile.TabIndex = 19;
            this.buttonAddDocFile.Text = "Dodaj plik";
            this.buttonAddDocFile.UseVisualStyleBackColor = true;
            this.buttonAddDocFile.Click += new System.EventHandler(this.buttonAddDocFile_Click);
            // 
            // labelDocumentFileLocation
            // 
            this.labelDocumentFileLocation.AutoSize = true;
            this.labelDocumentFileLocation.Location = new System.Drawing.Point(12, 260);
            this.labelDocumentFileLocation.Name = "labelDocumentFileLocation";
            this.labelDocumentFileLocation.Size = new System.Drawing.Size(0, 13);
            this.labelDocumentFileLocation.TabIndex = 20;
            // 
            // buttonAddDocument
            // 
            this.buttonAddDocument.Location = new System.Drawing.Point(12, 334);
            this.buttonAddDocument.Name = "buttonAddDocument";
            this.buttonAddDocument.Size = new System.Drawing.Size(305, 23);
            this.buttonAddDocument.TabIndex = 21;
            this.buttonAddDocument.Text = "Dodaj dokument";
            this.buttonAddDocument.UseVisualStyleBackColor = true;
            this.buttonAddDocument.Click += new System.EventHandler(this.buttonAddDocument_Click);
            // 
            // AddDocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 369);
            this.Controls.Add(this.buttonAddDocument);
            this.Controls.Add(this.labelDocumentFileLocation);
            this.Controls.Add(this.buttonAddDocFile);
            this.Controls.Add(this.checkBoxDepositRequired);
            this.Controls.Add(this.labelPLN);
            this.Controls.Add(this.labelOperatingCost);
            this.Controls.Add(this.numericUpDownMonthlyOperatingCost);
            this.Controls.Add(this.labelMonthsMax);
            this.Controls.Add(this.numericUpDownMaximumContractLength);
            this.Controls.Add(this.labelMaximumContractLength);
            this.Controls.Add(this.labelMonthsMin);
            this.Controls.Add(this.numericUpDownMinimumContractLength);
            this.Controls.Add(this.labelMinimumContractLength);
            this.Controls.Add(this.numericUpDownInterestPercentage);
            this.Controls.Add(this.labelPercent);
            this.Controls.Add(this.labelMonthlyPercentageCost);
            this.Controls.Add(this.textBoxDocumentName);
            this.Controls.Add(this.labelDocumentName);
            this.Name = "AddDocumentForm";
            this.Text = "AddDocumentForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterestPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinimumContractLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaximumContractLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonthlyOperatingCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDocumentName;
        private System.Windows.Forms.TextBox textBoxDocumentName;
        private System.Windows.Forms.Label labelMonthlyPercentageCost;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.NumericUpDown numericUpDownInterestPercentage;
        private System.Windows.Forms.Label labelMinimumContractLength;
        private System.Windows.Forms.NumericUpDown numericUpDownMinimumContractLength;
        private System.Windows.Forms.Label labelMonthsMin;
        private System.Windows.Forms.Label labelMonthsMax;
        private System.Windows.Forms.NumericUpDown numericUpDownMaximumContractLength;
        private System.Windows.Forms.Label labelMaximumContractLength;
        private System.Windows.Forms.NumericUpDown numericUpDownMonthlyOperatingCost;
        private System.Windows.Forms.Label labelOperatingCost;
        private System.Windows.Forms.Label labelPLN;
        private System.Windows.Forms.CheckBox checkBoxDepositRequired;
        private System.Windows.Forms.OpenFileDialog openFileDialogDocument;
        private System.Windows.Forms.Button buttonAddDocFile;
        private System.Windows.Forms.Label labelDocumentFileLocation;
        private System.Windows.Forms.Button buttonAddDocument;
    }
}