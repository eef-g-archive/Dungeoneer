//@Author: Ethan Gray - Oct. 26th, 2022
// Purpose: 
/*  Utilize Object Oriented Programming concepts to create a project
 *  Make an engaging user experience using Windows Forms
 *  Have fun with the project and the end result!
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;

namespace DungeonDelver.View
{
    public partial class DungeonView : Form
    {
        public string outputText;
        public string userName;
        private int playerScore = 0;
        private string updateScore = "";

        public DungeonView()
        {
            // First section of code is setting Form elements to look and behave a specific way.
            InitializeComponent();
            statusText.Text = "";
            statusText.TextChanged += statusText_TextChanged;
            highScoresBox.TextChanged += statusText_TextChanged;
            backgroundImage.SizeMode = PictureBoxSizeMode.StretchImage;
            imageDisplay.BackgroundImageLayout = ImageLayout.Stretch;

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            imageDisplay.BackColor = Color.Transparent;
            imageDisplay.Parent = backgroundImage;
        }

        // Created this custom event that is handled by the Model-Object (DungeonProgram.cs)
        public event Action<string> PlayerInput;
        public event Action<string> NewGame;
        public event Action<string> LoadGame;
        public event Action<int> ChangeDifficulty;
        public event Action<string> NewLine;
        public event Action<List<string>> UpdateScores;

        /*******************\
        |*   Form Inputs   *|
        \*******************/
        #region Input-Handling


        // *** GAME PANEL INPUT HANDLING ***
        #region Game Panel


        /* @Author: Ethan Gray
         * Purpose:
         * These functions handle the input of the buttons the player can press when they're playing the game.
         * Each one will call the custom action PlayerInput() which is handled in the controller.
         */

        // NOTE (11/15/22): This function has been reworked since the 7th and is now handled within the DungeonProgram.cs file.
        private void button1_Click(object sender, EventArgs e) // This is the "FIGHT" button code. Renaming it to fightButton breaks it. Don't know why, it just does.
        {
            PlayerInput("FIGHT");
        }

        private void blockButton_Click(object sender, EventArgs e)
        {
            PlayerInput("BLOCK");
        }

        private void healButton_Click(object sender, EventArgs e)
        { 
            PlayerInput("HEAL");
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            PlayerInput("RUN");
        }

        #endregion


        // *** MENU PANEL INPUT HANDLING *** \\
        #region Menu Panel

        // @Author: Ethan Gray
        /* Purpose:
         * These button inputs handle the UI changes for the main menu when the user navigates the options.
         * It's honestly just a lot of enabling, disabling, hiding, and showing different items on the menu panel.
         */
        private void startButton_Click(object sender, EventArgs e)
        {
            ToggleMenu();
            newChoiceButton.Enabled = true;
            newChoiceButton.Visible = true;
            loadChoiceButton.Enabled = true;
            loadChoiceButton.Visible = true;
        }

        private void newChoiceButton_Click(object sender, EventArgs e)
        {
            ToggleMenu();
            difficultyLabel.Enabled = true;
            difficultyLabel.Visible = false;
            difficultySelect.Enabled = false;
            difficultySelect.Visible = false;
            newGameLabel.Enabled = true;
            newGameLabel.Visible = true;
            userNameInput.Enabled = true;
            userNameInput.Visible = true;
            newGameButton.Enabled = true;
            newGameButton.Visible = true;
            backButton.Enabled = true;
            backButton.Visible = true;
        }

        private void loadChoiceButton_Click(object sender, EventArgs e)
        {
            ToggleMenu();
            difficultyLabel.Enabled = true;
            difficultyLabel.Visible = true;
            difficultySelect.Enabled = true;
            difficultySelect.Visible = true;
            loadLabel.Enabled = true;
            loadLabel.Visible = true;
            savedGamesList.Enabled = true;
            savedGamesList.Visible = true;
            loadGameButton.Enabled = true;
            loadGameButton.Visible = true;
            backButton.Enabled = true;
            backButton.Visible = true;
        }

        private void difficultySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string diff = difficultySelect.Text;
            switch(diff)
            {
                case "Easy":
                    ChangeDifficulty(0);
                    difficultyImage.Image = Properties.Resources.Slimev1;
                    break;
                case "Medium":
                    ChangeDifficulty(1);
                    difficultyImage.Image = Properties.Resources.Frebblev1;
                    break;
                case "Hard":
                    ChangeDifficulty(2);
                    difficultyImage.Image = Properties.Resources.Squifferv1;
                    break;
                case "Extra Hard":
                    ChangeDifficulty(3);
                    difficultyImage.Image = Properties.Resources.Pinchingtonv1;
                    break;
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            ToggleMenu();
            newChoiceButton.Enabled = true;
            newChoiceButton.Visible = true;
            loadChoiceButton.Enabled = true;
            loadChoiceButton.Visible = true;
        }

        // @Author: Ethan Gray
        /* Purpose: 
         * These two inputs handle which type of game is being started.
         * If it's a new game, then we take use the name input to make a new player.
         * If it's a saved game, then we load the game file based off of the user's choice.
         */

        private void newGameButton_Click(object sender, EventArgs e)
        {
            if (userNameInput.Text != "")
            {
                userName = userNameInput.Text;
                playerHealthText.Text = $"{userName}'s Health";
                difficultySelect.Text = "Easy";
                NewGame(userName);
            }
        }

        private void loadGameButton_Click(object sender, EventArgs e)
        {
            LoadGame(savedGamesList.Text);
            playerHealthText.Text = $"{savedGamesList.Text}'s Health";
        }
        #endregion


        // *** RESULTS PANEL INPUT HANDLING *** \\
        #region Results Panel

        // @Author: Ethan Gray
        /* Purpose:
         *  This button input handling lets the player be navigated back to the main menu as well as resets the overall score of the player.
         */
        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            playerScore = 0;
            ShowMenu();
        }


        #endregion

        #endregion

        /*******************************\
         *   General Purpose Methods   *
        \*******************************/
        #region Functions

        // @Author: Ethan Gray
        /* Purpose:
         * Switches off the input on the game panel.
         * Whenever the player takes a turn, we toggle the input temporarily,
         * this is done to avoid the player spamming a move and confusing the enemy.
         */
        public void ToggleInput()
        {
            fightButton.Enabled = !fightButton.Enabled;
            healButton.Enabled = !healButton.Enabled;
            blockButton.Enabled = !blockButton.Enabled;
            runButton.Enabled = !runButton.Enabled;
        }


        // @Author: Ethan Gray
        /* Purpose: 
         * Changes the form's view to be showing the game panel.
         * This also disables every other panel so that way there are not multiple inputs going at once 
         * due to overlapping elements.
         */
        public void ShowGame()
        {
            gamePanel.Enabled = true;
            gamePanel.BringToFront();
            menuPanel.Enabled = false;
            resultsPanel.Enabled = false;
        }

        // @Author: Ethan Gray
        /* Purpose:
         * Similar to ShowGame(), however it does so with the menu panel.
         * This function also resets the game panel and sets up the default settings for the menu panel as well.
         */
        public void ShowMenu()
        {
            ToggleMenu();
            menuPanel.Enabled = true;
            startButton.Visible = true;
            startButton.Enabled = true;
            menuPanel.BringToFront();
            statusText.Text = "";
            gamePanel.Enabled = false;
            resultsPanel.Enabled = false;
            difficultySelect.SelectedIndex = 0;
        }

        // @Author: Ethan Gray
        /* Purpose:
         * Similar to ShowGame(), but does so for the results panel.
         */
        public void ShowResults()
        {
            menuPanel.Enabled = false;
            gamePanel.Enabled = false;
            resultsPanel.BringToFront();
            resultsPanel.Enabled = true;
        }

        // @Author: Ethan Gray
        /* Purpose:
         * Disables and hides the entirety of the menu UI.
         * This is used with the menu UI navigation input handling to cut down on lines of code
         * and focus only on showing and enabling what needs to be visible to the player.
         */
        public void ToggleMenu()
        {
            startButton.Enabled = false;
            startButton.Visible = false;
            newChoiceButton.Enabled = false;
            newChoiceButton.Visible = false;
            loadChoiceButton.Enabled = false;
            loadChoiceButton.Visible = false;
            difficultyLabel.Enabled = false;
            difficultyLabel.Visible = false;
            difficultySelect.Enabled = false;
            difficultySelect.Visible = false;
            loadLabel.Enabled = false;
            loadLabel.Visible = false;
            savedGamesList.Enabled = false;
            savedGamesList.Visible = false;
            loadGameButton.Enabled = false;
            loadGameButton.Visible = false;
            newGameLabel.Enabled = false;
            newGameLabel.Visible = false;
            userNameInput.Enabled = false;
            userNameInput.Visible = false;
            newGameButton.Enabled = false;
            newGameButton.Visible = false;
            backButton.Enabled = false;
            backButton.Visible = false;
        }

        // @Author: Ethan Gray
        /* Purpose:
         * Takes the ID of the room and its score to display the text on the results panel to show the player how they did.
         */
        public void DisplayResult(int room, int roomScore)
        {
            if (roomScore == -1)
            {
                highScoresBox.Text += $"Room {room}\n...............................................DIED\n\n";
                playerScore = 0;
            }
            else if (roomScore == -2)
            {
                highScoresBox.Text += $"Room {room}\n...............................................FLED\n\n";
                playerScore = 0;
            }
            else
            {
                highScoresBox.Text += $"Room {room}\n...............................................{roomScore}\n\n";
                playerScore += roomScore;
            }
        }

        // @Author: Ethan Gray
        /* Purpose:
         * Goes through the existing high scores that are stored on the system.
         * If the player's score from the current run is larger than other scores, it will replace the highest score that it can.
         * However, this function only returns the integer of the index that will be replaced.
         */
        private int CalculateHighScores(List<int> highScores)
        {
            int replaceIndex = -1;
            int[] scores = highScores.ToArray();
            for(int i = scores.Length - 1; i >= 0; i--)
            {
                if(playerScore > scores[i])
                {
                    replaceIndex = i;
                }    
            }
            return replaceIndex;
        }

        // @Author: Ethan Gray
        /* Purpose:
         * Reads the high scores file that is stored on the system.
         * Goes through each line in the file and displays it for the player to see on the results panel.
         */
        public void DisplayHighScores()
        {
            List<string> lines = new List<string>();
            List<int> scores = new List<int>();
            string fileName = "Scores.delve";
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            docPath += "\\DungeonDelver\\Scores\\";

            try
            {
                using (StreamReader reader = new StreamReader(Path.Combine(docPath, fileName)))
                {
                    while (!reader.EndOfStream)
                    {
                        lines.Add(reader.ReadLine());
                    }
                }

                foreach(string line in lines)
                {
                    int scoreBeginningIndex = line.IndexOf(":");
                    string scoreString = line.Substring(scoreBeginningIndex+1, line.Length - scoreBeginningIndex - 1);
                    int x = 0;
                    int score = Convert.ToInt32(scoreString);
                    scores.Add(score);
                }

                int replaceIndex = CalculateHighScores(scores);
                if(replaceIndex != -1)
                {
                    List<string> new_lines = new List<string>();
                    for(int i = 0; i < lines.Count; i++)
                    {
                        if(i < replaceIndex)
                        {
                            new_lines.Add(lines.ElementAt(i));
                        }
                        else if (i == replaceIndex)
                        {
                            NewLine(playerScore.ToString());
                            new_lines.Add(updateScore);
                        }
                        else
                        {
                            try
                            {
                                new_lines.Add(lines.ElementAt(i - 1));
                            }
                            catch(Exception ex)
                            {
                                continue;
                            }
                        }
                    }
                    lines = new_lines;
                }


                highScoresBox.Clear();
                highScoresBox.Text = "Highscores\n";
                

                foreach(string line in lines)
                {
                    highScoresBox.Text += "\n";
                    int scoreSeparator = line.IndexOf(":");
                    string scoreLine = $"{line.Substring(0, scoreSeparator)} --- {line.Substring(scoreSeparator+1)}";
                    highScoresBox.Text += scoreLine;
                }
                highScoresBox.SelectAll();
                highScoresBox.SelectionAlignment = HorizontalAlignment.Center;

                UpdateScores(lines);
            }
            catch(Exception ex)
            {
                return;
            }
        }


        #endregion

        /*******************************\
         *      Behavior Changes       *
        \*******************************/
        #region Custom-Behaviors

        // @Author: Ethan Gray
        // @Purpose:
        /* Behavioral code that allows the textbox to automatically scroll
         * DO. NOT. TOUCH. If you tweak it, then it can cause the main method of communicating to the player to break.
         */
        private void statusText_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            statusText.SelectionStart = statusText.Text.Length;
            // scroll it automatically
            statusText.ScrollToCaret();
        }

        #endregion

        /*******************************\
         *        Item Accessors       *
        \*******************************/
        #region Getters-Setters
        // @Author: Ethan Gray
        /* Section Purpose:
         * Custom getters and setters to allow for data to be received from the controller.
         * This data is used in the custom setters that take the data and update the UI accordingly.
         */


        // Purpose: Updates the status text box on the game panel with the text that is sent from the controller.
        public string StatusText 
        { 
            get { return null; }  
            set 
            {
                if (value != "")
                    statusText.Text += value;
                else
                    statusText.Text = "";
            }
        }


        // Purpose: Takes the Bitmap of an image from the controller and uses it to update the image of the monster that is visible to the player.
        // NOTE: This is used to show both the idle and hurt images of the monster.
        public Bitmap MonsterImage { get { return null; } set { imageDisplay.Image = value; } }


        // Purpose: This is a getter that is used to allow for data from the difficultySelect comboBox to be used in the controller.
        public int GameDifficulty
        {
            get
            {
                switch (difficultySelect.Text)
                {
                    case "Easy":
                        return 3;
                        break;
                    case "Medium":
                        return 5;
                        break;
                    case "Hard":
                        return 8;
                        break;
                    case "Extra Hard":
                        return 12;
                        break;
                    default:
                        return 3;
                }
            }
        }


        // Purpose: This setter allows for the list of saved files to be updated via the controller.
        public string ProfileList
        {
            get { return savedGamesList.Text;  }
            set 
            {
                if (value == "")
                {
                    savedGamesList.Items.Clear();
                }
                else
                {
                    savedGamesList.Items.Add(value);
                }
            }
        }


        // Purpose: This is used as a public getter to let the saved games be accessible by the controller.
        public List<string> ExistingProfiles
        {
            get 
            {
                List<string> items = new List<string>();
                foreach(string i in savedGamesList.Items)
                {
                    items.Add(i);
                }
                return items;
            }

        }


        // Purpose: This is a custom setter that allows for the controller to update the values of the progress bar with the monster's health values.
        public int MonsterMax
        {
            get { return 0; }
            set { monsterHealthBar.Maximum = value; monsterHealthBar.Value = value; }
        }


        // Purpose: This is a custom setter than allows for the value of the monster health bar to be updated to represent the monster's current health.
        public int MonsterHealth
        {
            get { return 0; }
            set 
            {
                if (value < 0) { monsterHealthBar.Value = 0; }
                else { monsterHealthBar.Value = value; }  
            }
        }


        // Purpose: Custom setter that allows for the player's statusBar health bar to be updated when they level up and have a new max health.
        public int PlayerMax
        {
            get { return playerHealthBar.Maximum; }
            set { playerHealthBar.Maximum = value; playerHealthBar.Value = value; }
        }


        // Purpose: Custom setter that allows for the player's health bar to be updated when they take damage or heal.
        public int PlayerHealth
        {
            get { return playerHealthBar.Value;  }
            set
            {
                if(value < 0 ) {  playerHealthBar.Value = 0; }
                else { playerHealthBar.Value = value;  }
            }
        }


        // Purpose: Custom setter that updates the text representation of the player's current health.
        public int[] HealthText
        {
            get { return null; }
            set
            {
                playerHPText.Text = $"{value[0]} \\ {value[1]}";
            }
        }


        // Purpose: Custom setter that allows for a new game to be made from the controller.
        public string NewPlayerName
        {
            get { return "DUMMY TEXT";  }
            set { userNameInput.Text = value; }
        }


        // Purpose: Custom getter-setter that allows for the control of the visible blocking icon on the UI via a boolean.
        public bool Block
        {
            get { return playerBlockingIcon.Visible; }
            set { playerBlockingIcon.Visible = value; }
        }


        // Purpose: Custom setter that allows for the richTextBox on the results panel to be updated with the specific value given to it. (This comes from the contorller)
        public string Results
        {
            get { return highScoresBox.Text; }
            set
            {
                if (value == "")
                {
                    highScoresBox.Text = "";
                }
                else
                {
                    highScoresBox.Text += value;
                }
            }
        }


        // Purpose: Custom setter that takes a string value formatted to match the highscore file that is received from the controller.
        public string NewString
        {
            get { return "Hello world"; }
            set { updateScore = value; }
        }

        #endregion


    }
}