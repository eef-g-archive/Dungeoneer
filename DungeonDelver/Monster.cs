using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonDelver
{
    abstract class Monster : Being
    {
        public Bitmap defaultPortrait;
        public abstract Monster FactoryMethod();

    }
}
