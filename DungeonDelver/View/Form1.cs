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

        public Form1()
        {
            // First section of code is setting Form elements to look and behave a specific way.
            InitializeComponent();
            statusText.Text = "";
            statusText.TextChanged += statusText_TextChanged;
            backgroundImage.SizeMode = PictureBoxSizeMode.StretchImage;
            imageDisplay.BackgroundImageLayout = ImageLayout.Stretch;
        }

        // Created this custom event that is handled by the Model-Object (DungeonProgram.cs)
        public event Action<string> PlayerInput;


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




        /*******************************\
         *   General Purpose Methods   *
        \*******************************/

        private void UpdateText(string status)
        {
            statusText.Text += "\n" + status;
        }
        
        public void ToggleInput()
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

        /*******************************\
         *        Item Accessors       *
        \*******************************/
        public string StatusText { get { return null; }  set { statusText.Text += value; } }
        public Bitmap MonsterImage { get { return null; } set { imageDisplay.Image = value; } }

    }
}