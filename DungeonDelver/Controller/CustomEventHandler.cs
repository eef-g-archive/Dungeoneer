// @Author: Ethan Gray
/* Purpose:
 * This is the Custom Event Handler that the controller aspect makes use of.
 * It is a collection of all the functions that are run whenever the custom events in the model and view aspects are triggered.
 */

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
        app.NewLine += new Action<string>(ScoreInfo);
        app.UpdateScores += new Action<List<string>>(UpdateScores);


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

    // @Author: Ethan Gray
    /* Purpose:
     * Takes the informaton from the player that was used in the current game.
     * Stores that information on a .DELVE file on the computer to be read later with the game being loaded.
     */
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

    // @Author: Ethan Gray
    /* Purpose:
     * Goes to the folder that contains all of the saved game files and grabs the profile names for each file.
     * Returns a List<string> of the profile names it finds.
     * NOTE: It does not check if the file is correctly saved, it only checks for profile names.
     */
    private List<string> GetSavedProfiles()
    {
        List<string> profiles = new List<string>();
        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        docPath += "\\DungeonDelver\\";

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

    // @Author: Ethan Gray
    /* Purpose:
     * Goes through all of the profile names that GetSavedProfiles is able to find.
     * Those names are then send to the view aspect to update the profile select comboBox.
     */
    public void UpdateSavedProfileList()
    {
        app.ProfileList = "";
        List<string> savedProfiles = GetSavedProfiles();
        foreach (string profile in savedProfiles)
        {
            app.ProfileList += profile;
        }
    }

    // @Author: Ethan Gray
    /* Purpose:
     * This method sets up the entire game as well as updates the UI to let the player see & play the game.
     */
    private void BeginGame()
    {
        engine.GenerateDungeon(app.GameDifficulty);
        app.ShowGame();
        engine.NextRoom();
        StartPlayerHealthBar(engine.player.Health);
        Console.WriteLine(app.PlayerMax);
    }

    // @Author: Ethan Gray
    /* Purpose:
     * This method is run if the player loses the game. The concept of the game is that you're an adventurer with only 1 life,
     * so if the player dies, then their save file is deleted and they cannot play as that character ever again.
     * It works by using the current player's name, locates the savefile for that player and deletes the file.
     */
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

    // @Author: Ethan Gray
    /* Purpose:
     * Takes the player's choice for their turn from the view aspect's input handlers and sends the data to the model aspect.
     */
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


    // @Author: Ethan Gray
    /* Purpose:
     * Takes the player-input name from the view aspect and runs logic to ensure that the name is not an existing profile.
     * It then spits the information right back to the view aspect and runs the BeginGame() function to start the game.
     */
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


    // @Author: Ethan Gray
    /* Purpose:
     * This has a similar purpose to the BeginNewGame() function, however instead of parsing the user-input name,
     * it will take the name chosen from the comboBox and finds the .DELVE file corresponding to the profile the player selected.
     * Afterwards, it will then begin the game with the data that is loaded off of the .DELVE file.
     */
    private void LoadOldGame(string playerName)
    {
        // Load stats from file first by using the playerName variable
        string fileName = playerName + "_save.delve";
        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        docPath += "\\DungeonDelver\\";

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


    // @Author: Ethan Gray
    /* Purpose:
     * Takes text related to the status of the game/turn from the model aspect and sends it to the view aspect.
     */
    private void TextHandler(string flavorText)
    {
        app.StatusText = flavorText;
    }


    // @Author: Ethan Gray
    /* Purpose:
     * Takes a Bitmap of an image from the model aspect and sends it to the view aspect to display it as the current enemy sprite.
     */
    private void ImageHandler(Bitmap image)
    {
        app.MonsterImage = image;
    }


    // @Author: Ethan Gray
    /* Purpose:
     * Takes a status string from the model aspect to determine how the game ended.
     * Depending on the end condition, different logic is run to either update or delete the player file,
     * show the results of the run, and finally display the overall high scores of the game.
     */
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
        app.ShowResults();
        app.Results = "";
        engine.wait(500);

        int index = 0;
        foreach (int score in engine.roomScores)
        {
            app.DisplayResult(index + 1, score);
            index++;
            engine.wait(500);
        }
        engine.wait(3000);
        app.DisplayHighScores();
        UpdateSavedProfileList();
    }


    // @Author: Ethan Gray
    /* Purpose:
     * Takes data from the model aspect about the health stats of the new monster the payer is facing.
     * It then uses that data and sends it to the view aspect to use as the new maximum value for the statusBar used as a healthbar for the
     * enemy.
     */
    private void LoadHealthBar(int max)
    {
        app.MonsterMax = max;
    }


    // @Author: Ethan Gray
    /* Purpose:
     * Takes the current health of the monster the player is facing from the model aspect and sends it to the view aspect.
     * The view aspect will then parse that data and update the monster's health bar on the UI.
     */
    private void UpdateMonsterHealth(int health)
    {
        app.MonsterHealth = health;
    }


    // @Author: Ethan Gray
    /* Purpose:
     * Takes the player's maximum health from the model aspect and sends it to the view aspect.
     * The view aspect will then use it to set up and initialize the player's health bar at the beginning of the game.
     */
    private void StartPlayerHealthBar(int max)
    {
        app.PlayerMax = max;
        player_stats[0] = max;
        player_stats[1] = max;
        app.HealthText = player_stats;
        app.PlayerHealth = max;
    }


    // @Author: Ethan Gray
    /* Purpose:
     * Similar to the purpose of the UpdateMonsterHealth() function, but instead of the monster's data it uses data about the 
     * player from the model aspect.
     */
    private void UpdatePlayerBar(int health)
    {
        app.PlayerHealth = health;
        player_stats[0] = health;
        app.HealthText = player_stats;
    }


    // @Author: Ethan Gray
    /* Purpose:
     * Takes the boolean related to the player's state concerning blocking from the model aspect and sends it to the view aspect.
     * The bool is then parsed by the view aspect to determine whether or not to have the blocking icon visible to the player.
     */
    private void UpdateBlockingIcon(bool status)
    {
        app.Block = status;
    }


    // @Author: Ethan Gray
    /* Purpose:
     * Takes the difficulty from the difficultySelect comboBox on the menu panel from the view aspect.
     * It is then sent to the model aspect to be parsed to determine how to create and edit the monsters in the dungeon when the game is started.
     */
    private void SwitchDifficulty(int difficulty)
    {
        engine.dungeonDifficulty = difficulty;
    }


    // @Author: Ethan Gray
    /* Purpose:
     * Takes a request from the view aspect to have the model aspect create a line that follows the format of the highscores file.
     * This line is then sent back to the view model after it has been created to be used in editing the highscore file and displaying
     * it to the player.
     */
    private void ScoreInfo(string playerScore)
    {
        app.NewString = $"{engine.player.name}:{playerScore}";
    }


    // @Author: Ethan Gray
    /* Purpose:
     * Takes a request from the view aspect to save the highscores file. It takes the List<string> of all the highscores.
     * With that list, the highscores file is then rewritten with the newest set of highscores.
     */
    private void UpdateScores(List<string> lines)
    {
        string fileName = "Scores.delve";
        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        docPath += "\\DungeonDelver\\Scores\\";

        try
        {
            using (StreamWriter writer = new StreamWriter(Path.Combine(docPath, fileName)))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    #endregion

}
