using System;
namespace ZorkAlike
{
    public class Area
    {
        class Area
        {
            // Checking possible direction.
            // Constructor that defines area and which treasures, items and interactable items that are.
            // Description of the area surroundings.
            Dictionary<Directions, Area> neighbors = new
                Dictionary<Directions, Area>();

            List<Items> items = new List<Items>();

            string description;
            string name;

            public Area(string name, string description)
            {
                this.name = name;
                this.description = description;
            }

            public void Connect(Area otherArea, Directions dir)
            {
                neighbors.Add(dir, otherArea);
            }

            public void ConnectBiDirectional(Area otherArea, Directions dir)
            {
                Connect(otherArea, dir);
                otherArea.Connect(this, Opposite(dir));
            }

            Directions Opposite(Directions dir)
            {
                switch (dir)
                {
                    case Directions.North:
                        return Directions.South;
                    case Directions.South:
                        return Directions.North;
                    case Directions.East:
                        return Directions.West;
                    case Directions.West:
                        return Directions.East;
                    default:
                        return Directions.North;
                }
            }
        }

        public enum Directions
        {
            North, West, East, South
        }
    }
}
