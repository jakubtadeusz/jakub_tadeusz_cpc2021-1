using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubTadeuszLab1ZadDom
{
    /// <summary>
    /// Population class stores info about the village population
    /// </summary>
    class Population
    {
        /// <summary>
        /// traders amount
        /// </summary>
        public int traders { get; set; }
        /// <summary>
        /// lumberjacks amount
        /// </summary>
        public int lumberjacks { get; set; }
        /// <summary>
        /// food suppliers amount
        /// </summary>
        public int foodSuppliers { get; set; }
        /// <summary>
        /// miners amount
        /// </summary>
        public int miners { get; set; }
        /// <summary>
        /// unemployed amount
        /// </summary>
        public int unemployed { get; set; }
        /// <summary>
        /// stores info about village army
        /// </summary>
        public Army army;

        /// <summary>
        /// create new population given (int) population size
        /// </summary>
        /// <param name="populationSize"></param>
        public Population(int populationSize)
        {
            traders = populationSize / 10;
            lumberjacks = populationSize / 10;
            foodSuppliers = populationSize / 10;
            miners = populationSize / 10;
            //half of the population is unemployed
            unemployed = populationSize / 2;
            army = new Army(populationSize / 10);
        }

        /// <summary>
        /// return population size
        /// </summary>
        /// <returns></returns>
        public int getPopulationSize()
        {
            return traders + lumberjacks + foodSuppliers + miners + unemployed + army.getArmySize();
        }

        /// <summary>
        /// kill part of the population given (int) person killed amount
        /// </summary>
        /// <param name="personKilled"></param>
        internal void kill(int personKilled)
        {
            traders -= personKilled / 8;
            lumberjacks -= personKilled / 8;
            foodSuppliers -= personKilled / 8;
            miners -= personKilled / 8;
            unemployed -= personKilled / 8;
            army.kill(personKilled * 3 / 8);
        }
    }
}
