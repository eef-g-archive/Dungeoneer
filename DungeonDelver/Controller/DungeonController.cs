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
            
            eventHandler.UpdateSavedProfileList();
            app.ShowMenu();
        }
    }
}
