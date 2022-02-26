using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubTadeuszLab1ZadDom
{
    /// <summary>
    /// Class that stores the Village state
    /// </summary>
    class Village
    {

        /// <summary>
        /// Constant telling how much of the easy supply you gain
        /// </summary>
        public const int EASY_SUPPLY_FACTOR = 30;
        /// <summary>
        /// Constant telling how much of the medium supply you gain
        /// </summary>
        const int MEDIUM_SUPPLY_FACTOR = 10;
        /// <summary>
        /// Constant telling how much of the hard supply you gain
        /// </summary>
        const int HARD_SUPPLY_FACTOR = 5;
        /// <summary>
        /// Constant with daily food consumption
        /// </summary>
        const int FOOD_CONSUMPTION_DAY = 2;
        /// <summary>
        /// Constant with food consumption at night
        /// </summary>
        const int FOOD_CONSUMPTION_NIGHT = 1;
        /// <summary>
        /// Constant telling how much unemployed village gains per day
        /// </summary>
        public const int NEW_UNEMPLOYED_FACTOR = 1;
        /// <summary>
        /// Modifier used to calculate village upgrade stone cost
        /// </summary>
        const int UPGRADE_MODIFIER_STONE = 2000;
        /// <summary>
        /// Modifier used to calculate village upgrade wood cost
        /// </summary>
        const int UPGRADE_MODIFIER_WOOD = 5000;
        /// <summary>
        /// Modifier used to calculate village upgrade gold cost
        /// </summary>
        const int UPGRADE_MODIFIER_GOLD = 10000;
        /// <summary>
        /// Modifier used to calculate village upgrade iron cost
        /// </summary>
        const int UPGRADE_MODIFIER_IRON = 1000;
        /// <summary>
        /// Village level
        /// </summary>
        public int villageLevel { get; set; }
        /// <summary>
        /// Village population
        /// </summary>
        public Population population { get; set; }

        /// <summary>
        /// Amount of gold village currently have
        /// </summary>
        public int gold { get; set; }
        /// <summary>
        /// Amount of food in village 
        /// </summary>
        public int foodSupply { get; set; }
        /// <summary>
        /// Amount of wood
        /// </summary>
        public int wood { get; set; }
        /// <summary>
        /// Amount of iron
        /// </summary>
        public int iron { get; set; }
        /// <summary>
        /// Amount of stone
        /// </summary>
        public int stone { get; set; }
        

        /// <summary>
        /// creates village with (int) population size
        /// </summary>
        /// <param name="populationSize"></param>
        public Village(int populationSize)
        {
            villageLevel = 1;
            population = new Population(populationSize);
            gold = populationSize * EASY_SUPPLY_FACTOR;
            wood = populationSize * MEDIUM_SUPPLY_FACTOR;
            iron = populationSize * HARD_SUPPLY_FACTOR;
            stone = populationSize * MEDIUM_SUPPLY_FACTOR;
            foodSupply = populationSize * EASY_SUPPLY_FACTOR;
        }
        /// <summary>
        /// process village changes given hour
        /// </summary>
        /// <param name="hour"></param>
        internal void processHourlyVillageChange(int hour)
        {
            int foodConsumption;
            //check if the workday (hour is between 8 and 20)
            if (hour >= 8 && hour <= 20)
            {
                //amount of materials village gets depends of the number of workers working to get the material
                gold += population.traders * EASY_SUPPLY_FACTOR * villageLevel;
                wood += population.lumberjacks * MEDIUM_SUPPLY_FACTOR * villageLevel;
                iron += population.miners * HARD_SUPPLY_FACTOR * villageLevel;
                stone += population.miners * MEDIUM_SUPPLY_FACTOR * villageLevel;
                foodSupply += population.foodSuppliers * EASY_SUPPLY_FACTOR * villageLevel;
                foodConsumption = FOOD_CONSUMPTION_DAY;
            }
            else
            {
                foodConsumption = FOOD_CONSUMPTION_NIGHT;
            }
            foodSupply -= population.getPopulationSize() * foodConsumption;
            population.unemployed += NEW_UNEMPLOYED_FACTOR * villageLevel;
            if(foodSupply < 0)
            {
                //If there is not enough food, part of the population is getting killed
                population.kill(-foodSupply*foodConsumption);
            }
        }

        /// <summary>
        /// return amount of stone village needs to upgrade
        /// </summary>
        /// <returns></returns>
        internal int getUpgradeStoneCost()
        {
            return villageLevel * UPGRADE_MODIFIER_STONE;
        }

        /// <summary>
        /// return amount of iron village needs to upgrade
        /// </summary>
        /// <returns></returns>
        internal int getUpgradeIronCost()
        {
            return villageLevel * UPGRADE_MODIFIER_IRON;
        }

        /// <summary>
        /// return amount of wood village needs to upgrade
        /// </summary>
        /// <returns></returns>
        internal int getUpgradeWoodCost()
        {
            return villageLevel * UPGRADE_MODIFIER_WOOD;
        }

        /// <summary>
        /// return amount of gold village needs to upgrade
        /// </summary>
        /// <returns></returns>
        internal int getUpgradeGoldCost()
        {
            return villageLevel * UPGRADE_MODIFIER_GOLD;
        }

        /// <summary>
        /// upgrade village to the next level
        /// </summary>
        internal void upgradeVillage()
        {
            villageLevel += 1;
            gold -= getUpgradeGoldCost();
            wood -= getUpgradeWoodCost();
            iron -= getUpgradeIronCost();
            stone -= getUpgradeStoneCost();
        }

    }
}
