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
            switch (pClass)
            {
                case "Sorcerer":
                case "Wizard":
                    return "1D6";
                case "Bard":
                case "Druid":
                case "Monk":
                case "Rogue":
                    return "1D8";
                case "Fighter":
                case "Paladin":
                case "Ranger":
                    return "1D10";
                case "Barbarian":
                    return "1D12";
            } 
            return null;
        }
    }
}
