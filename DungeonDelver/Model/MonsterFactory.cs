// @Author: Ethan Gray
/* Purpose:
 * This is the main factory class for creating all the different types of monsters in the game.
 * There are two main methods that can be called outside of the class and they allow the user to make either a random monster
 * or a specific monster. This allows for the ability to create a "hand-made" level or a randomly generated one.
 * The main downside is that this requires a lot of logic to be put in the factory
 * 
 */

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
     * Create more hard monsters
     * Create extra hard monster
     */

    internal class MonsterFactory
    {

        #region GenerateMethods

        // @Author: Ethan Gray
        /* Purpose:
         * Takes the enumerator type of the monster that you want to generate and returns a Monster object of the
         * type related to the enumerator type you selected.
         */
        public Monster GenerateMonster(MonsterType type)
        {
            Monster m;
            switch (type)
            {
                case MonsterType.Bonebilly:
                    m = new Bonebilly();
                    break;
                case MonsterType.Frebble:
                    m = new Frebble();
                    break;
                case MonsterType.Goblin:
                    m = new Goblin();
                    break;
                case MonsterType.Goobo:
                    m = new Goobo();
                    break;
                case MonsterType.Loan:
                    m = new Loan();
                    break;
                case MonsterType.Meep:
                    m = new Meep();
                    break;
                case MonsterType.MiddleManager:
                    m = new MiddleManager();
                    break;
                case MonsterType.Pinchington:
                    m = new Pinchington();
                    break;
                case MonsterType.Slime:
                    m = new Slime();
                    break;
                case MonsterType.Sneezle:
                    m = new Sneezle();
                    break;
                case MonsterType.Squiffer:
                    m = new Squiffer();
                    break;
                default:
                    m = new Slime();
                    break;
            }

            return m;
        }


        // @Author: Ethan Gray
        /* Purpose:
         * Takes a single argument, the difficulty of the dungeon, and randomly creates a monster.
         * The creation is dependant on the logic below this method.
         */
        public Monster GenerateRandomMonster(int difficulty)
        {
            Monster m;


            Random rand = new Random(Guid.NewGuid().GetHashCode());
            int monster_val = rand.Next(0, 1001);

            m = EditRandomMonster(SelectMonsterFromPool(monsterPool, monster_val), difficulty);

            return m;
        }
        #endregion

        #region RandomMonsterLogic
        // @Author: Ethan Gray
        /* Section Purpose:
         * This section contains all the logic behind the GenerateRandomMonster() function.
         */


        // Create a monsterPool that is made up of 1 monster from each rarity.
        List<MonsterType> monsterPool = new List<MonsterType>();

        #region RarityPools
        // @Author: Ethan Gray
        /* Section Purpose:
         * This section contains all the arrays of different rarity pools of the available monsters.
         * Each of these pools is used to create a random dungeon pool of monsters that are avaialable in each run.
         * This allows for the dungeons to be unique in their own way, and even moreso if more and more monsters are in the game.
         */


        MonsterType[] commonMonsters =
        {
            MonsterType.Slime,
            MonsterType.Frebble,
            MonsterType.Goblin
        };

        MonsterType[] uncommonMonsters =
        {
            MonsterType.Goobo,
            MonsterType.Bonebilly,
        };

        MonsterType[] rareMonsters =
        {
            MonsterType.MiddleManager,
            MonsterType.Squiffer
        };

        MonsterType[] legendaryMonsters =
        {
            MonsterType.Meep,
            MonsterType.Sneezle
        };

        MonsterType[] gameEnders =
        {
            MonsterType.Loan
        };


        #endregion


        // @Author: Ethan Gray
        /* Purpose:
         * Goes through each rarity pool and selects 1 monster at random. Afterwards, it assigns the list of available monsters
         * to the monsterPool variable that is used within the GenerateRandomMonster() function.
         */
        public void CreateMonsterPool()
        {
            List<MonsterType> pool = new List<MonsterType>();
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            pool.Add(commonMonsters[rand.Next(0, commonMonsters.Length)]);
            pool.Add(uncommonMonsters[rand.Next(0, uncommonMonsters.Length)]);
            pool.Add(rareMonsters[rand.Next(0, rareMonsters.Length)]);
            pool.Add(legendaryMonsters[rand.Next(0, legendaryMonsters.Length)]);
            pool.Add(gameEnders[rand.Next(0, gameEnders.Length)]);

            monsterPool = pool;
        }


        // @Author: Ethan Gray
        /* Purpose:
         * Takes the pool of available monsters for the run as well as a randomly generated number.
         * Using these, this function picks the rarity using the randomly generated number and outputs the
         * enumeration value of the monster within that rarity of the custom monster pool created 
         * in the CreateMonsterPool() function.
         */
        private MonsterType SelectMonsterFromPool(List<MonsterType> pool, int rng)
        {
            MonsterType selected_monster;

            // Check to see which monster pool we're going to pull from
            // 50% -- Common
            // 25% -- Uncommon
            // 10% -- Rare
            // 4.9% -- Legendary
            // .1% -- Run-Ender
            if ((rng >= 0) && (rng <= 500))
            {
                selected_monster = pool.ElementAt(0);
            }
            else if ((rng > 500) && (rng <= 750))
            {
                selected_monster = pool.ElementAt(1);
            }
            else if ((rng > 750) && (rng <= 950))
            {
                selected_monster = pool.ElementAt(2);
            }
            else if ((rng > 850) && (rng <= 999))
            {
                selected_monster = pool.ElementAt(3);
            }
            else
            {
                selected_monster = pool.ElementAt(4);
            }

            return selected_monster;
        }


        // @Author: Ethan Gray
        /* Purpose:
         * Takes the enumeration type of the monster that is going to be generated and the difficulty of the dungeon.
         * Using these two pieces of data, this function calls the GenerateMonster() function to create the specific monster
         * with the enumeration type that it was given. It also uses the difficulty value to tweak the health and attack values
         * of the monster that was just generated to make sure the monster is scaled with the difficulty to make the game fair.
         */
        private Monster EditRandomMonster(MonsterType mon, int difficulty)
        {
            Monster m;
            int mon_health;
            switch(difficulty)
            {
                case 0: //Easy
                    m = GenerateMonster(mon);
                    m.Health = (m.Health / 4) * 3;
                    m._damage = (m._damage / 4) * 3;
                    break;
                case 1: //Normal
                    m = GenerateMonster(mon);
                    break;
                case 2: //Hard
                    m = GenerateMonster(mon);
                    m.Health = (m.Health / 4) * 5;
                    m._damage = (m._damage / 4) * 5;
                    break;
                case 3: //Extra Hard
                    m = GenerateMonster(mon);
                    m.Health *= 2;
                    m._damage *= 2;
                    break;
                default:
                    m = GenerateMonster(mon);
                    break;
            }
            return m;
        }
        #endregion

    }
}
