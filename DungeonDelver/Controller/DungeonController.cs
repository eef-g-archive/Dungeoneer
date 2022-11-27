using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonDelver
{
    internal class DungeonController
    {
        public Form1 app;
        DungeonEngine engine;

        public DungeonController(Form1 app)
        {
            this.app = app;
            engine = new DungeonEngine();

            // This here is where we assign the custom events to the functions that will run when triggered.
            app.PlayerInput += new Action<string>(PlayerinputHandler);
            app.NewGame += new Action<string>(BeginNewGame);
            app.LoadGame += new Action<string>(LoadOldGame);
            engine.TextOut += new Action<string>(TextHandler);
            engine.ImageOut += new Action<Bitmap>(ImageHandler);
            engine.GameEnd += new Action<string>(FinishDungeon);
            engine.MonsterUpdate += new Action<int>(UpdateMonsterHealth);
            engine.NewMonster += new Action<int>(LoadHealthBar);

            UpdateSavedProfileList();
        }

        /*******************************\
         *          Functions          *
        \*******************************/


        private void SaveGame()
        {
            string[] lines = { $"{engine.player.name}", $"{engine.player.dungeons_completed}", $"{engine.player.dungeons_attempted}", $"{engine.player.xp_gained}" };
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            docPath += "\\DungeonDelver\\";

            if(!System.IO.Directory.Exists(docPath))
            {
                System.IO.Directory.CreateDirectory(docPath);
            }
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, $"{engine.player.name}_save.txt")))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }
        }

        private List<string> GetSavedProfiles()
        {
            List<string> profiles = new List<string>();
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            docPath += "\\DungeonDelver\\";

            if(!System.IO.Directory.Exists(docPath))
            {
                System.IO.Directory.CreateDirectory(docPath);
            }

            string[] fileNames = System.IO.Directory.GetFiles(docPath);

            if (fileNames.Length >= 1)
            {
                foreach(string fileName in fileNames)
                {
                    int nameEnd = fileName.LastIndexOf('_');
                    int nameBegin = fileName.LastIndexOf('\\') + 1;
                    string profileName = fileName.Substring(nameBegin, nameEnd-nameBegin);
                    
                    profiles.Add(profileName);
                }
            }
            return profiles;
        }

        private void UpdateSavedProfileList()
        {
            List<string> savedProfiles = GetSavedProfiles();
            foreach(string profile in savedProfiles)
            {
                app.ProfileList += profile;
            }
        }

        private void BeginGame()
        {
            engine.GenerateDungeon(app.GameDifficulty);
            app.ShowGame();
            engine.NextRoom();
        }

        /*******************************\
         *        Custom Events        *
        \*******************************/
        private void PlayerinputHandler(string playerInput)
        {
            app.ToggleInput();
            switch(playerInput)
            {
                case "FIGHT":
                    engine.GameTurn("FIGHT");
                    break;
                case "BLOCK":
                    engine.GameTurn("BLOCK");
                    break;
                case "HEAL":
                    engine.GameTurn("HEAL");
                    break;
                case "RUN":
                    engine.GameTurn("RUN");
                    break;
            }
            app.ToggleInput();
        }

        private void BeginNewGame(string playerName)
        {
            List<string> existingPlayers = app.ExistingProfiles;
            bool exists = existingPlayers.Contains(playerName);
            if ((playerName != "") && (!existingPlayers.Contains(playerName)))
            {
                engine.player.name = playerName;
                engine.player.Health = 20;
                BeginGame();
            }
            else
            {
                string error = $"Sorry, the name {playerName} is already someone's saved file!\nTry a different name or load your game if {playerName} is your profile name!";
                MessageBox.Show(error);
            }
        }

        private void LoadOldGame(string playerName)
        {
            // Load stats from file first by using the playerName variable
            string fileName = playerName + "_save.txt";
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            docPath += "\\DungeonDelver\\";

            if (!System.IO.Directory.Exists(docPath))
            {
                System.IO.Directory.CreateDirectory(docPath);
            }

            int index = 0;
            List<string> lines = new List<string>();
            try
            {
                using (StreamReader reader = new StreamReader(Path.Combine(docPath, fileName)))
                {
                    while (!reader.EndOfStream)
                    {
                        lines.Add(reader.ReadLine());
                    }
                }
                /* File Structure:
                 * name
                 * dungeons_completed
                 * dungeons_attempted
                 * xp_gained
                 */

                engine.player.LoadStats(lines.ElementAt(0), Convert.ToInt32(lines.ElementAt(1)), Convert.ToInt32(lines.ElementAt(2)), Convert.ToInt32(lines.ElementAt(3)));
                BeginGame();
            }
            catch(Exception ex)
            {
                return;
            }
        }

        private void TextHandler(string flavorText)
        {
            app.StatusText = flavorText;
        }

        private void ImageHandler(Bitmap image)
        {
            app.MonsterImage = image;
        }

        private void FinishDungeon(string end)
        {
            SaveGame();
            app.ShowMenu();
        }

        private void LoadHealthBar(int max)
        {
            app.MonsterMax = max;
        }

        private void UpdateMonsterHealth(int health)
        {
            app.MonsterHealth = health;
        }
    }
}
