
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

        public string Heal()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            int healVal = healPower + rand.Next(0, 6);
            _health += healVal;
            return $"You heal yourself for {healVal} hit points!";
        }
    }
}
