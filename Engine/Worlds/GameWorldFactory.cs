namespace Engine.Worlds
{
    internal class GameWorldFactory
    {
        internal GameWorld CreateWorld()
        {
            GameWorld newWorld = new GameWorld();
            return newWorld;
        }        
    }
}
