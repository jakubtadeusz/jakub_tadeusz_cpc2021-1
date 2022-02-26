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
    public partial class FormManagePopulation : Form
    {
        /// <summary>
        /// population of village this form manages
        /// </summary>
        internal Population population;
        public FormManagePopulation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// handles traders employement button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEmployTraders_Click(object sender, EventArgs e)
        {
            population.traders += trackBarEmploy.Value;
            population.unemployed -= trackBarEmploy.Value;
            refreshLabels();
        }

        /// <summary>
        /// handles lumberjacks employement button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEmployLumberjacks_Click(object sender, EventArgs e)
        {
            population.lumberjacks += trackBarEmploy.Value;
            population.unemployed -= trackBarEmploy.Value;
            refreshLabels();
        }

        /// <summary>
        /// handles food suppliers employement button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEmployFoodSuppliers_Click(object sender, EventArgs e)
        {
            population.foodSuppliers += trackBarEmploy.Value;
            population.unemployed -= trackBarEmploy.Value;
            refreshLabels();
        }

        /// <summary>
        /// handles miners employement button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEmployMiners_Click(object sender, EventArgs e)
        {
            population.miners += trackBarEmploy.Value;
            population.unemployed -= trackBarEmploy.Value;
            refreshLabels();
        }

        /// <summary>
        /// handles army troops employement button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEmployTroops_Click(object sender, EventArgs e)
        {
            population.army.recruitTroops(trackBarEmploy.Value);
            population.unemployed -= trackBarEmploy.Value;
            refreshLabels();
        }

        private void FormManagePopulation_Shown(object sender, EventArgs e)
        {
            refreshLabels();
        }

        /// <summary>
        /// refreshes labels with the workers amount in the population
        /// </summary>
        private void refreshLabels()
        {
            if (population != null)
            {
                labelTraders.Text = "Handlowcy: " + population.traders.ToString();
                labelLumberjacks.Text = "Drwale: " + population.lumberjacks.ToString();
                labelFoodSuppliers.Text = "Dostawcy żywności: " + population.foodSuppliers.ToString();
                labelMiners.Text = "Górnicy: " + population.miners.ToString();
                labelTroops.Text = "Żołnierze: " + population.army.getArmySize();
                labelUnemployed.Text = "Bezrobotni: " + population.unemployed.ToString();
                trackBarEmploy.Maximum = population.unemployed;
            }
        }

    }
}
