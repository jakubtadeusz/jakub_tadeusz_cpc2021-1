
namespace JakubTadeuszLab1ZadDom
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.timerGameTime = new System.Windows.Forms.Timer(this.components);
            this.labelGameTimeDay = new System.Windows.Forms.Label();
            this.labelGameTimeHour = new System.Windows.Forms.Label();
            this.labelPopulation = new System.Windows.Forms.Label();
            this.labelTroops = new System.Windows.Forms.Label();
            this.labelGold = new System.Windows.Forms.Label();
            this.labelFoodSupply = new System.Windows.Forms.Label();
            this.labelWood = new System.Windows.Forms.Label();
            this.labelIron = new System.Windows.Forms.Label();
            this.labelStone = new System.Windows.Forms.Label();
            this.buttonManagePopulation = new System.Windows.Forms.Button();
            this.buttonManageArmy = new System.Windows.Forms.Button();
            this.buttonVisitMarket = new System.Windows.Forms.Button();
            this.buttonLaunchExpedition = new System.Windows.Forms.Button();
            this.buttonLaunchAttack = new System.Windows.Forms.Button();
            this.labelEvents = new System.Windows.Forms.Label();
            this.labelVillageLevel = new System.Windows.Forms.Label();
            this.buttonUpgradeVillage = new System.Windows.Forms.Button();
            this.labelUpgradeCost = new System.Windows.Forms.Label();
            this.labelUpgradeCostGold = new System.Windows.Forms.Label();
            this.labelUpgradeCostWood = new System.Windows.Forms.Label();
            this.labelUpgradeCostIron = new System.Windows.Forms.Label();
            this.labelUpgradeCostStone = new System.Windows.Forms.Label();
            this.buttonTimeSlow = new System.Windows.Forms.Button();
            this.buttonTimeMedium = new System.Windows.Forms.Button();
            this.buttonTimeFast = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewEvents = new System.Windows.Forms.ListView();
            this.columnHeaderEvents = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBoxArmy = new System.Windows.Forms.PictureBox();
            this.pictureBoxPopulation = new System.Windows.Forms.PictureBox();
            this.pictureBoxGold = new System.Windows.Forms.PictureBox();
            this.pictureBoxStone = new System.Windows.Forms.PictureBox();
            this.pictureBoxIron = new System.Windows.Forms.PictureBox();
            this.pictureBoxWood = new System.Windows.Forms.PictureBox();
            this.pictureBoxFood = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArmy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).BeginInit();
            this.SuspendLayout();
            // 
            // timerGameTime
            // 
            this.timerGameTime.Interval = 10;
            this.timerGameTime.Tick += new System.EventHandler(this.timerGameTime_Tick);
            // 
            // labelGameTimeDay
            // 
            this.labelGameTimeDay.AutoSize = true;
            this.labelGameTimeDay.BackColor = System.Drawing.Color.Transparent;
            this.labelGameTimeDay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelGameTimeDay.Location = new System.Drawing.Point(12, 9);
            this.labelGameTimeDay.Name = "labelGameTimeDay";
            this.labelGameTimeDay.Size = new System.Drawing.Size(38, 13);
            this.labelGameTimeDay.TabIndex = 0;
            this.labelGameTimeDay.Text = "Day: 1";
            // 
            // labelGameTimeHour
            // 
            this.labelGameTimeHour.AutoSize = true;
            this.labelGameTimeHour.BackColor = System.Drawing.SystemColors.Info;
            this.labelGameTimeHour.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelGameTimeHour.Location = new System.Drawing.Point(12, 22);
            this.labelGameTimeHour.Name = "labelGameTimeHour";
            this.labelGameTimeHour.Size = new System.Drawing.Size(60, 13);
            this.labelGameTimeHour.TabIndex = 1;
            this.labelGameTimeHour.Text = "Time:  8:00";
            // 
            // labelPopulation
            // 
            this.labelPopulation.AutoSize = true;
            this.labelPopulation.BackColor = System.Drawing.SystemColors.Info;
            this.labelPopulation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPopulation.Location = new System.Drawing.Point(63, 187);
            this.labelPopulation.Name = "labelPopulation";
            this.labelPopulation.Size = new System.Drawing.Size(78, 13);
            this.labelPopulation.TabIndex = 2;
            this.labelPopulation.Text = "Populacja: 100";
            // 
            // labelTroops
            // 
            this.labelTroops.AutoSize = true;
            this.labelTroops.BackColor = System.Drawing.SystemColors.Info;
            this.labelTroops.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTroops.Location = new System.Drawing.Point(63, 225);
            this.labelTroops.Name = "labelTroops";
            this.labelTroops.Size = new System.Drawing.Size(67, 13);
            this.labelTroops.TabIndex = 3;
            this.labelTroops.Text = "Wojsko: 100";
            // 
            // labelGold
            // 
            this.labelGold.AutoSize = true;
            this.labelGold.BackColor = System.Drawing.SystemColors.Info;
            this.labelGold.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelGold.Location = new System.Drawing.Point(63, 263);
            this.labelGold.Name = "labelGold";
            this.labelGold.Size = new System.Drawing.Size(57, 13);
            this.labelGold.TabIndex = 5;
            this.labelGold.Text = "Złoto: 100";
            // 
            // labelFoodSupply
            // 
            this.labelFoodSupply.AutoSize = true;
            this.labelFoodSupply.BackColor = System.Drawing.SystemColors.Info;
            this.labelFoodSupply.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelFoodSupply.Location = new System.Drawing.Point(63, 301);
            this.labelFoodSupply.Name = "labelFoodSupply";
            this.labelFoodSupply.Size = new System.Drawing.Size(112, 13);
            this.labelFoodSupply.TabIndex = 6;
            this.labelFoodSupply.Text = "Zapasy żywności: 100";
            // 
            // labelWood
            // 
            this.labelWood.AutoSize = true;
            this.labelWood.BackColor = System.Drawing.SystemColors.Info;
            this.labelWood.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelWood.Location = new System.Drawing.Point(63, 339);
            this.labelWood.Name = "labelWood";
            this.labelWood.Size = new System.Drawing.Size(68, 13);
            this.labelWood.TabIndex = 7;
            this.labelWood.Text = "Drewno: 100";
            // 
            // labelIron
            // 
            this.labelIron.AutoSize = true;
            this.labelIron.BackColor = System.Drawing.SystemColors.Info;
            this.labelIron.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelIron.Location = new System.Drawing.Point(63, 377);
            this.labelIron.Name = "labelIron";
            this.labelIron.Size = new System.Drawing.Size(63, 13);
            this.labelIron.TabIndex = 8;
            this.labelIron.Text = "Żelazo: 100";
            // 
            // labelStone
            // 
            this.labelStone.AutoSize = true;
            this.labelStone.BackColor = System.Drawing.SystemColors.Info;
            this.labelStone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelStone.Location = new System.Drawing.Point(63, 415);
            this.labelStone.Name = "labelStone";
            this.labelStone.Size = new System.Drawing.Size(66, 13);
            this.labelStone.TabIndex = 9;
            this.labelStone.Text = "Kamień: 100";
            // 
            // buttonManagePopulation
            // 
            this.buttonManagePopulation.Location = new System.Drawing.Point(688, 80);
            this.buttonManagePopulation.Name = "buttonManagePopulation";
            this.buttonManagePopulation.Size = new System.Drawing.Size(90, 38);
            this.buttonManagePopulation.TabIndex = 19;
            this.buttonManagePopulation.Text = "Zarządzaj mieszkańcami";
            this.buttonManagePopulation.UseVisualStyleBackColor = true;
            this.buttonManagePopulation.Click += new System.EventHandler(this.buttonManagePopulation_Click);
            // 
            // buttonManageArmy
            // 
            this.buttonManageArmy.Location = new System.Drawing.Point(688, 146);
            this.buttonManageArmy.Name = "buttonManageArmy";
            this.buttonManageArmy.Size = new System.Drawing.Size(90, 38);
            this.buttonManageArmy.TabIndex = 20;
            this.buttonManageArmy.Text = "Zarządzaj wojskiem";
            this.buttonManageArmy.UseVisualStyleBackColor = true;
            this.buttonManageArmy.Click += new System.EventHandler(this.buttonManageArmy_Click);
            // 
            // buttonVisitMarket
            // 
            this.buttonVisitMarket.Location = new System.Drawing.Point(688, 212);
            this.buttonVisitMarket.Name = "buttonVisitMarket";
            this.buttonVisitMarket.Size = new System.Drawing.Size(90, 38);
            this.buttonVisitMarket.TabIndex = 21;
            this.buttonVisitMarket.Text = "Odwiedź targowisko";
            this.buttonVisitMarket.UseVisualStyleBackColor = true;
            this.buttonVisitMarket.Click += new System.EventHandler(this.buttonVisitMarket_Click);
            // 
            // buttonLaunchExpedition
            // 
            this.buttonLaunchExpedition.Location = new System.Drawing.Point(688, 278);
            this.buttonLaunchExpedition.Name = "buttonLaunchExpedition";
            this.buttonLaunchExpedition.Size = new System.Drawing.Size(90, 38);
            this.buttonLaunchExpedition.TabIndex = 22;
            this.buttonLaunchExpedition.Text = "Wyrusz na ekspedycję!";
            this.buttonLaunchExpedition.UseVisualStyleBackColor = true;
            this.buttonLaunchExpedition.Click += new System.EventHandler(this.buttonLaunchExpedition_Click);
            // 
            // buttonLaunchAttack
            // 
            this.buttonLaunchAttack.Location = new System.Drawing.Point(688, 344);
            this.buttonLaunchAttack.Name = "buttonLaunchAttack";
            this.buttonLaunchAttack.Size = new System.Drawing.Size(90, 38);
            this.buttonLaunchAttack.TabIndex = 23;
            this.buttonLaunchAttack.Text = "Zaatakuj inną wioskę";
            this.buttonLaunchAttack.UseVisualStyleBackColor = true;
            this.buttonLaunchAttack.Click += new System.EventHandler(this.buttonLaunchAttack_Click);
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.BackColor = System.Drawing.SystemColors.Info;
            this.labelEvents.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEvents.Location = new System.Drawing.Point(207, 22);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(57, 13);
            this.labelEvents.TabIndex = 24;
            this.labelEvents.Text = "Zdarzenia:";
            // 
            // labelVillageLevel
            // 
            this.labelVillageLevel.AutoSize = true;
            this.labelVillageLevel.BackColor = System.Drawing.SystemColors.Info;
            this.labelVillageLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelVillageLevel.Location = new System.Drawing.Point(63, 52);
            this.labelVillageLevel.Name = "labelVillageLevel";
            this.labelVillageLevel.Size = new System.Drawing.Size(85, 13);
            this.labelVillageLevel.TabIndex = 26;
            this.labelVillageLevel.Text = "Poziom wioski: 1";
            // 
            // buttonUpgradeVillage
            // 
            this.buttonUpgradeVillage.BackColor = System.Drawing.Color.Transparent;
            this.buttonUpgradeVillage.Location = new System.Drawing.Point(25, 80);
            this.buttonUpgradeVillage.Name = "buttonUpgradeVillage";
            this.buttonUpgradeVillage.Size = new System.Drawing.Size(138, 25);
            this.buttonUpgradeVillage.TabIndex = 28;
            this.buttonUpgradeVillage.Text = "Ulepsz wioskę!";
            this.buttonUpgradeVillage.UseVisualStyleBackColor = false;
            this.buttonUpgradeVillage.Click += new System.EventHandler(this.buttonUpgradeVillage_Click);
            // 
            // labelUpgradeCost
            // 
            this.labelUpgradeCost.AutoSize = true;
            this.labelUpgradeCost.BackColor = System.Drawing.SystemColors.Info;
            this.labelUpgradeCost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelUpgradeCost.Location = new System.Drawing.Point(22, 105);
            this.labelUpgradeCost.Name = "labelUpgradeCost";
            this.labelUpgradeCost.Size = new System.Drawing.Size(39, 13);
            this.labelUpgradeCost.TabIndex = 29;
            this.labelUpgradeCost.Text = "Koszt: ";
            // 
            // labelUpgradeCostGold
            // 
            this.labelUpgradeCostGold.AutoSize = true;
            this.labelUpgradeCostGold.BackColor = System.Drawing.SystemColors.Info;
            this.labelUpgradeCostGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUpgradeCostGold.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelUpgradeCostGold.Location = new System.Drawing.Point(23, 118);
            this.labelUpgradeCostGold.Name = "labelUpgradeCostGold";
            this.labelUpgradeCostGold.Size = new System.Drawing.Size(46, 12);
            this.labelUpgradeCostGold.TabIndex = 30;
            this.labelUpgradeCostGold.Text = "Złoto: 100";
            // 
            // labelUpgradeCostWood
            // 
            this.labelUpgradeCostWood.AutoSize = true;
            this.labelUpgradeCostWood.BackColor = System.Drawing.SystemColors.Info;
            this.labelUpgradeCostWood.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUpgradeCostWood.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelUpgradeCostWood.Location = new System.Drawing.Point(23, 130);
            this.labelUpgradeCostWood.Name = "labelUpgradeCostWood";
            this.labelUpgradeCostWood.Size = new System.Drawing.Size(58, 12);
            this.labelUpgradeCostWood.TabIndex = 31;
            this.labelUpgradeCostWood.Text = "Drewno: 100";
            // 
            // labelUpgradeCostIron
            // 
            this.labelUpgradeCostIron.AutoSize = true;
            this.labelUpgradeCostIron.BackColor = System.Drawing.SystemColors.Info;
            this.labelUpgradeCostIron.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUpgradeCostIron.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelUpgradeCostIron.Location = new System.Drawing.Point(23, 143);
            this.labelUpgradeCostIron.Name = "labelUpgradeCostIron";
            this.labelUpgradeCostIron.Size = new System.Drawing.Size(53, 12);
            this.labelUpgradeCostIron.TabIndex = 32;
            this.labelUpgradeCostIron.Text = "Żelazo: 100";
            // 
            // labelUpgradeCostStone
            // 
            this.labelUpgradeCostStone.AutoSize = true;
            this.labelUpgradeCostStone.BackColor = System.Drawing.SystemColors.Info;
            this.labelUpgradeCostStone.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUpgradeCostStone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelUpgradeCostStone.Location = new System.Drawing.Point(23, 155);
            this.labelUpgradeCostStone.Name = "labelUpgradeCostStone";
            this.labelUpgradeCostStone.Size = new System.Drawing.Size(56, 12);
            this.labelUpgradeCostStone.TabIndex = 33;
            this.labelUpgradeCostStone.Text = "Kamień: 100";
            // 
            // buttonTimeSlow
            // 
            this.buttonTimeSlow.BackColor = System.Drawing.Color.Gray;
            this.buttonTimeSlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTimeSlow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTimeSlow.Location = new System.Drawing.Point(102, 9);
            this.buttonTimeSlow.Name = "buttonTimeSlow";
            this.buttonTimeSlow.Size = new System.Drawing.Size(27, 23);
            this.buttonTimeSlow.TabIndex = 34;
            this.buttonTimeSlow.Text = ">";
            this.buttonTimeSlow.UseVisualStyleBackColor = false;
            this.buttonTimeSlow.Click += new System.EventHandler(this.buttonTimeSlow_Click);
            // 
            // buttonTimeMedium
            // 
            this.buttonTimeMedium.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonTimeMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTimeMedium.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonTimeMedium.Location = new System.Drawing.Point(135, 9);
            this.buttonTimeMedium.Name = "buttonTimeMedium";
            this.buttonTimeMedium.Size = new System.Drawing.Size(27, 23);
            this.buttonTimeMedium.TabIndex = 35;
            this.buttonTimeMedium.Text = ">>";
            this.buttonTimeMedium.UseVisualStyleBackColor = false;
            this.buttonTimeMedium.Click += new System.EventHandler(this.buttonTimeMedium_Click);
            // 
            // buttonTimeFast
            // 
            this.buttonTimeFast.BackColor = System.Drawing.Color.Gray;
            this.buttonTimeFast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTimeFast.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonTimeFast.Location = new System.Drawing.Point(168, 9);
            this.buttonTimeFast.Name = "buttonTimeFast";
            this.buttonTimeFast.Size = new System.Drawing.Size(33, 23);
            this.buttonTimeFast.TabIndex = 36;
            this.buttonTimeFast.Text = ">>>";
            this.buttonTimeFast.UseVisualStyleBackColor = false;
            this.buttonTimeFast.Click += new System.EventHandler(this.buttonTimeFast_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JakubTadeuszLab1ZadDom.Properties.Resources.dngn_closed_door;
            this.pictureBox1.Location = new System.Drawing.Point(25, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // listViewEvents
            // 
            this.listViewEvents.BackgroundImage = global::JakubTadeuszLab1ZadDom.Properties.Resources.eventsBackground;
            this.listViewEvents.BackgroundImageTiled = true;
            this.listViewEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderEvents});
            this.listViewEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.listViewEvents.ForeColor = System.Drawing.Color.White;
            this.listViewEvents.HideSelection = false;
            this.listViewEvents.LabelWrap = false;
            this.listViewEvents.Location = new System.Drawing.Point(210, 38);
            this.listViewEvents.Name = "listViewEvents";
            this.listViewEvents.Size = new System.Drawing.Size(450, 400);
            this.listViewEvents.TabIndex = 25;
            this.listViewEvents.UseCompatibleStateImageBehavior = false;
            this.listViewEvents.View = System.Windows.Forms.View.List;
            // 
            // columnHeaderEvents
            // 
            this.columnHeaderEvents.Width = 440;
            // 
            // pictureBoxArmy
            // 
            this.pictureBoxArmy.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxArmy.Image = global::JakubTadeuszLab1ZadDom.Properties.Resources.dwarven_ringmail;
            this.pictureBoxArmy.Location = new System.Drawing.Point(25, 215);
            this.pictureBoxArmy.Name = "pictureBoxArmy";
            this.pictureBoxArmy.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxArmy.TabIndex = 18;
            this.pictureBoxArmy.TabStop = false;
            // 
            // pictureBoxPopulation
            // 
            this.pictureBoxPopulation.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPopulation.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPopulation.ErrorImage")));
            this.pictureBoxPopulation.Image = global::JakubTadeuszLab1ZadDom.Properties.Resources.demigod_m;
            this.pictureBoxPopulation.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPopulation.InitialImage")));
            this.pictureBoxPopulation.Location = new System.Drawing.Point(25, 177);
            this.pictureBoxPopulation.Name = "pictureBoxPopulation";
            this.pictureBoxPopulation.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxPopulation.TabIndex = 16;
            this.pictureBoxPopulation.TabStop = false;
            // 
            // pictureBoxGold
            // 
            this.pictureBoxGold.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGold.Image = global::JakubTadeuszLab1ZadDom.Properties.Resources.gold_pile;
            this.pictureBoxGold.Location = new System.Drawing.Point(25, 253);
            this.pictureBoxGold.Name = "pictureBoxGold";
            this.pictureBoxGold.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxGold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGold.TabIndex = 15;
            this.pictureBoxGold.TabStop = false;
            // 
            // pictureBoxStone
            // 
            this.pictureBoxStone.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStone.Image = global::JakubTadeuszLab1ZadDom.Properties.Resources.misc_stone;
            this.pictureBoxStone.Location = new System.Drawing.Point(25, 405);
            this.pictureBoxStone.Name = "pictureBoxStone";
            this.pictureBoxStone.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxStone.TabIndex = 14;
            this.pictureBoxStone.TabStop = false;
            // 
            // pictureBoxIron
            // 
            this.pictureBoxIron.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxIron.Image = global::JakubTadeuszLab1ZadDom.Properties.Resources.misc_deck;
            this.pictureBoxIron.Location = new System.Drawing.Point(25, 367);
            this.pictureBoxIron.Name = "pictureBoxIron";
            this.pictureBoxIron.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxIron.TabIndex = 13;
            this.pictureBoxIron.TabStop = false;
            // 
            // pictureBoxWood
            // 
            this.pictureBoxWood.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWood.Image = global::JakubTadeuszLab1ZadDom.Properties.Resources.hand_axe1;
            this.pictureBoxWood.Location = new System.Drawing.Point(25, 329);
            this.pictureBoxWood.Name = "pictureBoxWood";
            this.pictureBoxWood.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxWood.TabIndex = 12;
            this.pictureBoxWood.TabStop = false;
            // 
            // pictureBoxFood
            // 
            this.pictureBoxFood.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFood.Image = global::JakubTadeuszLab1ZadDom.Properties.Resources.chunk;
            this.pictureBoxFood.Location = new System.Drawing.Point(25, 291);
            this.pictureBoxFood.Name = "pictureBoxFood";
            this.pictureBoxFood.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxFood.TabIndex = 11;
            this.pictureBoxFood.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTimeFast);
            this.Controls.Add(this.buttonTimeMedium);
            this.Controls.Add(this.buttonTimeSlow);
            this.Controls.Add(this.labelUpgradeCostStone);
            this.Controls.Add(this.labelUpgradeCostIron);
            this.Controls.Add(this.labelUpgradeCostWood);
            this.Controls.Add(this.labelUpgradeCostGold);
            this.Controls.Add(this.labelUpgradeCost);
            this.Controls.Add(this.buttonUpgradeVillage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelVillageLevel);
            this.Controls.Add(this.listViewEvents);
            this.Controls.Add(this.labelEvents);
            this.Controls.Add(this.buttonLaunchAttack);
            this.Controls.Add(this.buttonLaunchExpedition);
            this.Controls.Add(this.buttonVisitMarket);
            this.Controls.Add(this.buttonManageArmy);
            this.Controls.Add(this.buttonManagePopulation);
            this.Controls.Add(this.pictureBoxArmy);
            this.Controls.Add(this.pictureBoxPopulation);
            this.Controls.Add(this.pictureBoxGold);
            this.Controls.Add(this.pictureBoxStone);
            this.Controls.Add(this.pictureBoxIron);
            this.Controls.Add(this.pictureBoxWood);
            this.Controls.Add(this.pictureBoxFood);
            this.Controls.Add(this.labelStone);
            this.Controls.Add(this.labelIron);
            this.Controls.Add(this.labelWood);
            this.Controls.Add(this.labelFoodSupply);
            this.Controls.Add(this.labelGold);
            this.Controls.Add(this.labelTroops);
            this.Controls.Add(this.labelPopulation);
            this.Controls.Add(this.labelGameTimeHour);
            this.Controls.Add(this.labelGameTimeDay);
            this.Name = "FormMain";
            this.Text = "Dont let villagers starve";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArmy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerGameTime;
        private System.Windows.Forms.Label labelGameTimeDay;
        private System.Windows.Forms.Label labelGameTimeHour;
        private System.Windows.Forms.Label labelPopulation;
        private System.Windows.Forms.Label labelTroops;
        private System.Windows.Forms.Label labelGold;
        private System.Windows.Forms.Label labelFoodSupply;
        private System.Windows.Forms.Label labelWood;
        private System.Windows.Forms.Label labelIron;
        private System.Windows.Forms.Label labelStone;
        private System.Windows.Forms.PictureBox pictureBoxFood;
        private System.Windows.Forms.PictureBox pictureBoxWood;
        private System.Windows.Forms.PictureBox pictureBoxIron;
        private System.Windows.Forms.PictureBox pictureBoxStone;
        private System.Windows.Forms.PictureBox pictureBoxGold;
        private System.Windows.Forms.PictureBox pictureBoxPopulation;
        private System.Windows.Forms.PictureBox pictureBoxArmy;
        private System.Windows.Forms.Button buttonManagePopulation;
        private System.Windows.Forms.Button buttonManageArmy;
        private System.Windows.Forms.Button buttonVisitMarket;
        private System.Windows.Forms.Button buttonLaunchExpedition;
        private System.Windows.Forms.Button buttonLaunchAttack;
        private System.Windows.Forms.Label labelEvents;
        private System.Windows.Forms.Label labelVillageLevel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonUpgradeVillage;
        private System.Windows.Forms.Label labelUpgradeCost;
        private System.Windows.Forms.Label labelUpgradeCostGold;
        private System.Windows.Forms.Label labelUpgradeCostWood;
        private System.Windows.Forms.Label labelUpgradeCostIron;
        private System.Windows.Forms.Label labelUpgradeCostStone;
        private System.Windows.Forms.ListView listViewEvents;
        private System.Windows.Forms.Button buttonTimeSlow;
        private System.Windows.Forms.Button buttonTimeMedium;
        private System.Windows.Forms.Button buttonTimeFast;
        private System.Windows.Forms.ColumnHeader columnHeaderEvents;
    }
}

