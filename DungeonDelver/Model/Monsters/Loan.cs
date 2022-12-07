using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonDelver.Model.Base;

namespace DungeonDelver.Model.Monsters
{
    internal class Loan : Monster
    {
        public override Monster FactoryMethod()
        {
            return new Loan();
        }

        public Loan()
        {
            name = "Bag of Studen Loan Money";
            _health = 12000;
            _damage = 900;
            defaultPortrait = new Bitmap(Properties.Resources.Loanv1);
            hurtPortrait = new Bitmap(Properties.Resources.Loan_hurt);
            xp_value = 9999999;
        }

        // EGEGEGEGEGEG -- Finish the slime class so that way you can test it appearing on the screen.
    }
}
