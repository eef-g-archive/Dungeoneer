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
        bool firstLine;
        int curr_room;
        DungeonEngine engine;
        int dungeon_length;
        public Form1()
        {
            // First section of code is setting Form elements to look and behave a specific way.
            InitializeComponent();
            statusText.Text = "";
            firstLine = true;
            statusText.TextChanged += statusText_TextChanged;


            // Here is where we create our main "DungeonEngine" object. This manages the entire project's backend.
            engine = new DungeonEngine();
            dungeon_length  = 11;
            engine.GenerateDungeon(dungeon_length);
            curr_room = 1;
        }

        /*Author: Ethan Gray
         * Last Edited: 10/28/22
         * 
         */
        private void button1_Click(object sender, EventArgs e) // This is the "FIGHT" button code. Renaming it to fightButton breaks it. Don't know why, it just does.
        {
            if (curr_room < dungeon_length) // If still in dungeon, then go ahead and display the monster as well as update the current room the player is in
            {
                string encounter_text = $"> You enter Room number {curr_room} and find an enemy {engine.rooms.ElementAt(curr_room).enemy.name}! Prepare to fight.";
                if (firstLine) { statusText.Text += encounter_text; firstLine = false; }
                else { statusText.Text += $"\n{encounter_text}"; }
                imageDisplay.Image = engine.rooms.ElementAt(curr_room).enemy.defaultPortrait;
                curr_room++;
            }
            else // Clear the screen of the monsters entirely and then let the player know the game is over.
            {
                statusText.Text += $"\n> You've completed the dungeon! Go home.";
                imageDisplay.Image = Properties.Resources.CreatureBackground;
            }
        }

        private void blockButton_Click(object sender, EventArgs e)
        {
            string statusUpdate = "> You feel rested.";
            if (firstLine) { statusText.Text += statusUpdate; firstLine = false; }
            else { statusText.Text += $"\n{statusUpdate}";  }
        }

        private void healButton_Click(object sender, EventArgs e)
        {

        }

        private void tauntButton_Click(object sender, EventArgs e)
        {

        }


        private void statusText_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            statusText.SelectionStart = statusText.Text.Length;
            // scroll it automatically
            statusText.ScrollToCaret();
        }
    }
}