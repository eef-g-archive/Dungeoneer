
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DungeonDelver.Model.Base
{
    internal class Player : Being
    {
        public int healPower = 3;

        public int overall_xp = 0;
        public int curr_xp = 0;
        public int dungeons_completed = 0;
        public int dungeons_attempted = 0;
        public int level = 1;

        public int max_health = 20;

        private int xp_to_next = 0;

        public int Damage { get { return _damage; } }

        public Player()
        {
            _health = 20;
            _damage = 5;
            name = "The player";
            level = 1;
            UpdateXPRequirement();
        }

        public void LoadStats(string name, int[] stats)
        {
            this.name = name;
            dungeons_completed = stats[0];
            dungeons_attempted = stats[1];
            overall_xp = stats[2];
            curr_xp = stats[3];
            level = stats[4];
            max_health = stats[5];
            _health = max_health;
            healPower = stats[6];
            _damage = stats[7];
            UpdateXPRequirement();
        }

        public string Heal()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            int healVal = healPower + rand.Next(0, 8);
            if (_health + healVal <= max_health)
                _health += healVal;
            else
                _health = max_health;
            return $"You heal yourself for {healVal} hit points!";
        }

        private void UpdateXPRequirement()
        {
            xp_to_next = ( (level * 15) + (xp_to_next / 3) );
        }

        public void LevelUp()
        {
            UpdateXPRequirement();
            Console.WriteLine($"{curr_xp} / {xp_to_next}");
            if( (curr_xp > xp_to_next) && (level != 99) )
            {
                if (level++ <= 99)
                    level++;
                if (max_health++ <= 99)
                    max_health++;
                if (_damage++ <= 99)
                    _damage++;
                if (healPower++ <= 25)
                    healPower++;
                curr_xp = 0;
            }
            else
            {
                Exception e = new Exception("Not enough XP");
                throw e;
            }
        }
    }
}
