using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubTadeuszLab1ZadDom
{
    class Army
    {
        const int OPPONENT_MODIFIER = 20;
        /// <summary>
        /// shield troops amount
        /// </summary>
        int shieldTroops;
        /// <summary>
        /// shield troops level
        /// </summary>
        public int shieldTroopsLevel { get; set; }
        /// <summary>
        /// sword troops amount
        /// </summary>
        int swordTroops;
        /// <summary>
        /// sword troops level
        /// </summary>
        public int swordTroopsLevel { get; set; }
        /// <summary>
        /// ranged troops amount
        /// </summary>
        int rangedTroops;
        /// <summary>
        /// ranged troops level
        /// </summary>
        public int rangedTroopsLevel { get; set; }

        /// <summary>
        /// Create new army
        /// </summary>
        /// <param name="armySize"></param>
        public Army(int armySize)
        {
            shieldTroops = armySize / 3;
            swordTroops = armySize / 3;
            rangedTroops = armySize / 3;
            shieldTroopsLevel = 1;
            swordTroopsLevel = 1;
            rangedTroopsLevel = 1;
        }

        /// <summary>
        /// returns army size
        /// </summary>
        /// <returns></returns>
        internal int getArmySize()
        {
            return shieldTroops + swordTroops + rangedTroops;
        }

        /// <summary>
        /// returns army attack power
        /// </summary>
        /// <returns></returns>
        internal int getAttackPower()
        {
            return 2 * rangedTroops * rangedTroopsLevel + swordTroops * swordTroopsLevel;
        }

        /// <summary>
        /// returns army defence power
        /// </summary>
        /// <returns></returns>
        internal int getDefencePower()
        {
            return 3 * shieldTroops * shieldTroopsLevel;
        }

        /// <summary>
        /// kills (int) troops amount
        /// </summary>
        /// <param name="troopsKilled"></param>
        internal void kill(int troopsKilled)
        {
            if (troopsKilled >= getArmySize())
            {
                shieldTroops = 0;
                swordTroops = 0;
                rangedTroops = 0;
            }
            else
            {
                shieldTroops -= troopsKilled / 3;
                swordTroops -= troopsKilled / 3;
                rangedTroops -= troopsKilled / 3;
            }
        }

        /// <summary>
        /// generate random opponent
        /// </summary>
        /// <param name="villageLevel"></param>
        /// <returns></returns>
        internal static Army getRandomOpponent(int villageLevel)
        {
            return new Army(villageLevel* villageLevel * OPPONENT_MODIFIER);
        }

        /// <summary>
        /// recruits new troops
        /// </summary>
        /// <param name="value"></param>
        internal void recruitTroops(int value)
        {
            shieldTroops += value / 3;
            swordTroops += value / 3;
            rangedTroops += value / 3;
        }

        /// <summary>
        /// handles fight with (Army) opponent
        /// </summary>
        /// <param name="opponent"></param>
        /// <returns></returns>
        internal bool fight(Army opponent)
        {
            int attackPower = getAttackPower();
            int opponentAttackPower = opponent.getAttackPower();
            int defencePower = getDefencePower();
            int opponentDefencePower = opponent.getDefencePower();

            int lostTroops = opponentAttackPower - defencePower;
            int opponentLostTroops = attackPower - opponentDefencePower;
            kill(lostTroops);
            opponent.kill(opponentLostTroops);

            return opponentLostTroops >= lostTroops;
        }
    }
}
