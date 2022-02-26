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
    public partial class FormManageArmy : Form
    {
        /// <summary>
        /// consts to calculate troops cost
        /// </summary>
        const int SPECIALIZED_TROOP_COST_MULTIPLIER = 1000;
        const int NORMAL_TROOP_COST_MULTIPLIER = 1000;
        const int TROOP_GOLD_COST_MULTIPLIER = 2;
        /// <summary>
        /// village that is the army owner
        /// </summary>
        internal Village village;
        public FormManageArmy()
        {
            InitializeComponent();
        }

        private void FormMarket_Shown(object sender, EventArgs e)
        {
            refreshArmyLabels();
        }

        /// <summary>
        /// refresh labels with troops amount and purchase costs
        /// </summary>
        private void refreshArmyLabels()
        {
            labelShieldTroopsLevel.Text = "Poziom jednostek defensywnych: " + village.population.army.shieldTroopsLevel.ToString();
            labelSwordTroopsLevel.Text = "Poziom jednostek z mieczem: " + village.population.army.swordTroopsLevel.ToString();
            labelRangedTroopsLevel.Text = "Poziom jednostek zasięgowych: " + village.population.army.rangedTroopsLevel.ToString();

            labelShieldTroopsUpgradeCost.Text =
                (village.population.army.shieldTroopsLevel * SPECIALIZED_TROOP_COST_MULTIPLIER).ToString() + " żelaza\n"
                + (village.population.army.shieldTroopsLevel * SPECIALIZED_TROOP_COST_MULTIPLIER * TROOP_GOLD_COST_MULTIPLIER).ToString() + " złota";

            labelSwordTroopsUpgradeCost.Text =
                (village.population.army.swordTroopsLevel * NORMAL_TROOP_COST_MULTIPLIER).ToString() + " żelaza\n"
                + (village.population.army.swordTroopsLevel * NORMAL_TROOP_COST_MULTIPLIER * TROOP_GOLD_COST_MULTIPLIER).ToString() + " złota";

            labelRangedTroopsUpgradeCost.Text =
                (village.population.army.rangedTroopsLevel * SPECIALIZED_TROOP_COST_MULTIPLIER).ToString() + " drewna\n"
             + (village.population.army.rangedTroopsLevel * SPECIALIZED_TROOP_COST_MULTIPLIER * TROOP_GOLD_COST_MULTIPLIER).ToString() + " złota";

            if (canUpgradeShieldTroops())
            {
                enableUpgrade(buttonUpgradeShieldTroops, labelShieldTroopsUpgradeCost);
            }
            else
            {
                disableUpgrade(buttonUpgradeShieldTroops, labelShieldTroopsUpgradeCost);
            }

            if (canUpgradeSwordTroops())
            {
                enableUpgrade(buttonSwordTroopsUpgrade, labelSwordTroopsUpgradeCost);
            }
            else
            {
                disableUpgrade(buttonSwordTroopsUpgrade, labelSwordTroopsUpgradeCost);
            }

            if (canUpgradeRangedTroops())
            {
                enableUpgrade(buttonRangedTroopsUpgrade, labelRangedTroopsUpgradeCost);
            }
            else
            {
                disableUpgrade(buttonRangedTroopsUpgrade, labelRangedTroopsUpgradeCost);
            }
        }

        /// <summary>
        /// disable troop upgrade cost
        /// </summary>
        /// <param name="buttonTroopsUpgrade"></param>
        /// <param name="labelTroopsUpgradeCost"></param>
        void disableUpgrade(Button buttonTroopsUpgrade, Label labelTroopsUpgradeCost)
        {
            buttonTroopsUpgrade.Enabled = false;
            buttonRangedTroopsUpgrade.BackColor = Color.Red;
            labelRangedTroopsLevel.ForeColor = Color.Red;
        }

        /// <summary>
        /// enable troop upgrade cost
        /// </summary>
        /// <param name="buttonTroopsUpgrade"></param>
        /// <param name="labelTroopsUpgradeCost"></param>
        void enableUpgrade(Button buttonTroopsUpgrade, Label labelTroopsUpgradeCost)
        {
            buttonTroopsUpgrade.Enabled = true;
            buttonRangedTroopsUpgrade.BackColor = Color.Green;
            labelRangedTroopsLevel.ForeColor = Color.Green;
        }

        /// <summary>
        /// check if there is enough materials to upgrade ranged troops
        /// </summary>
        /// <returns></returns>
        private bool canUpgradeRangedTroops()
        {
            return village.gold >= (village.population.army.rangedTroopsLevel * SPECIALIZED_TROOP_COST_MULTIPLIER * TROOP_GOLD_COST_MULTIPLIER)
                 && village.wood >= (village.population.army.rangedTroopsLevel * SPECIALIZED_TROOP_COST_MULTIPLIER);
        }

        /// <summary>
        /// check if there is enough materials to upgrade sword troops
        /// </summary>
        /// <returns></returns>
        private bool canUpgradeSwordTroops()
        {
            return village.gold >= (village.population.army.swordTroopsLevel * NORMAL_TROOP_COST_MULTIPLIER * TROOP_GOLD_COST_MULTIPLIER)
                 && village.iron >= (village.population.army.swordTroopsLevel * NORMAL_TROOP_COST_MULTIPLIER);
        }

        /// <summary>
        /// check if there is enough materials to upgrade shield troops
        /// </summary>
        /// <returns></returns>
        private bool canUpgradeShieldTroops()
        {
            return village.gold >= (village.population.army.shieldTroopsLevel * SPECIALIZED_TROOP_COST_MULTIPLIER * TROOP_GOLD_COST_MULTIPLIER)
                && village.iron >= (village.population.army.shieldTroopsLevel * SPECIALIZED_TROOP_COST_MULTIPLIER);
        }

        /// <summary>
        /// handle shield troops upgrade button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpgradeShieldTroops_Click(object sender, EventArgs e)
        {
            village.gold -= (village.population.army.shieldTroopsLevel * SPECIALIZED_TROOP_COST_MULTIPLIER * TROOP_GOLD_COST_MULTIPLIER);
            village.iron -= (village.population.army.shieldTroopsLevel * SPECIALIZED_TROOP_COST_MULTIPLIER);
            village.population.army.shieldTroopsLevel++;
            refreshArmyLabels();
        }

        /// <summary>
        /// handle sword troops upgrade button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSwordTroopsUpgrade_Click(object sender, EventArgs e)
        {
            village.gold -= (village.population.army.swordTroopsLevel * NORMAL_TROOP_COST_MULTIPLIER * TROOP_GOLD_COST_MULTIPLIER);
            village.iron -= (village.population.army.swordTroopsLevel * NORMAL_TROOP_COST_MULTIPLIER);
            village.population.army.swordTroopsLevel++;
            refreshArmyLabels();
        }

        /// <summary>
        /// handle ranged troops upgrade button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRangedTroopsUpgrade_Click(object sender, EventArgs e)
        {
            village.gold -= (village.population.army.rangedTroopsLevel * SPECIALIZED_TROOP_COST_MULTIPLIER * TROOP_GOLD_COST_MULTIPLIER);
            village.wood -= (village.population.army.rangedTroopsLevel * SPECIALIZED_TROOP_COST_MULTIPLIER);
            village.population.army.rangedTroopsLevel++;
            refreshArmyLabels();
        }
    }
}
