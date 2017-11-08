using System;
using System.Collections.Generic;

namespace Engine.Worlds
{
    public class Location
    {
        public List<String> _exits;
        public Location(int id, string name, int zone, int xCoord, int yCoord, string description, string climate, string terrain, string effect, string exits,
                        string teleportOut, string teleportIn)
        {
            ID = id;
            Name = name;
            Zone = zone;
            XCoord = xCoord;
            YCoord = yCoord;
            Description = description;
            Climate = climate;
            Terrain = terrain;
            Effect = effect;
            Exits = BuildExits(exits);
            TeleportOut = teleportOut;
            TeleportIn = teleportIn;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int Zone { get; set; }
        public int XCoord { get; set; }
        public int YCoord { get; set; }
        public string Description { get; set; }
        public string Climate { get; set; }
        public string Terrain { get; set; }
        public string Effect { get; set; }
        public List<String> Exits { get { return _exits; } set { _exits = value; } }
        public string TeleportOut { get; set; }
        public string TeleportIn { get; set; }

        public List<String> BuildExits(string exit)
        {
            List<String> _exits = new List<String>();
            char delim = ',';
            string[] tokens = exit.Split(delim);

            foreach (string t in tokens)
            {
                _exits.Add(t.ToString());
            }
            return _exits;
        }
    }
}
