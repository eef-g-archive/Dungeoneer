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
            MonsterFactory monster_fact = new MonsterFactory();
            for(int i = 1; i <= len; i++)
            {
                Monster monster = monster_fact.GenerateMonster();
                Room room = new Room(i, monster, 15);
                rooms.AddLast(room);
            }
        }


        public void EnterRoom(int room_num)
        {
            Room current = rooms.ElementAt(room_num);
            string s = $"> You enter room number {room_num} and encounter an enemy {current.enemy.name}!";
            
        }
    }
}
