using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonDelver.Model;
using DungeonDelver.View;

namespace DungeonDelver.Control;
internal class CustomEventHandler
{
    DungeonView app;
    DungeonEngine engine;

    // Create variables that will store data to be used later
    int[] player_stats = { 0, 0 };

    public CustomEventHandler(DungeonView app, DungeonEngine engine)
    {
        this.app = app;
        this.engine = engine;
        // This here is where we assign the custom events to the functions that will run when triggered.
        app.PlayerInput += new Action<string>(PlayerinputHandler);
        app.NewGame += new Action<string>(BeginNewGame);
        app.LoadGame += new Action<string>(LoadOldGame);
        app.ChangeDifficulty += new Action<int>(SwitchDifficulty);


        engine.TextOut += new Action<string>(TextHandler);
        engine.ImageOut += new Action<Bitmap>(ImageHandler);
        engine.GameEnd += new Action<string>(FinishDungeon);
        engine.MonsterUpdate += new Action<int>(UpdateMonsterHealth);
        engine.NewMonster += new Action<int>(LoadHealthBar);
        engine.PlayerMaxBar += new Action<int>(StartPlayerHealthBar);
        engine.PlayerUpdate += new Action<int>(UpdatePlayerBar);
        engine.PlayerBlockIcon += new Action<bool>(UpdateBlockingIcon);
    }

    /*******************************\
     *          Functions          *
    \*******************************/
    #region ControllerFunctions

    private void SaveGame()
    {
        string[] lines =
        {
            $"{engine.player.name}", $"{engine.player.dungeons_completed}", $"{engine.player.dungeons_attempted}",
            $"{engine.player.overall_xp}", $"{engine.player.curr_xp}", $"{engine.player.level}",
            $"{engine.player.max_health}", $"{engine.player.healPower}", $"{engine.player.Damage}"
        };
        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        docPath += "\\DungeonDelver\\";

        if (!System.IO.Directory.Exists(docPath))
        {
            DirectoryInfo dirInfo = Directory.CreateDirectory(docPath);
            dirInfo.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
        }
        using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, $"{engine.player.name}_save.delve")))
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

        if (!System.IO.Directory.Exists(docPath))
        {
            DirectoryInfo dirInfo = Directory.CreateDirectory(docPath);
            dirInfo.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
        }

        string[] fileNames = System.IO.Directory.GetFiles(docPath);

        if (fileNames.Length >= 1)
        {
            foreach (string fileName in fileNames)
            {
                int nameEnd = fileName.LastIndexOf('_');
                int nameBegin = fileName.LastIndexOf('\\') + 1;
                string profileName = fileName.Substring(nameBegin, nameEnd - nameBegin);

                profiles.Add(profileName);
            }
        }
        return profiles;
    }

    public void UpdateSavedProfileList()
    {
        app.ProfileList = "";
        List<string> savedProfiles = GetSavedProfiles();
        foreach (string profile in savedProfiles)
        {
            app.ProfileList += profile;
        }
    }

    private void BeginGame()
    {
        engine.GenerateDungeon(app.GameDifficulty);
        app.ShowGame();
        engine.NextRoom();
        StartPlayerHealthBar(engine.player.Health);
        Console.WriteLine(app.PlayerMax);
    }

    private void DeleteGame(string playerName)
    {
        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        docPath += "\\DungeonDelver\\";
        DirectoryInfo di = new DirectoryInfo(docPath);
        foreach (FileInfo file in di.GetFiles())
        {
            string fileName = file.Name;
            int fileEnd = fileName.LastIndexOf('_');
            string saveFile = fileName.Substring(0, fileEnd);
            if (saveFile == playerName)
            {
                file.Delete();
            }
        }
    }
    #endregion


    /*******************************\
     *        Custom Events        *
    \*******************************/
    #region EventHandlers
    private void PlayerinputHandler(string playerInput)
    {
        app.ToggleInput();
        switch (playerInput)
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
        app.NewPlayerName = "";
    }

    private void LoadOldGame(string playerName)
    {
        // Load stats from file first by using the playerName variable
        string fileName = playerName + "_save.delve";
        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        docPath += "\\DungeonDelver\\";

        if (!System.IO.Directory.Exists(docPath))
        {
            DirectoryInfo dirInfo = Directory.CreateDirectory(docPath);
            dirInfo.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
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
             * overall_xp
             * curr_xp
             * level
             * max_health
             * healPower
             * damage
             */
            int[] stats =
            {
                Convert.ToInt32(lines.ElementAt(1)),
                Convert.ToInt32(lines.ElementAt(2)),
                Convert.ToInt32(lines.ElementAt(3)),
                Convert.ToInt32(lines.ElementAt(4)),
                Convert.ToInt32(lines.ElementAt(5)),
                Convert.ToInt32(lines.ElementAt(6)),
                Convert.ToInt32(lines.ElementAt(7)),
                Convert.ToInt32(lines.ElementAt(8))
            };

            engine.player.LoadStats(lines.ElementAt(0), stats);
            BeginGame();
        }
        catch (Exception ex)
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
        if (end == "Death")
        {
            try
            {
                DeleteGame(engine.player.name);
            }
            catch (Exception ex)
            {
                // If this is a brand new file and hadn't been saved yet, don't worry!
            }
        }
        else
        {
            SaveGame();
        }
        app.ShowMenu();
        UpdateSavedProfileList();
    }

    private void LoadHealthBar(int max)
    {
        app.MonsterMax = max;
    }

    private void UpdateMonsterHealth(int health)
    {
        app.MonsterHealth = health;
    }

    private void StartPlayerHealthBar(int max)
    {
        app.PlayerMax = max;
        player_stats[0] = max;
        player_stats[1] = max;
        app.HealthText = player_stats;
        app.PlayerHealth = max;
    }

    private void UpdatePlayerBar(int health)
    {
        app.PlayerHealth = health;
        player_stats[0] = health;
        app.HealthText = player_stats;
    }

    private void UpdateBlockingIcon(bool status)
    {
        app.Block = status;
    }

    private void SwitchDifficulty(int difficulty)
    {
        engine.dungeonDifficulty = difficulty;
    }

    #endregion

}
