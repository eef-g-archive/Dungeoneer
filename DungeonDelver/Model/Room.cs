using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonDelver.Model.Base;

namespace DungeonDelver.Model
{
    internal class Room
    {
        protected int _id;
        public Monster enemy;
        public int xp_reward;

        public Room(int id, Monster enemy, int xp_reward)
        {
            _id = id;
            this.enemy = enemy;
            this.xp_reward = xp_reward;
        }
    }
}
