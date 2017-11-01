using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Class
{
    public static class HitDice
    {
        public static string GetHitDice(string pClass)
        {
            if (pClass == "Barbarian")
                return "1D12";
            else if (pClass == "Bard")
                return "1D8";
            else if (pClass == "Cleric")
                return "1D8";
            else if (pClass == "Druid")
                return "1D8";
            else if (pClass == "Fighter")
                return "1D10";
            else if (pClass == "Monk")
                return "1D8";
            else if (pClass == "Paladin")
                return "1D10";
            else if (pClass == "Ranger")
                return "1D10";
            else if (pClass == "Rogue")
                return "1D8";
            else if (pClass == "Sorcerer")
                return "1D6";
            else if (pClass == "Wizard")
                return "1D6";

            return null;

        }
    }
}
