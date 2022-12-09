using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonDelver.Model.Base;

namespace DungeonDelver
{
    internal class Meep : Monster
    {
        public override Monster FactoryMethod()
        {
            return new Meep();
        }


        public Meep()
        {
            name = "Meep";
            _health = 30;
            _damage = 10;
            defaultPortrait = new Bitmap(Properties.Resources.Meepv1);
            hurtPortrait = new Bitmap(Properties.Resources.Meepv1_hurt);
            xp_value = 25;
        }
    }
}
