// @Author: Ethan Gray
/* Purpose:
 * This is the main file for the Controller aspect of the project.
 * It takes in information from both the engine and view aspects and moves the data between them accordingly.
 * It makes use of the CustomEventHandler object to parse all of the custom events that are in the engine and view aspects.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonDelver.Model;
using DungeonDelver.View;

namespace DungeonDelver.Control
{
    public class DungeonController
    {
        // Create variables that will store the model and view components
        public DungeonView app;
        DungeonEngine engine;


        public DungeonController(DungeonView app)
        {
            this.app = app;
            engine = new DungeonEngine();
            CustomEventHandler eventHandler = new CustomEventHandler(app, engine);

            DefaultFileInitialization();
            eventHandler.UpdateSavedProfileList();
            app.ShowMenu();
        }

        // @Author: Ethan Gray
        /* Purpose:
         * This function is run whenever the application is started.
         * It ensures that the file structure for the storage of high scores and player save files is in place on the machine.
         * If the structure is in place, then nothing happens. Otherwise, it creates the folders and files and updates their properties accordingly.
         */
        private void DefaultFileInitialization()
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            docPath += "\\DungeonDelver\\";
            if (!Directory.Exists(docPath))
            {
               DirectoryInfo dirInfo = Directory.CreateDirectory(docPath);
                dirInfo.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            }

            docPath += "\\Scores\\";
            

            if (!Directory.Exists(docPath))
            {
                DirectoryInfo dirInfo = Directory.CreateDirectory(docPath);
                dirInfo.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            }

            string fileName = "Scores.delve";
            string path = Path.Combine(docPath, fileName);
            List<string> lines = new List<string>();
            string defaultScores = Properties.Resources.Default_Scores;
            lines = defaultScores.Split("\n").ToList();
            lines.RemoveAt(lines.Count - 1);
            if(!File.Exists(path))
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    foreach (string line in lines)
                    {
                        string playerScore = line.Substring(0, line.Length - 1);
                        writer.WriteLine(playerScore);
                    }
                }
            }
        }
    }
}
