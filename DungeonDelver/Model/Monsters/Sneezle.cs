using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonDelver.Model.Base;

namespace DungeonDelver.Model.Monsters
{
    internal class Sneezle : Monster
    {
        public override Monster FactoryMethod()
        {
            return new Sneezle();
        }


        public Sneezle()
        {
            name = "Sneezle";
            _health = 40;
            _damage = 15;
            defaultPortrait = new Bitmap(Properties.Resources.Sneezlev1);
            hurtPortrait = new Bitmap(Properties.Resources.Sneezle_hurt);
            xp_value = 25;
        }
    }
}
