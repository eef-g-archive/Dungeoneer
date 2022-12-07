
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
        int healPower = 3;

        public int xp_gained = 0;
        public int dungeons_completed = 0;
        public int dungeons_attempted = 0;
        public int _level = 0;

        public int max_health = 20;

        public int Damage { get { return _damage; } }

        public Player()
        {
            _health = 20;
            _damage = 5;
            name = "The player";
        }

        public void LoadStats(string name, int completed, int attempted, int xp)
        {
            this.name = name;
            dungeons_completed = completed;
            dungeons_attempted = attempted;
            xp_gained = xp;
            if(xp / 15 > 0)
                LevelUp();
        }

        public string Heal()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            int healVal = healPower + rand.Next(0, 6);
            if (_health + healVal <= max_health)
                _health += healVal;
            else
                _health = max_health;
            return $"You heal yourself for {healVal} hit points!";
        }

        public void LevelUp()
        {
            int _prev_level = _level;
            int new_level = xp_gained / 15;

            for(int i = _prev_level; i < new_level; i++)
            {
                max_health += 5;
                _damage += 1;
                _level++;
            }
            _health = max_health;
        }
    }
}
