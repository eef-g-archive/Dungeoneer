using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonDelver.Model.Base;

namespace DungeonDelver.Model.Monsters
{
    internal class Frebble : Monster
    {
        public override Monster FactoryMethod()
        {
            return new Frebble();
        }


        public Frebble()
        {
            name = "Frebble";
            _health = 50;
            _damage = 15;
            defaultPortrait = new Bitmap(Properties.Resources.Frebblev1);
            hurtPortrait = new Bitmap(Properties.Resources.Frebblev1_hurt);
            xp_value = 25;
        }
    }
}
