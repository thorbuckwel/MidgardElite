using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Race
{
    public static class Dwarves
    {
        public static void ChangeStats(ref Creature creature)
        {
            creature.Con += 2;
            creature.Wis += 2;
            creature.Cha += -2;
        }
    }
}
