
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

        public Player()
        {
            _health = 20;
            _damage = 5;
            name = "The player";
        }

        public void Heal()
        {
            _health += healPower;
        }
    }
}
