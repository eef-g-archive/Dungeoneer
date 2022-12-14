// @Author: Ethan Gray
/* Purpose:
 * This is the abstract base class for all of the monsters in the game.
 * It is used as a base for the different monsters within the game instead of using an Interface.
 * Because in all honesty, still don't know when to use an abstract class or an interface and I decided to literally flip a coin and
 * it landed on heads so I made this an abstract class.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonDelver.Model.Base
{
    abstract class Monster : Being
    {
        public Bitmap defaultPortrait;
        public Bitmap hurtPortrait;

        public abstract Monster FactoryMethod();

        public int xp_value;

    }
}
