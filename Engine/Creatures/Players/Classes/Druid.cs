namespace Engine.Creatures.Players.Classes
{
    public class Druid : IPlayerClass
    {
        public int GetClassBaseAttackBonus(int playerLevel)
        {
            if (playerLevel == 1)
                return 0;
            else if (playerLevel == 2)
                return 1;
            else if (playerLevel == 3)
                return 2;
            else if (playerLevel > 3 && playerLevel <= 5)
                return 3;
            else if (playerLevel == 6)
                return 4;
            else if (playerLevel == 7)
                return 5;
            else if (playerLevel > 7 && playerLevel <= 9)
                return 6;
            else if (playerLevel == 10)
                return 7;
            else if (playerLevel == 11)
                return 8;
            else if (playerLevel > 11 && playerLevel <= 13)
                return 9;
            else if (playerLevel == 14)
                return 10;
            else if (playerLevel == 15)
                return 11;
            else if (playerLevel > 15 && playerLevel <= 17)
                return 12;
            else if (playerLevel == 18)
                return 13;
            else if (playerLevel == 19)
                return 14;
            else if (playerLevel == 20)
                return 15;

            return 0;
        }

        public int GetClassFortitudeModifier(int playerLevel)
        {
            if (playerLevel == 1)
                return 2;
            else if (playerLevel < 1 && playerLevel <= 3)
                return 3;
            else if (playerLevel > 3 && playerLevel <= 5)
                return 4;
            else if (playerLevel > 5 && playerLevel <= 7)
                return 5;
            else if (playerLevel > 7 && playerLevel <= 9)
                return 6;
            else if (playerLevel > 9 && playerLevel <= 11)
                return 7;
            else if (playerLevel > 11 && playerLevel <= 13)
                return 8;
            else if (playerLevel > 13 && playerLevel <= 15)
                return 9;
            else if (playerLevel > 15 && playerLevel <= 17)
                return 10;
            else if (playerLevel > 17 && playerLevel <= 19)
                return 11;
            else if (playerLevel == 20)
                return 12;

            return 0;
        }

        public int GetClassReflexModifier(int playerLevel)
        {
            if (playerLevel >= 1 && playerLevel <= 2)
                return 0;
            else if (playerLevel > 2 && playerLevel <= 5)
                return 1;
            else if (playerLevel > 5 && playerLevel <= 8)
                return 2;
            else if (playerLevel > 8 && playerLevel <= 11)
                return 3;
            else if (playerLevel > 11 && playerLevel <= 14)
                return 4;
            else if (playerLevel > 14 && playerLevel <= 17)
                return 5;
            else if (playerLevel > 17 && playerLevel <= 20)
                return 6;

            return 0;
        }

        public int GetClassWillModifier(int playerLevel)
        {
            if (playerLevel == 1)
                return 2;
            else if (playerLevel < 1 && playerLevel <= 3)
                return 3;
            else if (playerLevel > 3 && playerLevel <= 5)
                return 4;
            else if (playerLevel > 5 && playerLevel <= 7)
                return 5;
            else if (playerLevel > 7 && playerLevel <= 9)
                return 6;
            else if (playerLevel > 9 && playerLevel <= 11)
                return 7;
            else if (playerLevel > 11 && playerLevel <= 13)
                return 8;
            else if (playerLevel > 13 && playerLevel <= 15)
                return 9;
            else if (playerLevel > 15 && playerLevel <= 17)
                return 10;
            else if (playerLevel > 17 && playerLevel <= 19)
                return 11;
            else if (playerLevel == 20)
                return 12;

            return 0;
        }
    }
}
