using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonDelver.Model.Base;

namespace DungeonDelver.Model.Monsters
{
    internal class MiddleManager : Monster
    {
        public override Monster FactoryMethod()
        {
            return new MiddleManager();
        }


        public MiddleManager()
        {
            name = "Middle Manager";
            _health = 175;
            _damage = 20;
            defaultPortrait = new Bitmap(Properties.Resources.Managerv1);
            hurtPortrait = new Bitmap(Properties.Resources.Managerv1_hurt);
            xp_value = 25;
        }
    }
}
