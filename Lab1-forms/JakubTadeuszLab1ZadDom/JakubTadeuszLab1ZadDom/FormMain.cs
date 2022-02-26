using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JakubTadeuszLab1ZadDom
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// starting population size
        /// </summary>
        const int STARTING_POPULATION = 100;
        /// <summary>
        /// Random class instance
        /// </summary>
        Random random = new Random();
        /// <summary>
        /// simulation day, starts at 1
        /// </summary>
        int day = 1;
        /// <summary>
        /// simulation hour, starts at 8
        /// </summary>
        int hour = 8;
        /// <summary>
        /// simulation minute, starts at 0
        /// </summary>
        int minute = 0;
        /// <summary>
        /// object with simulation Village
        /// </summary>
        Village village;
       
        public FormMain()
        {
            InitializeComponent();
            village = new Village(STARTING_POPULATION);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerGameTime.Start();
            listViewEvents.View = View.Details;
            listViewEvents.HeaderStyle = ColumnHeaderStyle.None;
            listViewEvents.Items.Add("-Rozpoczęto rozgrywkę!");
        }

        /// <summary>
        /// timer handling game time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerGameTime_Tick(object sender, EventArgs e)
        {
            //add one minute
            minute++;
            if(minute == 60)
            {
                minute = 0;
                hour++;
                village.processHourlyVillageChange(hour);
                updateResourceLabels();
                if(random.Next()%10 == 5)
                {
                    string eventResult = EventGenerator.RunNewRandomEvent(village);
                    showEventResultsOnEventsListView(eventResult);
                }
                if (hour == 24)
                {
                    hour = 0;
                    day++;
                }
            }
            labelGameTimeDay.Text = "Day: " + day.ToString();
            labelGameTimeHour.Text = "Time: " + hour.ToString().PadLeft(2) + ":" + minute.ToString("D2"); ;
            //if population is zero, stop simulation
            if (village.population.getPopulationSize() <= 0)
            {
                timerGameTime.Stop();
                showEventResultsOnEventsListView("\n\n\n###Gra zakończona!!! Populacja wioski wynosi 0###");
            }
        }

        /// <summary>
        /// adds new event to the result (ListView) list
        /// </summary>
        /// <param name="eventResult"></param>
        private void showEventResultsOnEventsListView(string eventResult)
        {
            string[] itemsToAddToList = eventResult.Split('\n');
            foreach (string item in itemsToAddToList)
            {
                listViewEvents.Items.Add(item);
            }
            listViewEvents.Items[listViewEvents.Items.Count - 1].EnsureVisible();
        }

        /// <summary>
        /// refresh labels with the village states
        /// </summary>
        private void updateResourceLabels()
        {
            labelVillageLevel.Text = "Poziom wioski: " + village.villageLevel.ToString();
            labelPopulation.Text = "Populacja: " + village.population.getPopulationSize().ToString();
            labelTroops.Text = "Wojsko: " + village.population.army.getArmySize().ToString();
            labelGold.Text = "Złoto: " + village.gold.ToString();
            labelFoodSupply.Text = "Zapasy żywności: " + village.foodSupply.ToString();
            labelWood.Text = "Drewno: " + village.wood.ToString();
            labelIron.Text = "Żelazo: " + village.iron.ToString();
            labelStone.Text = "Kamień: " + village.stone.ToString();
            updateUpgradeLabels();
        }

        /// <summary>
        /// refresh labels with info about upgrades
        /// </summary>
        private void updateUpgradeLabels()
        {
            int goldCost = village.getUpgradeGoldCost();
            int woodCost = village.getUpgradeWoodCost();
            int ironCost = village.getUpgradeIronCost();
            int stoneCost = village.getUpgradeStoneCost();

            bool upgradePossible = true;
            labelUpgradeCostGold.Text = "Złoto: " + goldCost.ToString();
            if (village.gold >= goldCost)
            {
                labelUpgradeCostGold.ForeColor = Color.Green;
            }
            else{ 
                labelUpgradeCostGold.ForeColor = Color.Red;
                 upgradePossible = false;
            }

            labelUpgradeCostWood.Text = "Drewno: " + woodCost.ToString();
            if (village.wood >= woodCost)
            {
                labelUpgradeCostWood.ForeColor = Color.Green;
            }
            else {
                labelUpgradeCostWood.ForeColor = Color.Red;
                upgradePossible = false;
            }

            labelUpgradeCostIron.Text = "Żelazo: " + ironCost.ToString();
            if (village.iron >= ironCost)
            {
                labelUpgradeCostIron.ForeColor = Color.Green;
            }
            else {labelUpgradeCostStone.ForeColor = Color.Red;
                upgradePossible = false;
            }

            labelUpgradeCostStone.Text = "Kamień: " + stoneCost.ToString();
            if (village.stone >= stoneCost)
            {
                labelUpgradeCostStone.ForeColor = Color.Green;
            }
            else {labelUpgradeCostStone.ForeColor = Color.Red;
                upgradePossible = false;
            }

            if (upgradePossible)
            {
                buttonUpgradeVillage.Enabled = true;
                buttonUpgradeVillage.BackColor = Color.Green;
                buttonUpgradeVillage.Text = "Ulepsz wioskę!";
            }
            else
            {
                buttonUpgradeVillage.Enabled = false;
                buttonUpgradeVillage.BackColor = Color.Red;
                buttonUpgradeVillage.Text = "Brak środków!";
            }
        }

        /// <summary>
        /// handle village upgrade button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpgradeVillage_Click(object sender, EventArgs e)
        {
            village.upgradeVillage();
        }

        /// <summary>
        /// handle button to change simulation speed to medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTimeMedium_Click(object sender, EventArgs e)
        {
            timerGameTime.Interval = 10;

            buttonTimeFast.BackColor = Color.Gray;
            buttonTimeMedium.BackColor = Color.DarkCyan;
            buttonTimeSlow.BackColor = Color.Gray;
        }

        /// <summary>
        /// handle button to change simulation speed to slow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTimeSlow_Click(object sender, EventArgs e)
        {
            timerGameTime.Interval = 100;

            buttonTimeFast.BackColor = Color.Gray;
            buttonTimeMedium.BackColor = Color.Gray;
            buttonTimeSlow.BackColor = Color.DarkCyan;
        }

        /// <summary>
        /// handle button to change simulation speed to fast
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTimeFast_Click(object sender, EventArgs e)
        {
            timerGameTime.Interval = 1;

            buttonTimeFast.BackColor = Color.DarkCyan;
            buttonTimeMedium.BackColor = Color.Gray;
            buttonTimeSlow.BackColor = Color.Gray;
        }

        /// <summary>
        /// handle button to show form to manage population
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonManagePopulation_Click(object sender, EventArgs e)
        {
            FormManagePopulation formManagePopulation = new FormManagePopulation();
            //przekazanie populacji do formManagePopulation
            formManagePopulation.population = village.population;
            formManagePopulation.Show();
        }

        /// <summary>
        /// handle button to run the expedition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLaunchExpedition_Click(object sender, EventArgs e)
        {
            string expeditionResult = EventGenerator.RunNewRandomExpedition(village);
            showEventResultsOnEventsListView(expeditionResult);
        }

        /// <summary>
        /// handle button to attack the other village
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLaunchAttack_Click(object sender, EventArgs e)
        {
            string attackResult = EventGenerator.PerformAttackOnOtherVillage(village);
            showEventResultsOnEventsListView(attackResult);
        }

        /// <summary>
        /// handle button to open market form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVisitMarket_Click(object sender, EventArgs e)
        {
            FormMarket formMarket = new FormMarket();
            formMarket.village = village;
            formMarket.Show();
        }

        /// <summary>
        /// handle button to open army management form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonManageArmy_Click(object sender, EventArgs e)
        {
            FormManageArmy formManageArmy = new FormManageArmy();
            formManageArmy.village = village;
            formManageArmy.Show();
        }

    }
}
