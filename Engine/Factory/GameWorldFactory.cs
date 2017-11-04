using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Model;

namespace Engine.Factory
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
