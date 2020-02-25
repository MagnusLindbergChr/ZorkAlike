using System;
using System.Collections.Generic;

namespace ZorkAlike
{
    public class World
    {
        List<Area> allAreas = new List<Area>();
        Area startingArea;
        Area currentArea;

        public World()
        {
            Area a1 = new Area("Dungeon of Puff the magic dragon", "This is where you start");
            Area a2 = new Area("Anders' kingdom", "It's empty. NO friends, NO family... Abseloutly no life");
            Area a3 = new Area("Mushroom forest", "Everything is square");
            Area a4 = new Area("Teapot area", "You are surrounded by tea");
            Area a5 = new Area("Magnus' kingdom", "The happiest place on earth. Girls, food and money everywhere");

            a4.Connect(a5, Directions.South);
            a1.ConnectBiDirectional(a3, Directions.West);
            a3.ConnectBiDirectional(a4, Directions.South);
            a4.ConnectBiDirectional(a2, Directions.East);
            a5.Connect(a3, Directions.South);
            a2.Connect(a1, Directions.North);

            startingArea = a1;
            currentArea = a1;
        }
    }
}
