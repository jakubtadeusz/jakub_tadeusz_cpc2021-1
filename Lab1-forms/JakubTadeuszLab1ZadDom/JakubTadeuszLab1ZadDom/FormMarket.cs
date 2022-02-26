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
    public partial class FormMarket : Form
    {
        /// <summary>
        /// Village that entered the market
        /// </summary>
        internal Village village;
       
        public FormMarket()
        {
            InitializeComponent();
        }


        /// <summary>
        /// refresh gold label
        /// </summary>
        private void refreshGoldLabel()
        {
            labelGold.Text = "Złoto: " + village.gold.ToString();
            //maximum amount of material you can buy is gold/10
            trackBarBoughtAmount.Maximum = village.gold / 10;
        }
        private void FormMarket_Shown(object sender, EventArgs e)
        {
            if(village != null)
            {
                refreshGoldLabel();
            }
        }

        /// <summary>
        /// handles button used to buy food
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyFood_Click(object sender, EventArgs e)
        {
            village.foodSupply += trackBarBoughtAmount.Value;
            village.gold -= trackBarBoughtAmount.Value * 10;
            refreshGoldLabel();
        }

        /// <summary>
        /// handles button used to buy wood
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyWood_Click(object sender, EventArgs e)
        {
            village.wood += trackBarBoughtAmount.Value;
            village.gold -= trackBarBoughtAmount.Value * 10;
            refreshGoldLabel();
        }

        /// <summary>
        /// handles button used to buy stone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyStone_Click(object sender, EventArgs e)
        {
            village.stone += trackBarBoughtAmount.Value;
            village.gold -= trackBarBoughtAmount.Value * 10;
            refreshGoldLabel();
        }

        /// <summary>
        /// handles button used to buy iron
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyIron_Click(object sender, EventArgs e)
        {
            village.iron += trackBarBoughtAmount.Value;
            village.gold -= trackBarBoughtAmount.Value * 10;
            refreshGoldLabel();
        }
    }
}
