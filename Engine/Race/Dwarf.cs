using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Model;

namespace Engine.Race
{
    public static class Dwarf
    {
        public static void ChangeStats(ref Creature creature)
        {
            creature.Con += 2;
            creature.Wis += 2;
            creature.Cha += -2;
        }
    }
}
