using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Model;

namespace Engine.Race
{
    class Halflings
    {
        public static void ChangeStats(ref Creature creature)
        {
            creature.Dex += 2;
            creature.Cha += 2;
            creature.Str += -2;
        }
    }
}
