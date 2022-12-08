using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonDelver.Model.Monsters;
using DungeonDelver.Model.Base;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Security.Cryptography;

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

        List<MonsterType> monsterPool = new List<MonsterType>();

        #region RarityPools

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
