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
        DungeonEngine engine;
        public Form1()
        {
            // First section of code is setting Form elements to look and behave a specific way.
            InitializeComponent();
            statusText.Text = "";
            statusText.TextChanged += statusText_TextChanged;
            backgroundImage.SizeMode = PictureBoxSizeMode.StretchImage;
            imageDisplay.BackgroundImageLayout = ImageLayout.Stretch;

            // Here is where we create our main "DungeonEngine" object. This manages the entire project's backend.
            engine.NextRoom();

            // Update the form w/ data from the engine.
            statusText.Text = engine.outputText;
            imageDisplay.Image = engine.monsterImage;
        }


        /*******************\
        |*   Form Inputs   *|
        \*******************/ 
        
        /* @Author: Ethan Gray
         * Last Edited: 11/07/22
         * Purpose:
         * Logic when the FIGHT button is pressed.
         * Works w/ the engine object to make sure we use that object for all the interactions & get info from it as well
         * Updates the visuals accordingly as well.
         */
        private void button1_Click(object sender, EventArgs e) // This is the "FIGHT" button code. Renaming it to fightButton breaks it. Don't know why, it just does.
        {
            ToggleInput();
            engine.GameTurn("FIGHT");
            UpdateText(engine.outputText);
            imageDisplay.Image = engine.monsterImage;
            ToggleInput();
            /*
            // Initial Player turn logic
            ToggleInput();
            engine.AttackLogic();
            UpdateText(engine.outputText);
            imageDisplay.Image = engine.monsterImage;

            // Monster Turn Logic
            engine.wait(500);
            engine.AttackLogic();
            UpdateText(engine.outputText);
            imageDisplay.Image = engine.monsterImage;
            ToggleInput();
            */
        }

        private void blockButton_Click(object sender, EventArgs e)
        {

        }

        private void healButton_Click(object sender, EventArgs e)
        {

        }


        private void runButton_Click(object sender, EventArgs e)
        {
            engine.current_room = 999;
            engine.NextRoom();
            statusText.Text += "\n> You decide to flee the dungeon and escape with only your life.";
            // EGEGEGEGEGEGEGEGEG
            // Later on, need to throw the user into the main menu screen and not just tell them they fled.
        }




        /*******************************\
         *   General Purpose Methods   *
        \*******************************/

        private void UpdateText(string status)
        {
            statusText.Text += "\n" + status;
        }
        
        private void ToggleInput()
        {
            fightButton.Enabled = !fightButton.Enabled;
            healButton.Enabled = !healButton.Enabled;
            blockButton.Enabled = !blockButton.Enabled;
            runButton.Enabled = !runButton.Enabled;
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


    }
}