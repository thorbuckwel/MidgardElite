using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Model;

namespace Engine.Race
{
    public static class Elf
    {
        public static void ChangeStats(ref Creature creature)
        {
            creature.Dex += 2;
            creature.Int += 2;
            creature.Con += -2;
        }
    }
}
