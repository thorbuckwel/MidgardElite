namespace Engine.Creatures
{
    public static class Modifers
    {
        public static void DetermineCombatMods(ref Creature creature)
        {
            creature.Fortitude = creature.Con;
            creature.Reflex = creature.Dex;
            creature.Will = creature.Wis;
        }

        public static void DetermineAC(ref Creature creature)
        {

        }

        public static int DetermineStatMod(int stat)
        {
            int mod = 0;

            if (stat == 1)
                mod = -5;
            else if (stat < 1 && stat <= 3)
                mod = -4;
            else if (stat < 3 && stat <= 5)
                mod = -3;
            else if (stat < 5 && stat <= 7)
                mod = -2;
            else if (stat < 7 && stat <= 9)
                mod = -1;
            else if (stat < 9 && stat <= 11)
                mod = 0;
            else if (stat < 11 && stat <= 13)
                mod = 1;
            else if (stat < 13 && stat <= 15)
                mod = 2;
            else if (stat < 15 && stat <= 17)
                mod = 3;
            else if (stat < 17 && stat <= 19)
                mod = 4;
            else if (stat < 19 && stat <= 21)
                mod = 5;
            else if (stat < 21 && stat <= 23)
                mod = 6;
            else if (stat < 23 && stat <= 25)
                mod = 7;
            else if (stat < 25 && stat <= 27)
                mod = 8;
            else if (stat < 27 && stat <= 29)
                mod = 9;
            else if (stat < 29 && stat <= 31)
                mod = 10;
            else if (stat < 31 && stat <= 33)
                mod = 11;
            else if (stat < 33 && stat <= 35)
                mod = 12;
            else if (stat < 35 && stat <= 37)
                mod = 13;
            else if (stat < 37 && stat <= 39)
                mod = 14;
            else if (stat < 39 && stat <= 41)
                mod = 15;
            else if (stat < 41 && stat <= 43)
                mod = 16;
            else if (stat < 43 && stat <= 45)
                mod = 17;

            return mod;
        }
    }
}
