// @Author: Ethan Gray
/* Purpose:
 * This is the base class for the Room object.
 * The room object is used in the DungeonEngine class as part of a linked list of data for each "Room" of the dungeon.
 * Think of it as a node in a linked list that is storing a lot of specific data that is able to be accessed by the DungeonEngine class.
 */
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
