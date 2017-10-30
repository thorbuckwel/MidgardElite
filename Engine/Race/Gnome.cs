using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Model;

namespace Engine.Race
{
    class Gnome
    {
        public static void ChangeStats(ref Creature creature)
        {
            creature.Con += 2;
            creature.Cha += 2;
            creature.Str += -2;
        }
    }
}
