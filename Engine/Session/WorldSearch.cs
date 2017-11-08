using Engine.Worlds;

namespace Engine.Session
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
