using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubTadeuszLab1ZadDom
{
    static class EventGenerator
    {
        static Random random = new Random();

        public const int EVENT_MULTIPLIER = 10;

        /// <summary>
        /// Runs random event on the (Village) village and returns the (string) summary
        /// </summary>
        /// <param name="village"></param>
        /// <returns></returns>
        public static string RunNewRandomEvent(Village village)
        {
            string eventSummaryText = "";

            int eventId = random.Next(0, 4);
            switch (eventId)
            {
                case 0:
                    {   
                        int populationGrowth = random.Next(0, village.villageLevel * Village.NEW_UNEMPLOYED_FACTOR)*EVENT_MULTIPLIER;
                        eventSummaryText = "Do twojej wioski dołączyło " + populationGrowth.ToString() + " nowych członków!";
                        village.population.unemployed += populationGrowth;
                        break;
                    }
                case 1:
                    {
                        int goldGrowth = random.Next(0, village.villageLevel * Village.EASY_SUPPLY_FACTOR +1) * EVENT_MULTIPLIER;
                        eventSummaryText = "To dobry dzień dla wioski! Nowa inwestycja przyniosła " + goldGrowth.ToString() + " złota zysku.";
                        village.gold += goldGrowth;
                        break;
                    }
                case 2:
                    {
                        int foodGrowth = random.Next(0, village.villageLevel * Village.EASY_SUPPLY_FACTOR +1) * EVENT_MULTIPLIER;
                        eventSummaryText = "Bardzo dobre zbiory! Nowe zapasy żywności: +" + foodGrowth.ToString();
                        village.foodSupply += foodGrowth;
                        break;
                    }
                case 3:
                    {
                        Army opponent = Army.getRandomOpponent(village.villageLevel);
                        int villageArmySize = village.population.army.getArmySize();
                        eventSummaryText = "Zostałeś zaatakowany. ";
                        bool battleResult = village.population.army.fight(opponent);
                        if (battleResult) eventSummaryText += "Walka zakończyła się zwycięstwem! ";
                        else eventSummaryText += "Walka zakończyła się porażką :c ";
                        eventSummaryText += "\nStracono " + (villageArmySize - village.population.army.getArmySize()).ToString() + " żołnierzy!";
                        if (!battleResult)
                        {
                            int foodLost = random.Next(0, village.villageLevel * Village.EASY_SUPPLY_FACTOR + 1) * EVENT_MULTIPLIER;
                            eventSummaryText += "\nPrzeciwnik zrabował z wioski " + foodLost + " jednostek żywności!";
                            village.foodSupply -= foodLost;
                        }
                        break;
                    }

            }
            return eventSummaryText;
        }

        /// <summary>
        /// Run new random expedition
        /// </summary>
        /// <param name="village"></param>
        /// <returns></returns>
        internal static string RunNewRandomExpedition(Village village)
        {
            string expeditionDescription = "";
            int expeditionCost = (random.Next(0, village.villageLevel * EVENT_MULTIPLIER +1)) * EVENT_MULTIPLIER;
            village.foodSupply -= expeditionCost;
            expeditionDescription += "W celu podjęcia ekspedycji, osadnicy poświęcili " + expeditionCost.ToString() + " racji żywnościowych!\n";
            int expeditionResult = (random.Next(0, 4));
            if (expeditionResult == 0)
            {
                int goldFound = (random.Next(0, village.villageLevel * Village.EASY_SUPPLY_FACTOR+ 1)) * EVENT_MULTIPLIER;
                int foodFound = (random.Next(0, village.villageLevel * Village.EASY_SUPPLY_FACTOR + 1)) * EVENT_MULTIPLIER;
                village.gold += goldFound;
                village.foodSupply += foodFound;
                expeditionDescription += "Ekspedycja zakończona sukcesem! Znaleziono:\n+"
                    + goldFound.ToString()+ " złota\n+" 
                    + foodFound.ToString() + " racji żywnościowych";
            }
            else expeditionDescription += "Ekspedycja zakończyła się porażką";
            return expeditionDescription;
        }

        /// <summary>
        /// Run attack on the other village
        /// </summary>
        /// <param name="village"></param>
        /// <returns></returns>
        internal static string PerformAttackOnOtherVillage(Village village)
        {
            string attackSummary = "";
            Army opponent = Army.getRandomOpponent(village.villageLevel);
            int villageArmySize = village.population.army.getArmySize();
            bool battleResult = village.population.army.fight(opponent);
            if (battleResult) attackSummary += "Atak zakończony sukcesem! ";
            else attackSummary += "Atak zakończył się porażką :c ";
            attackSummary += "\nStracono " + (villageArmySize - village.population.army.getArmySize()).ToString() + " żołnierzy!";
            if (battleResult)
            {
                int foodGathered = random.Next(0, village.villageLevel * Village.EASY_SUPPLY_FACTOR + 1) * EVENT_MULTIPLIER;
                int goldGathered = random.Next(0, village.villageLevel * Village.EASY_SUPPLY_FACTOR + 1) * EVENT_MULTIPLIER;
                attackSummary += "\nZrabowano z wioski przeciwnika:\n+" 
                    + foodGathered + " jednostek żywności!\n+" 
                    + goldGathered + " złota!";
                village.foodSupply += foodGathered;
                village.gold += goldGathered;
            }
            return attackSummary;
        }
    }
}
