using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonDelver
{
    internal class DungeonEngine
    {
        public LinkedList<Room> rooms;
        // Will add the turn logic in here as well. Along with total XP and score.
        public DungeonEngine()
        {
            rooms = new LinkedList<Room>();
        }

        public void GenerateDungeon(int len)
        {
            for(int i = 1; i <= len; i++)
            {
                Slime s = new Slime();
                Room room = new Room(i, s, 15);
                rooms.AddLast(room);
            }
        }
    }
}
