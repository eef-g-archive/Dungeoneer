using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonDelver
{
    internal class Player : Being
    {
        int healPower = 3;
        int level = 1;
        int nextLevelXP = 100;

        public Player()
        {
            _health = 20;
            _damage = 5;
            name = "Player";
        }

        public void Heal()
        {
            _health += healPower;
        }

        public void Taunt(Monster m)
        {
            m.isTaunted = true;
        }
    }
}
