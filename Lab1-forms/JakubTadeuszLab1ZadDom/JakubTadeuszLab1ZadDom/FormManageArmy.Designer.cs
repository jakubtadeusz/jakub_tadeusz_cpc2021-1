
namespace JakubTadeuszLab1ZadDom
{
    partial class FormManageArmy
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
            this.labelShieldTroopsLevel = new System.Windows.Forms.Label();
            this.labelSwordTroopsLevel = new System.Windows.Forms.Label();
            this.labelRangedTroopsLevel = new System.Windows.Forms.Label();
            this.buttonUpgradeShieldTroops = new System.Windows.Forms.Button();
            this.labelShieldTroopsUpgradeCost = new System.Windows.Forms.Label();
            this.labelSwordTroopsUpgradeCost = new System.Windows.Forms.Label();
            this.buttonSwordTroopsUpgrade = new System.Windows.Forms.Button();
            this.labelRangedTroopsUpgradeCost = new System.Windows.Forms.Label();
            this.buttonRangedTroopsUpgrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelShieldTroopsLevel
            // 
            this.labelShieldTroopsLevel.AutoSize = true;
            this.labelShieldTroopsLevel.Location = new System.Drawing.Point(12, 34);
            this.labelShieldTroopsLevel.Name = "labelShieldTroopsLevel";
            this.labelShieldTroopsLevel.Size = new System.Drawing.Size(173, 13);
            this.labelShieldTroopsLevel.TabIndex = 0;
            this.labelShieldTroopsLevel.Text = "Poziom jednostek defensywnych: 1";
            // 
            // labelSwordTroopsLevel
            // 
            this.labelSwordTroopsLevel.AutoSize = true;
            this.labelSwordTroopsLevel.Location = new System.Drawing.Point(12, 96);
            this.labelSwordTroopsLevel.Name = "labelSwordTroopsLevel";
            this.labelSwordTroopsLevel.Size = new System.Drawing.Size(154, 13);
            this.labelSwordTroopsLevel.TabIndex = 1;
            this.labelSwordTroopsLevel.Text = "Poziom jednostek z mieczem: 1";
            // 
            // labelRangedTroopsLevel
            // 
            this.labelRangedTroopsLevel.AutoSize = true;
            this.labelRangedTroopsLevel.Location = new System.Drawing.Point(12, 158);
            this.labelRangedTroopsLevel.Name = "labelRangedTroopsLevel";
            this.labelRangedTroopsLevel.Size = new System.Drawing.Size(166, 13);
            this.labelRangedTroopsLevel.TabIndex = 2;
            this.labelRangedTroopsLevel.Text = "Poziom jednostek zasięgowych: 1";
            // 
            // buttonUpgradeShieldTroops
            // 
            this.buttonUpgradeShieldTroops.Location = new System.Drawing.Point(215, 27);
            this.buttonUpgradeShieldTroops.Name = "buttonUpgradeShieldTroops";
            this.buttonUpgradeShieldTroops.Size = new System.Drawing.Size(69, 26);
            this.buttonUpgradeShieldTroops.TabIndex = 3;
            this.buttonUpgradeShieldTroops.Text = "Ulepsz";
            this.buttonUpgradeShieldTroops.UseVisualStyleBackColor = true;
            this.buttonUpgradeShieldTroops.Click += new System.EventHandler(this.buttonUpgradeShieldTroops_Click);
            // 
            // labelShieldTroopsUpgradeCost
            // 
            this.labelShieldTroopsUpgradeCost.AutoSize = true;
            this.labelShieldTroopsUpgradeCost.Location = new System.Drawing.Point(290, 27);
            this.labelShieldTroopsUpgradeCost.Name = "labelShieldTroopsUpgradeCost";
            this.labelShieldTroopsUpgradeCost.Size = new System.Drawing.Size(64, 26);
            this.labelShieldTroopsUpgradeCost.TabIndex = 4;
            this.labelShieldTroopsUpgradeCost.Text = "1000 żelaza\r\n2000 złota";
            // 
            // labelSwordTroopsUpgradeCost
            // 
            this.labelSwordTroopsUpgradeCost.AutoSize = true;
            this.labelSwordTroopsUpgradeCost.Location = new System.Drawing.Point(290, 89);
            this.labelSwordTroopsUpgradeCost.Name = "labelSwordTroopsUpgradeCost";
            this.labelSwordTroopsUpgradeCost.Size = new System.Drawing.Size(58, 26);
            this.labelSwordTroopsUpgradeCost.TabIndex = 6;
            this.labelSwordTroopsUpgradeCost.Text = "500 żelaza\r\n2500 złota";
            // 
            // buttonSwordTroopsUpgrade
            // 
            this.buttonSwordTroopsUpgrade.Location = new System.Drawing.Point(215, 89);
            this.buttonSwordTroopsUpgrade.Name = "buttonSwordTroopsUpgrade";
            this.buttonSwordTroopsUpgrade.Size = new System.Drawing.Size(69, 26);
            this.buttonSwordTroopsUpgrade.TabIndex = 5;
            this.buttonSwordTroopsUpgrade.Text = "Ulepsz";
            this.buttonSwordTroopsUpgrade.UseVisualStyleBackColor = true;
            this.buttonSwordTroopsUpgrade.Click += new System.EventHandler(this.buttonSwordTroopsUpgrade_Click);
            // 
            // labelRangedTroopsUpgradeCost
            // 
            this.labelRangedTroopsUpgradeCost.AutoSize = true;
            this.labelRangedTroopsUpgradeCost.Location = new System.Drawing.Point(290, 151);
            this.labelRangedTroopsUpgradeCost.Name = "labelRangedTroopsUpgradeCost";
            this.labelRangedTroopsUpgradeCost.Size = new System.Drawing.Size(69, 26);
            this.labelRangedTroopsUpgradeCost.TabIndex = 8;
            this.labelRangedTroopsUpgradeCost.Text = "1000 drewna\r\n2000 złota";
            // 
            // buttonRangedTroopsUpgrade
            // 
            this.buttonRangedTroopsUpgrade.Location = new System.Drawing.Point(215, 151);
            this.buttonRangedTroopsUpgrade.Name = "buttonRangedTroopsUpgrade";
            this.buttonRangedTroopsUpgrade.Size = new System.Drawing.Size(69, 26);
            this.buttonRangedTroopsUpgrade.TabIndex = 7;
            this.buttonRangedTroopsUpgrade.Text = "Ulepsz";
            this.buttonRangedTroopsUpgrade.UseVisualStyleBackColor = true;
            this.buttonRangedTroopsUpgrade.Click += new System.EventHandler(this.buttonRangedTroopsUpgrade_Click);
            // 
            // FormManageArmy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 205);
            this.Controls.Add(this.labelRangedTroopsUpgradeCost);
            this.Controls.Add(this.buttonRangedTroopsUpgrade);
            this.Controls.Add(this.labelSwordTroopsUpgradeCost);
            this.Controls.Add(this.buttonSwordTroopsUpgrade);
            this.Controls.Add(this.labelShieldTroopsUpgradeCost);
            this.Controls.Add(this.buttonUpgradeShieldTroops);
            this.Controls.Add(this.labelRangedTroopsLevel);
            this.Controls.Add(this.labelSwordTroopsLevel);
            this.Controls.Add(this.labelShieldTroopsLevel);
            this.Name = "FormManageArmy";
            this.Text = "Zarządzanie wojskiem";
            this.Shown += new System.EventHandler(this.FormMarket_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelShieldTroopsLevel;
        private System.Windows.Forms.Label labelSwordTroopsLevel;
        private System.Windows.Forms.Label labelRangedTroopsLevel;
        private System.Windows.Forms.Button buttonUpgradeShieldTroops;
        private System.Windows.Forms.Label labelShieldTroopsUpgradeCost;
        private System.Windows.Forms.Label labelSwordTroopsUpgradeCost;
        private System.Windows.Forms.Button buttonSwordTroopsUpgrade;
        private System.Windows.Forms.Label labelRangedTroopsUpgradeCost;
        private System.Windows.Forms.Button buttonRangedTroopsUpgrade;
    }
}