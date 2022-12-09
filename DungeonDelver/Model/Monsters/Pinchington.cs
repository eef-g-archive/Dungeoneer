using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonDelver.Model.Base;

namespace DungeonDelver
{
    internal class Pinchington : Monster
    {
        public override Monster FactoryMethod()
        {
            return new Pinchington();
        }


        public Pinchington()
        {
            name = "Pinchington";
            _health = 40;
            _damage = 15;
            defaultPortrait = new Bitmap(Properties.Resources.Pinchingtonv1);
            hurtPortrait = new Bitmap(Properties.Resources.Pinchingtonv1_hurt);
            xp_value = 25;
        }
    }
}
