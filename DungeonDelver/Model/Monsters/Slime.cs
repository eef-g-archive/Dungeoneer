using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonDelver.Model.Base;

namespace DungeonDelver
{
    internal class Slime : Monster
    {
        public override Monster FactoryMethod()
        {
            return new Slime();
        }

        public Slime()
        {
            name = "Slime";
            _health = 10;
            _damage = 2;
            defaultPortrait = new Bitmap(Properties.Resources.Slimev1);
            hurtPortrait = new Bitmap(Properties.Resources.Slime_hurt);
            xp_value = 5;
        }

        // EGEGEGEGEGEG -- Finish the slime class so that way you can test it appearing on the screen.
    }
}
