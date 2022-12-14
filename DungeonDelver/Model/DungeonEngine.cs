// @Author: Ethan Gray
// Purpose:
/* This is the main logic class for the DungeonDelver game.
 * It controls a lot of the 'behavior' for the game.
 * It also controls the flow of information to the control class for the model aspect.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonDelver.Model.Base;


namespace DungeonDelver.Model
{
    internal class DungeonEngine
    {
        // Set up all the public variables that will be accessible by the Form1 class.
        public LinkedList<Room> rooms;
        public int earnedXP = 0;
        public int roundScore = 0;
        public int current_room = 0;
        public Bitmap monsterImage;
        public string outputText = "";
        public int dungeonDifficulty = 0;

        // Set up all the protected & private variables that are only accessible by this class
        protected bool playerTurn = true;
        public Player player;
        protected Monster currentEnemy;
        public int dungeonLength;
        private int enemyMaxHealth;
        public List<int> roomScores = new List<int>();

        // When the engine is created, make sure you initialize the actual dungeon itself as well as the player.
        public DungeonEngine()
        {
            rooms = new LinkedList<Room>();
            player = new Player();
        }

        public event Action<string> TextOut;
        public event Action<Bitmap> ImageOut;
        public event Action<int> MonsterUpdate;
        public event Action<int> NewMonster;
        public event Action<string> GameEnd;
        public event Action<int> PlayerMaxBar;
        public event Action<int> PlayerUpdate;
        public event Action<bool> PlayerBlockIcon;


        // @Author: Ethan Gray
        // Purpose: 
        /* Utilizes the MonsterFactory to randomly choose what enemies are in what rooms of the dungeon.
         * Adds to the overall list of the dungeon rooms so that way when the dungeon is made, the player can have something to explore.
         * Takes in the argument "len" so that way later we can have some sort of setting to choose how long the dungeon is to increase difficulty.
         */
        public void GenerateDungeon(int len)
        {
            roomScores.Clear();
            roundScore = 0;
            rooms.Clear();
            dungeonLength = len;
            MonsterFactory monster_fact = new MonsterFactory();
            monster_fact.CreateMonsterPool();
            for(int i = 1; i <= len; i++)
            {

                Monster monster = monster_fact.GenerateRandomMonster(dungeonDifficulty);
                Room room = new Room(i, monster, 15);
                rooms.AddLast(room);
            }
            current_room = 0;
        }


        // @Author: Ethan Gray
        // Purpose:
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
                enemyMaxHealth = currentEnemy.Health;
            }
            else
            {
                player.dungeons_attempted++;
                monsterImage = Properties.Resources.CreatureBackground;
                outputText = $"> You finished the dungeon, go home!\n";
                TextOut(outputText);
                wait(2000);
                if(current_room != 99999) { player.dungeons_completed++; }
                GameEnd("end");
            }
            ImageOut(monsterImage);
        }
        

        // @Author: Ethan Gray
        // Purpose:
        /* Controls the logic when the player enters a new room.
         * Ensures it is the player's turn to go when prompted.
         */
        private void EnterRoom()
        {
            Room current = rooms.ElementAt(current_room);
            currentEnemy = current.enemy;
            NewMonster(currentEnemy.Health);
            if (currentEnemy.name != "Empty") { outputText = $"> You enter room number {current_room + 1} and encounter an enemy {current.enemy.name}!\n"; }
            else { outputText = $"> You come accross an empty chamber. Choose what you do here wisely, there isn't much time.\n"; }
            TextOut(outputText);
        }


        // @Author: Ethan Gray
        /* Purpose:
         * Uses the custom event TextOut() to send a splash text to the control aspect to be used by the view aspect.
         * Serves as a way of showing the player data about the room they just completed.
         */
        private void RoomResults()
        {
            TextOut("==========================================\n");
            TextOut($"| You defeated the enemy {currentEnemy.name}\n");
            TextOut($"| This gained you {currentEnemy.xp_value} experience points!\n");
            TextOut($"| You proceed to the next room.\n");
            TextOut("==========================================");
        }


        // @Author: Ethan Gray
        /* Purpose:
         * Similar to RoomResults(), however it creates a splash text whenever the player levels up and shows the new stats.
         */
        private void LevelUpResults()
        {
            TextOut("==========================================\n");
            TextOut($"| You leveled up to level {player.level}\n");
            TextOut($"| Your max health is now {player.max_health}.\n");
            TextOut($"| Your max damage is now {player.Damage}.\n");
            TextOut("==========================================");
        }

        // @Author: Ethan Gray
        // Purpose:
        /*This is the main logic used for each turn in a game.
         * It takes a string argument passed to it from the control aspect and runs the logic for each different type of turn.
         * It will ONLY go through this turn logic if the player is still within one of the available rooms. If not, then it tells them to go home.
         * The structure of a game turn is as follows:
         *  - The player selects their move on the UI
         *  - The view aspect sends a custom argument to the control aspect
         *  - The control aspect figures out what type of input was sent and then calls the GameTurn() function with the argument
         *    related to the type of action the player chose
         *  - The engine runs the PlayerTurn() function which runs logic for each different action that can be called
         *  - After the action is completed, different logic checks for what can happen are run in GameTurn()
         *      - Such logic checks are if the player was hurt, if the enemy died, if the player died, or if the player fled the dungeon
         *  - After the player's choice is dealt with, the enemy begins their turn and runs through their own logic.
         *      - ATM, monsters only continuously attack because A) I'm lazy and can't code a basic behavior for them and B) See reason A.
         */
        public void GameTurn(string playerAction)
        {
            if (current_room < dungeonLength)
            {
                wait(500);
                PlayerTurn(playerAction);
                if (outputText.Contains("is hurt for"))
                {
                    ImageOut(currentEnemy.hurtPortrait);
                    MonsterUpdate(currentEnemy.Health);
                    wait(850);
                    ImageOut(currentEnemy.defaultPortrait);
                }
                else
                {
                    MonsterUpdate(currentEnemy.Health);
                    wait(500);
                }

                if (currentEnemy.Health <= 0)
                {
                    int roomScore = 100 - (player.max_health - player.Health) + enemyMaxHealth;

                    current_room++;
                    ImageOut(null);

                    player.curr_xp += currentEnemy.xp_value;
                    player.overall_xp += currentEnemy.xp_value;
                    earnedXP += currentEnemy.xp_value;
                    roomScores.Add(roomScore);
                    roundScore += roomScore;                   

                    TextOut("");
                    RoomResults();
                    wait(2000);
                    TextOut("");


                    try
                    {
                        player.LevelUp();
                        PlayerMaxBar(player.max_health);
                        LevelUpResults();
                        wait(2000);
                        TextOut("");
                    }
                    catch(Exception ex)
                    {
                        // Don't do anything
                    }
                    NextRoom();
                }
                else
                {
                    if (playerAction != "RUN")
                    {
                        MonsterTurn();
                        PlayerUpdate(player.Health);
                    }
                }
                
                if(player.Health <= 0)
                {
                    roomScores.Add(-1);
                    //Game ends
                    GameEnd("Death");
                }

                if(player.Blocking) 
                {
                    TextOut(player.BlockCountdown());
                }
                PlayerBlockIcon(player.Blocking);
            }   
            else { TextOut("> You already finished the dungeon. Go home!\n");  }
        }


        // @Author: Ethan Gray
        /* Purpose:
         * Takes the action that the player selected and sends the outputs to the view aspect as well updates the player or current monster
         * objects depending on the action.
         */
        private void PlayerTurn(string action)
        {
            switch(action)
            {
                case "FIGHT":
                    outputText = player.Attack(player, currentEnemy);
                    TextOut(outputText + "\n");
                    break;
                case "BLOCK":
                    player.Block();
                    TextOut("> You raise your shield to block.\n");
                    break;
                case "HEAL":
                    outputText = player.Heal();
                    PlayerUpdate(player.Health);
                    TextOut(outputText + "\n");
                    break;
                case "RUN":
                    current_room = 99999;
                    roomScores.Add(-2);
                    TextOut("");
                    TextOut($"> You flee the dungeon like the cowardly adventurer you are.\n> You forget all the experience you gained in this dungeon.\n");
                    ImageOut(Properties.Resources.CreatureBackground);
                    wait(2000);
                    GameEnd("end");
                    break;
            }
        }


        // @Author: Ethan Gray
        /* Purpose:
         * Runs the monster logic, which is very minimal because I got lazy and wanted them to brainlessly attack.
         */
        private void MonsterTurn()
        {
            outputText = currentEnemy.Attack(currentEnemy, player);
            TextOut(outputText + "\n");
        }



        // This was taken from Stack Overflow
        // Credit: Oringinally written by Said on Oct. 20, 2018. Edited by AustinWBryan on Jun. 29, 2020
        // @Authors: Said & AustinWBryan
        /* Purpose:
         * Works as a way of stopping the program without having to use Thread.Sleep().
         * This allows for the project to be usable even while a task is waiting.
         * This function is a core pillar of actually having the project work and having elements update
         * dynamicall instead of everything updating at once after a function is done.
         */
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
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}
