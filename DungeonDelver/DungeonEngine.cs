// @Author: Ethan Gray
// Last Edited: 11/04/22
// Purpose:
/* This is the main logic class for the DungeonDelver game.
 * It controls a lot of the 'behavior' for the game.
 * It also controls the flow of information to the main Form1 class.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///////////////
//  TODO     //
///////////////
/*
 * 
 * 
 * 
 * 
 * 
 */
namespace DungeonDelver
{
    internal class DungeonEngine
    {
        // Set up all the public variables that will be accessible by the Form1 class.
        public LinkedList<Room> rooms;
        public int earnedXP = 0;
        public int current_room = 0;
        public Bitmap monsterImage;
        public string outputText = "";

        // Set up all the protected & private variables that are only accessible by this class
        protected bool playerTurn = true;
        protected Player player;
        protected Monster currentEnemy;
        private int dungeonLength = 11;
        private Form1 mainForm;

        // When the engine is created, make sure you initialize the actual dungeon itself as well as the player.
        public DungeonEngine(Form1 f)
        {
            rooms = new LinkedList<Room>();
            GenerateDungeon(dungeonLength);
            player = new Player();
            mainForm = f;
        }


        // @Author: Ethan Gray
        // Last Edited - 11/04/22
        // @Purpose: 
        /* Utilizes the MonsterFactory to randomly choose what enemies are in what rooms of the dungeon.
         * Adds to the overall list of the dungeon rooms so that way when the dungeon is made, the player can have something to explore.
         * Takes in the argument "len" so that way later we can have some sort of setting to choose how long the dungeon is to increase difficulty.
         */
        public void GenerateDungeon(int len)
        {
            MonsterFactory monster_fact = new MonsterFactory();
            for(int i = 1; i <= len * 2; i++)
            {
                // Need to add a buffer room between each room to give player 1 turn to heal or block.
                Monster monster = monster_fact.GenerateMonster();
                Room room = new Room(i, monster, 15);
                rooms.AddLast(room);
            }
        }


        // @Author: Ethan Gray
        // Last Edited - 11/04/22
        // @Purpose:
        /* First checks if the dungeon is completed or not.
         * Afterwards, begins the initialization of the next room.
         * When the room is initialized, it updates the engine's public variables to allow the Form1 class to access the following:
         *  - monsterImage
         *  - outputText
         *  - currentEnemy
         *  - rooms <-- this is always accessible, but might change to be a single, public accessible room object and not the list
         * If the dungeon is complete, it lets the player know with the status text.
         */
        public void NextRoom()
        {
            if (current_room < dungeonLength)
            {
                EnterRoom();
                monsterImage = currentEnemy.defaultPortrait;
            }
            else
            {
                monsterImage = Properties.Resources.CreatureBackground;
                outputText = $"> You finished the dungeon, go home!";
            }
        }
        

        // @Author: Ethan Gray
        // Last Edited - 11/05/22
        // @Purpose:
        /* Controls the logic when the player enters a new room.
         * Ensures it is the player's turn to go when prompted.
         */
        private void EnterRoom()
        {
            playerTurn = true;
            Room current = rooms.ElementAt(current_room);
            currentEnemy = current.enemy;
            if (currentEnemy.name != "Empty") { outputText = $"> You enter room number {current_room + 1} and encounter an enemy {current.enemy.name}!"; }
            else { outputText = $"> You come accross an empty chamber. Choose what you do here wisely, there isn't much time."; }
        }


        // @Author: Ethan Gray
        // Last Edited - 11/04/22
        // @Purpose:
        /*
         * 
         * 
         */
        public void AttackLogic()
        {
            if (playerTurn)
            {
                outputText = player.Attack(player, currentEnemy);
                playerTurn = !playerTurn;
            }
            else
            {
                MonsterTurn();
            }
            if(RoomClearCheck())
            {
                current_room++;
                NextRoom();
            }
        }

        public void GameTurn(string playerChoice)
        {
            switch(playerChoice)
            {
                case "FIGHT":
                    outputText = player.Attack(player, currentEnemy);
                    if(RoomClearCheck())
                    {
                        current_room++;
                        NextRoom();
                    }
                    else
                    {
                        wait(500);
                        MonsterTurn();
                    }
                    break;
                case "BLOCK":
                    break;
                case "HEAL":
                    break;
                case "RUN":
                    break;
            }
        }

        private void MonsterTurn()
        {
            outputText = currentEnemy.Attack(currentEnemy, player);
            playerTurn = !playerTurn;

        }

        // @Author: Ethan Gray
        // Last Edited - 11/04/22
        // @Purpose:
        /*
         * 
         * 
         */
        private bool RoomClearCheck()
        {
            if(currentEnemy.Health <= 0)
            {
                outputText = $"> You defeated the enemy {currentEnemy.name}! You are awarded with 5 XP.\n> You carry on to the next room.";
                return true;
            }
            else { return false;  }
        }





        
        // This was taken from Stack Overflow
        // Credit: Oringinally written by Said on Oct. 20, 2018. Edited by AustinWBryan on Jun. 29, 2020
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}
