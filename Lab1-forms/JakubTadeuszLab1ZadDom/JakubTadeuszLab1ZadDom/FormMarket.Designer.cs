
namespace JakubTadeuszLab1ZadDom
{
    partial class FormMarket
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
            this.labelGold = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.trackBarBoughtAmount = new System.Windows.Forms.TrackBar();
            this.buttonBuyWood = new System.Windows.Forms.Button();
            this.buttonBuyFood = new System.Windows.Forms.Button();
            this.buttonBuyStone = new System.Windows.Forms.Button();
            this.buttonBuyIron = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBoughtAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGold
            // 
            this.labelGold.AutoSize = true;
            this.labelGold.Location = new System.Drawing.Point(12, 19);
            this.labelGold.Name = "labelGold";
            this.labelGold.Size = new System.Drawing.Size(63, 13);
            this.labelGold.TabIndex = 0;
            this.labelGold.Text = "Złoto: 1000";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(12, 43);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(141, 13);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Cena za sztukę surowca: 10";
            // 
            // trackBarBoughtAmount
            // 
            this.trackBarBoughtAmount.Location = new System.Drawing.Point(12, 92);
            this.trackBarBoughtAmount.Name = "trackBarBoughtAmount";
            this.trackBarBoughtAmount.Size = new System.Drawing.Size(172, 45);
            this.trackBarBoughtAmount.TabIndex = 2;
            // 
            // buttonBuyWood
            // 
            this.buttonBuyWood.Location = new System.Drawing.Point(12, 177);
            this.buttonBuyWood.Name = "buttonBuyWood";
            this.buttonBuyWood.Size = new System.Drawing.Size(172, 39);
            this.buttonBuyWood.TabIndex = 3;
            this.buttonBuyWood.Text = "Kup drewno";
            this.buttonBuyWood.UseVisualStyleBackColor = true;
            this.buttonBuyWood.Click += new System.EventHandler(this.buttonBuyWood_Click);
            // 
            // buttonBuyFood
            // 
            this.buttonBuyFood.Location = new System.Drawing.Point(12, 132);
            this.buttonBuyFood.Name = "buttonBuyFood";
            this.buttonBuyFood.Size = new System.Drawing.Size(172, 39);
            this.buttonBuyFood.TabIndex = 4;
            this.buttonBuyFood.Text = "Kup zapasy";
            this.buttonBuyFood.UseVisualStyleBackColor = true;
            this.buttonBuyFood.Click += new System.EventHandler(this.buttonBuyFood_Click);
            // 
            // buttonBuyStone
            // 
            this.buttonBuyStone.Location = new System.Drawing.Point(12, 222);
            this.buttonBuyStone.Name = "buttonBuyStone";
            this.buttonBuyStone.Size = new System.Drawing.Size(172, 39);
            this.buttonBuyStone.TabIndex = 5;
            this.buttonBuyStone.Text = "Kup kamień";
            this.buttonBuyStone.UseVisualStyleBackColor = true;
            this.buttonBuyStone.Click += new System.EventHandler(this.buttonBuyStone_Click);
            // 
            // buttonBuyIron
            // 
            this.buttonBuyIron.Location = new System.Drawing.Point(12, 267);
            this.buttonBuyIron.Name = "buttonBuyIron";
            this.buttonBuyIron.Size = new System.Drawing.Size(172, 39);
            this.buttonBuyIron.TabIndex = 6;
            this.buttonBuyIron.Text = "Kup żelazo";
            this.buttonBuyIron.UseVisualStyleBackColor = true;
            this.buttonBuyIron.Click += new System.EventHandler(this.buttonBuyIron_Click);
            // 
            // FormMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 324);
            this.Controls.Add(this.buttonBuyIron);
            this.Controls.Add(this.buttonBuyStone);
            this.Controls.Add(this.buttonBuyFood);
            this.Controls.Add(this.buttonBuyWood);
            this.Controls.Add(this.trackBarBoughtAmount);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelGold);
            this.Name = "FormMarket";
            this.Text = "Market";
            this.Shown += new System.EventHandler(this.FormMarket_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBoughtAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGold;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TrackBar trackBarBoughtAmount;
        private System.Windows.Forms.Button buttonBuyWood;
        private System.Windows.Forms.Button buttonBuyFood;
        private System.Windows.Forms.Button buttonBuyStone;
        private System.Windows.Forms.Button buttonBuyIron;
    }
}