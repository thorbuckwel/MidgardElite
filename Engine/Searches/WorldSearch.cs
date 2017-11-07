using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Model;
using Engine.ViewModels;

namespace Engine.Searches
{
    public class WorldSearch
    {
        public static void GetTeleportLocation(string noun)
        {
            foreach (Location loc in GameWorld._locations)
            {
                if (loc.TeleportIn == GameSession.CurrentLocation.TeleportOut)
                    GameSession.CurrentLocation = loc;
                    break;
            }
            //return null;
        }
    }
}
