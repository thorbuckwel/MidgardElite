using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Race
{
    class Gnomes
    {
        public static void ChangeStats(ref Creature creature)
        {
            creature.Con += 2;
            creature.Cha += 2;
            creature.Str += -2;
        }
    }
}
