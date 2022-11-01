using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonDelver
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
        }

        // EGEGEGEGEGEG -- Finish the slime class so that way you can test it appearing on the screen.
    }
}
