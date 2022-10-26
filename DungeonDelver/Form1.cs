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


namespace DungeonDelver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            statusText.Text = "";

        }

        /*Author: Ethan Gray
         * Last Edited: 10/26/22
         * 
         */
        private void button1_Click(object sender, EventArgs e) // This is the "FIGHT" button code. Renaming it to fightButton breaks it. Don't know why, it just does.
        {
            imageDisplay.Image = Properties.Resources.Slimev1;
        }

        private void blockButton_Click(object sender, EventArgs e)
        {
            string statusUpdate = "> You feel rested.";
            foreach(char ch in statusUpdate)
            {
                statusText.Text += ch;
            }
        }

        private void healButton_Click(object sender, EventArgs e)
        {

        }

        private void tauntButton_Click(object sender, EventArgs e)
        {

        }
    }
}