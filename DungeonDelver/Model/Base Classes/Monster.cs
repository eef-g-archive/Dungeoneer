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
