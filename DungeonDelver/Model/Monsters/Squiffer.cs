using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonDelver.Model.Base;

namespace DungeonDelver
{
    internal class Squiffer : Monster
    {
        public override Monster FactoryMethod()
        {
            return new Squiffer();
        }


        public Squiffer()
        {
            name = "Squiffer";
            _health = 30;
            _damage = 10;
            defaultPortrait = new Bitmap(Properties.Resources.Squifferv1);
            hurtPortrait = new Bitmap(Properties.Resources.Squiffer_hurt);
            xp_value = 25;
        }
    }
}
