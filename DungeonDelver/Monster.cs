using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonDelver
{
    abstract class Monster : Being
    {
        // We can use the name variable and make sure that the resource is named the exact same as the name, and then the hurt image can be the name + "Hurt"
        public bool isTaunted = false;
        public Bitmap defaultPortrait;

        public abstract Monster FactoryMethod();
    }
}
