using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Model
{
    public class Location
    {
        public Location(int id, string name, int zone, int xCord, int yCord, string description, string climate, string terrain, string effect, string exits)
        {
            ID = id;
            Name = name;
            Zone = zone;
            XCord = xCord;
            YCord = yCord;
            Description = description;
            Climate = climate;
            Terrain = terrain;
            Effect = effect;
            Exits = BuildExits(exits);
            Teleport = null;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int Zone { get; set; }
        public int XCord { get; set; }
        public int YCord { get; set; }
        public string Description { get; set; }
        public string Climate { get; set; }
        public string Terrain { get; set; }
        public string Effect { get; set; }
        public List<String> Exits { get; set; }
        public string Teleport { get; set; }

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
