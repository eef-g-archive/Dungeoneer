using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonDelver
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
            _damage = 5;
            defaultPortrait = new Bitmap(Properties.Resources.Loanv1);
        }

        // EGEGEGEGEGEG -- Finish the slime class so that way you can test it appearing on the screen.
    }
}
