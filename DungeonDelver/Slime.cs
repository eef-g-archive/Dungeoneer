using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonDelver
{
    internal class Slime : Monster
    {
        public Slime()
        {
            name = "Slime";
            _health = 10;
            _damage = 2;
            defaultPortrait = new Bitmap(Properties.Resources.Slimev1);
            
        }

        // EGEGEGEGEGEG -- Finish the slime class so that way you can test it appearing on the screen.
    }
}
