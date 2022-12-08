using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonDelver.Model.Base;

namespace DungeonDelver.Model.Monsters
{
    internal class Bonebilly : Monster
    {
        public override Monster FactoryMethod()
        {
            return new Bonebilly();
        }


        public Bonebilly()
        {
            name = "Bonebilly";
            _health = 30;
            _damage = 10;
            defaultPortrait = new Bitmap(Properties.Resources.Skeletonv1);
            hurtPortrait = new Bitmap(Properties.Resources.Skeletonv1_hurt);
            xp_value = 20;
        }
    }
}
