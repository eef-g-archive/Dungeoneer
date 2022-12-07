using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonDelver.Model.Monsters;
using DungeonDelver.Model.Base;

namespace DungeonDelver.Model
{
    // TODO:
    /*
     * Create more normal monsters
     * Create more hard monsters
     * Create more extra hard monsters
     * 
     * ^^ Once each difficulty of monsters is made, then switch the corresponding 
     */

    internal class MonsterFactory
    {
        Random rand = new Random(Guid.NewGuid().GetHashCode());
        public Monster GenerateRandomMonster(int difficulty)
        {
            Monster m;
            int monster_val = rand.Next(0, 1001);
            switch(difficulty)
            {
                case 0: // EASY DIFFICULTY
                    m = GenerateEasyMonster(monster_val);
                    break;
                case 1: // NORMAL DIFFICULTY
                    //m = GenerateNormalMonster(monster_val);
                    m = GenerateEasyMonster(monster_val);
                    break;
                case 2: // Hard Difficulty
                    // m = GenerateHardMonster(monster_val);
                    m = GenerateEasyMonster(monster_val);
                    break;
                case 3: // VERY HARD DIFFICULTY
                    //m = GenerateExtraHardMonster(monster_val);
                    m = GenerateExtraHardMonster(monster_val);
                    break;
                default:
                    m = new Slime();
                    break;
            }

            // TEMPORARY switch case to be used until I can figure out how to make
            // an enumerable class that has all of the different monster
            // If all else fails, just throw a slime out there.
            return m;
        }


        private Monster GenerateEasyMonster(int val)
        {
            Monster m;
            // Use switch case to run with values of monsters in the easy monsters pool.
            // Easy monsters pool:
            // COMMON: Slime
            // UNCOMMON: Goblin
            // RARE: Goobo
            switch(val)
            {
                case <= 500:
                    m = new Slime();
                    break;
                case > 500 and <= 890:
                    m = new Goblin();
                    break;
                case > 890:
                    m = new Goobo();
                    break;
                default:
                    m = new Slime();
            }
            return m;
        }


        /*
        private Monster GenerateNormalMonster(int val)
        {
            Monster m;
            // Use switch case to run with values of monsters in the normal monsters pool.
            // NOTE: Also tweak monster's health & damage values to normal difficulty settings

            // Normal monster pool
            // COMMON:
            // UNCOMMON:
            // RARE: 
            switch(val)
            {

            }
        }

        private Monster GenerateHardMonster(int val)
        {

        }
*/

        private Monster GenerateExtraHardMonster(int val)
        {
            Monster m;
            // Use switch case to run with values of monsters in the easy monsters pool.
            // Easy monsters pool:
            // COMMON: Pinchington
            // UNCOMMON: Frebble
            // RARE: Meep
            switch (val)
            {
                case <= 500:
                    m = new Pinchington();
                    break;
                case > 500 and <= 890:
                    m = new Frebble();
                    break;
                case > 890:
                    m = new Meep();
                    break;
                default:
                    m = new Slime();
            }
            return m;
        }

    }
}
