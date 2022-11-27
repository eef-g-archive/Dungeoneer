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

namespace DungeonDelver
{
    public partial class Form1 : Form
    {
        public string outputText;
        public string userName;

        public Form1()
        {
            // First section of code is setting Form elements to look and behave a specific way.
            InitializeComponent();
            statusText.Text = "";
            statusText.TextChanged += statusText_TextChanged;
            backgroundImage.SizeMode = PictureBoxSizeMode.StretchImage;
            imageDisplay.BackgroundImageLayout = ImageLayout.Stretch;
            difficultySelect.SelectedIndex = 0;
        }

        // Created this custom event that is handled by the Model-Object (DungeonProgram.cs)
        public event Action<string> PlayerInput;
        public event Action<string> NewGame;
        public event Action<string> LoadGame;


        /*******************\
        |*   Form Inputs   *|
        \*******************/ 
        


        // *** GAME PANEL INPUT HANDLING ***
        
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

        // *** MENU PANEL INPUT HANDLING *** \\

        private void newGameButton_Click(object sender, EventArgs e)
        {
            if (userNameInput.Text != "")
            {
                userName = userNameInput.Text;
                NewGame(userName);
            }
        }

        private void loadGameButton_Click(object sender, EventArgs e)
        {
            LoadGame(savedGamesList.Text);
        }





        /*******************************\
         *   General Purpose Methods   *
        \*******************************/

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
            menuPanel.Enabled = true;
            menuPanel.BringToFront();
            statusText.Text = "";
            gamePanel.Enabled = false;
        }



        /*******************************\
         *      Behavior Changes       *
        \*******************************/

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

        /*******************************\
         *        Item Accessors       *
        \*******************************/
        public string StatusText { get { return null; }  set { statusText.Text += value; } }
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
            set { savedGamesList.Items.Add(value); }
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
    }
}