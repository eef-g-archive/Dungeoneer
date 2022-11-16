// @Author: Ethan Gray
// Last Edited: 10/26/22
// Purpose:
/* This is the base class for the player and all monsters in the game.
 * It controls the variables and methods that are shared between the two objects and is used as a starting point.
 * This is to be used as the groundwork for the classes later down the line to build off of.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonDelver
{
    internal class Being
    {
        // Declare all the variables needed.
        // NOTE: Only the name is public, this is so that we can access the name from other classes such as the main controller at the end to update high scores!
        protected int _health;
        public int Health { get { return _health; } set { _health = value; } } // Gives us a public way to access the health of the being if needed
        public string name;
        protected int _damage;
        protected bool _isBlocking = false;
        

        // @Author: Ethan Gray
        // Last Edited: 11/15/22
        // Purpose: This function will let 2 Being objects interact with each other by manipulating their health values according to block stances.
        public string Attack(Being a, Being b)
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            int dmg = rand.Next(0, a._damage + 1);

            if (b._isBlocking)
            {
                int block_chance = rand.Next(0, 4);
                if (block_chance == 2)
                {
                    b._health -= dmg;
                    if (dmg == 0) { return $"> {a.name} misses their attack."; }
                    else { return $"> {b.name} is hurt for {dmg}."; }
                }
                else { return $"> {b.name} blocks {a.name}'s attack!"; }
            }
            else
            {
                b._health -= dmg;
                if (dmg == 0) { return $"> {a.name} misses their attack."; }
                else { return $"> {b.name} is hurt for {dmg}."; }
            }
        }
        
        // @Author: Ethan Gray
        // Last Edited: 10/26/22
        // Purpose: Inverses the existing value of Block.
        // NOTE: Can be used by the GameEngine class at the end of a turn to reset back to a normal stance.
        public void Block()
        {
            _isBlocking = !_isBlocking;
        }
    }
}
