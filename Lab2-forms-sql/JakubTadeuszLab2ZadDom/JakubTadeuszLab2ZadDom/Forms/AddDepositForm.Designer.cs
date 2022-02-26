
namespace JakubTadeuszLab2ZadDom
{
    partial class AddDepositForm
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
            this.labelDepositName = new System.Windows.Forms.Label();
            this.textBoxDepositName = new System.Windows.Forms.TextBox();
            this.labelDepositValue = new System.Windows.Forms.Label();
            this.numericUpDownDepositValue = new System.Windows.Forms.NumericUpDown();
            this.labelPLN = new System.Windows.Forms.Label();
            this.buttonnAddDeposit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepositValue)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDepositName
            // 
            this.labelDepositName.AutoSize = true;
            this.labelDepositName.Location = new System.Drawing.Point(12, 9);
            this.labelDepositName.Name = "labelDepositName";
            this.labelDepositName.Size = new System.Drawing.Size(97, 13);
            this.labelDepositName.TabIndex = 0;
            this.labelDepositName.Text = "Nazwa przedmiotu:";
            // 
            // textBoxDepositName
            // 
            this.textBoxDepositName.Location = new System.Drawing.Point(15, 25);
            this.textBoxDepositName.Name = "textBoxDepositName";
            this.textBoxDepositName.Size = new System.Drawing.Size(244, 20);
            this.textBoxDepositName.TabIndex = 1;
            // 
            // labelDepositValue
            // 
            this.labelDepositValue.AutoSize = true;
            this.labelDepositValue.Location = new System.Drawing.Point(12, 48);
            this.labelDepositValue.Name = "labelDepositValue";
            this.labelDepositValue.Size = new System.Drawing.Size(104, 13);
            this.labelDepositValue.TabIndex = 2;
            this.labelDepositValue.Text = "Wartość przedmiotu:";
            // 
            // numericUpDownDepositValue
            // 
            this.numericUpDownDepositValue.DecimalPlaces = 2;
            this.numericUpDownDepositValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDepositValue.Location = new System.Drawing.Point(15, 64);
            this.numericUpDownDepositValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownDepositValue.Name = "numericUpDownDepositValue";
            this.numericUpDownDepositValue.Size = new System.Drawing.Size(218, 20);
            this.numericUpDownDepositValue.TabIndex = 3;
            // 
            // labelPLN
            // 
            this.labelPLN.AutoSize = true;
            this.labelPLN.Location = new System.Drawing.Point(231, 66);
            this.labelPLN.Name = "labelPLN";
            this.labelPLN.Size = new System.Drawing.Size(28, 13);
            this.labelPLN.TabIndex = 4;
            this.labelPLN.Text = "PLN";
            // 
            // buttonnAddDeposit
            // 
            this.buttonnAddDeposit.Location = new System.Drawing.Point(15, 90);
            this.buttonnAddDeposit.Name = "buttonnAddDeposit";
            this.buttonnAddDeposit.Size = new System.Drawing.Size(244, 29);
            this.buttonnAddDeposit.TabIndex = 5;
            this.buttonnAddDeposit.Text = "Dalej";
            this.buttonnAddDeposit.UseVisualStyleBackColor = true;
            this.buttonnAddDeposit.Click += new System.EventHandler(this.buttonnAddDeposit_Click);
            // 
            // AddDepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 131);
            this.Controls.Add(this.buttonnAddDeposit);
            this.Controls.Add(this.labelPLN);
            this.Controls.Add(this.numericUpDownDepositValue);
            this.Controls.Add(this.labelDepositValue);
            this.Controls.Add(this.textBoxDepositName);
            this.Controls.Add(this.labelDepositName);
            this.Name = "AddDepositForm";
            this.Text = "AddDepositForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepositValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDepositName;
        private System.Windows.Forms.TextBox textBoxDepositName;
        private System.Windows.Forms.Label labelDepositValue;
        private System.Windows.Forms.NumericUpDown numericUpDownDepositValue;
        private System.Windows.Forms.Label labelPLN;
        private System.Windows.Forms.Button buttonnAddDeposit;
    }
}