﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonDelver.Model.Base;

namespace DungeonDelver.Model.Monsters
{
    internal class Goblin : Monster
    {

        public override Monster FactoryMethod()
        {
            return new Goblin();
        }


        public Goblin()
        {
            name = "Goblin";
            _health = 15;
            _damage = 5;
            defaultPortrait = new Bitmap(Properties.Resources.Goblinv1);
            hurtPortrait = defaultPortrait;
            xp_value = 10;
        }

        // EGEGEGEGEGEG -- Finish the slime class so that way you can test it appearing on the screen.
    }
}
