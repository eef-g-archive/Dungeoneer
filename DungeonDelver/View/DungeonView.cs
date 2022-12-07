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

        public DungeonView()
        {
            // First section of code is setting Form elements to look and behave a specific way.
            InitializeComponent();
            statusText.Text = "";
            statusText.TextChanged += statusText_TextChanged;
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


        /*******************\
        |*   Form Inputs   *|
        \*******************/
        #region Input-Handling


        // *** GAME PANEL INPUT HANDLING ***
        #region Game Panel
        /* @Author: Ethan Gray
         * Last Edited: 11/07/22
         * Purpose:
         * Logic when the FIGHT button is pressed.
         * Works w/ the engine object to make sure we use that object for all the interactions & get info from it as well
         * Updates the visuals accordingly as well.
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
            difficultyLabel.Visible = true;
            difficultySelect.Enabled = true;
            difficultySelect.Visible = true;
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
                    ChangeDifficulty(0);
                    difficultyImage.Image = Properties.Resources.Frebblev1;
                    break;
                case "Hard":
                    ChangeDifficulty(0);
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

        private void newGameButton_Click(object sender, EventArgs e)
        {
            if (userNameInput.Text != "")
            {
                userName = userNameInput.Text;
                playerHealthText.Text = $"{userName}'s Health";
                NewGame(userName);
            }
        }

        private void loadGameButton_Click(object sender, EventArgs e)
        {
            LoadGame(savedGamesList.Text);
            playerHealthText.Text = $"{savedGamesList.Text}'s Health";
        }
        #endregion

        #endregion


        /*******************************\
         *   General Purpose Methods   *
        \*******************************/
        #region Functions


        public void ToggleInput()
        {
            fightButton.Enabled = !fightButton.Enabled;
            healButton.Enabled = !healButton.Enabled;
            blockButton.Enabled = !blockButton.Enabled;
            runButton.Enabled = !runButton.Enabled;
        }

        public void ShowGame()
        {
            gamePanel.Enabled = true;
            gamePanel.BringToFront();
            menuPanel.Enabled = false;
        }

        public void ShowMenu()
        {
            ToggleMenu();
            menuPanel.Enabled = true;
            startButton.Visible = true;
            startButton.Enabled = true;
            menuPanel.BringToFront();
            statusText.Text = "";
            gamePanel.Enabled = false;
            difficultySelect.SelectedIndex = 0;
        }

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

        #endregion

        /*******************************\
         *      Behavior Changes       *
        \*******************************/
        #region Custom-Behaviors

        // @Author: Ethan Gray
        // Last Edited - 11/01/22
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

        public Bitmap MonsterImage { get { return null; } set { imageDisplay.Image = value; } }

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

        public int MonsterMax
        {
            get { return 0; }
            set { monsterHealthBar.Maximum = value; monsterHealthBar.Value = value; }
        }

        public int MonsterHealth
        {
            get { return 0; }
            set 
            {
                if (value < 0) { monsterHealthBar.Value = 0; }
                else { monsterHealthBar.Value = value; }  
            }
        }

        public int PlayerMax
        {
            get { return playerHealthBar.Maximum; }
            set { playerHealthBar.Maximum = value; playerHealthBar.Value = value; }
        }

        public int PlayerHealth
        {
            get { return playerHealthBar.Value;  }
            set
            {
                if(value < 0 ) {  playerHealthBar.Value = 0; }
                else { playerHealthBar.Value = value;  }
            }
        }

        public int[] HealthText
        {
            get { return null; }
            set
            {
                playerHPText.Text = $"{value[0]} \\ {value[1]}";
            }
        }

        public string NewPlayerName
        {
            get { return "DUMMY TEXT";  }
            set { userNameInput.Text = value; }
        }

        public bool Block
        {
            get { return playerBlockingIcon.Visible; }
            set { playerBlockingIcon.Visible = value; }
        }




        #endregion


    }
}