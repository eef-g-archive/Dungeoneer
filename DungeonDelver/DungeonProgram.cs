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
            engine = new DungeonEngine(app);
            app.engine = engine;
        }
    }
}
