using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonDelver.Model.Base;

namespace DungeonDelver.Model.Monsters
{
    internal class Goobo : Monster
    {
        public override Monster FactoryMethod()
        {
            return new Goobo();
        }


        public Goobo()
        {
            name = "Goobo";
            _health = 30;
            _damage = 1;
            defaultPortrait = new Bitmap(Properties.Resources.Gooblinv1);
            hurtPortrait = new Bitmap(Properties.Resources.Goobo_hurt);
            xp_value = 25;
        }
    }
}
