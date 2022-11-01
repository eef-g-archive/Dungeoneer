using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonDelver
{
    internal class MonsterFactory
    {
        Random rand = new Random(Guid.NewGuid().GetHashCode());
        public Monster GenerateMonster()
        {
            Monster m;
            int monster_val = rand.Next(0, 1001);
            switch(monster_val)
            {
                case <= 500:
                    m = new Slime();
                    return m;
                case > 500 and <= 890:
                    m = new Goblin();
                    return m;
                case > 890 and <= 990:
                    m = new Goobo();
                    return m;
                case > 990 and <= 1000:
                    m = new Loan();
                    return m;
            }
            
            // If all else fails, just throw a slime out there.
            return new Slime();
        }
    }
}
