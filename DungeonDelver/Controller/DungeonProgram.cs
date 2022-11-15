using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonDelver
{
    internal class DungeonProgram
    {
        public Form1 app;
        DungeonEngine engine;

        public DungeonProgram(Form1 app)
        {
            this.app = app;
            engine = new DungeonEngine();

            // This here is where we assign the custom events to the functions that will run when triggered.
            app.PlayerInput += new Action<string>(PlayerinputHandler);
            engine.TextOut += new Action<string>(TextHandler);
            engine.ImageOut += new Action<Bitmap>(ImageHandler);

            // Finish Initializing the dungeon
            engine.NextRoom();
        }

        /*******************************\
         *          Functions          *
        \*******************************/


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
                    break;
                case "RUN":
                    break;
            }
            app.ToggleInput();
        }

        private void TextHandler(string flavorText)
        {
            app.StatusText = flavorText;
        }

        private void ImageHandler(Bitmap image)
        {
            app.MonsterImage = image;
        }
    }
}
