
namespace JakubTadeuszLab2ZadDom.Forms
{
    partial class EditClientForm
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
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxFlatNumber = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxPESEL = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.buttonEditClient = new System.Windows.Forms.Button();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelFlatNumber = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelPESEL = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(139, 164);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(192, 20);
            this.textBoxPostalCode.TabIndex = 29;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(139, 138);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(192, 20);
            this.textBoxCity.TabIndex = 28;
            // 
            // textBoxFlatNumber
            // 
            this.textBoxFlatNumber.Location = new System.Drawing.Point(139, 112);
            this.textBoxFlatNumber.Name = "textBoxFlatNumber";
            this.textBoxFlatNumber.Size = new System.Drawing.Size(192, 20);
            this.textBoxFlatNumber.TabIndex = 27;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(139, 86);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(192, 20);
            this.textBoxStreet.TabIndex = 26;
            // 
            // textBoxPESEL
            // 
            this.textBoxPESEL.Location = new System.Drawing.Point(139, 60);
            this.textBoxPESEL.Name = "textBoxPESEL";
            this.textBoxPESEL.Size = new System.Drawing.Size(192, 20);
            this.textBoxPESEL.TabIndex = 25;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(139, 34);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(192, 20);
            this.textBoxLastName.TabIndex = 24;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(139, 8);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(192, 20);
            this.textBoxFirstName.TabIndex = 23;
            // 
            // buttonEditClient
            // 
            this.buttonEditClient.Location = new System.Drawing.Point(12, 190);
            this.buttonEditClient.Name = "buttonEditClient";
            this.buttonEditClient.Size = new System.Drawing.Size(319, 49);
            this.buttonEditClient.TabIndex = 22;
            this.buttonEditClient.Text = "Edytuj";
            this.buttonEditClient.UseVisualStyleBackColor = true;
            this.buttonEditClient.Click += new System.EventHandler(this.buttonEditClient_Click);
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(9, 167);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(74, 13);
            this.labelPostalCode.TabIndex = 21;
            this.labelPostalCode.Text = "Kod pocztowy";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(9, 141);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(38, 13);
            this.labelCity.TabIndex = 20;
            this.labelCity.Text = "Miasto";
            // 
            // labelFlatNumber
            // 
            this.labelFlatNumber.AutoSize = true;
            this.labelFlatNumber.Location = new System.Drawing.Point(9, 112);
            this.labelFlatNumber.Name = "labelFlatNumber";
            this.labelFlatNumber.Size = new System.Drawing.Size(124, 13);
            this.labelFlatNumber.TabIndex = 19;
            this.labelFlatNumber.Text = "Numer domu/mieszkania";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(9, 89);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(31, 13);
            this.labelStreet.TabIndex = 18;
            this.labelStreet.Text = "Ulica";
            // 
            // labelPESEL
            // 
            this.labelPESEL.AutoSize = true;
            this.labelPESEL.Location = new System.Drawing.Point(9, 63);
            this.labelPESEL.Name = "labelPESEL";
            this.labelPESEL.Size = new System.Drawing.Size(41, 13);
            this.labelPESEL.TabIndex = 17;
            this.labelPESEL.Text = "PESEL";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(9, 37);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(53, 13);
            this.labelLastName.TabIndex = 16;
            this.labelLastName.Text = "Nazwisko";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(9, 11);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(26, 13);
            this.labelFirstName.TabIndex = 15;
            this.labelFirstName.Text = "Imię";
            // 
            // EditClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 254);
            this.Controls.Add(this.textBoxPostalCode);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxFlatNumber);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.textBoxPESEL);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.buttonEditClient);
            this.Controls.Add(this.labelPostalCode);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelFlatNumber);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.labelPESEL);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Name = "EditClientForm";
            this.Text = "Edytuj klienta";
            this.Load += new System.EventHandler(this.EditClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxFlatNumber;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxPESEL;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Button buttonEditClient;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelFlatNumber;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelPESEL;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
    }
}