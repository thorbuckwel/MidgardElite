namespace Engine.Creatures.Players.Classes
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

        public static string GetHitDice(PlayerClass playerClass)
        {
            switch (playerClass)
            {
                case PlayerClass.Sorcerer:
                case PlayerClass.Wizard:
                    return "1D6";
                case PlayerClass.Bard:
                case PlayerClass.Druid:
                case PlayerClass.Monk:
                case PlayerClass.Rogue:
                    return "1D8";
                case PlayerClass.Fighter:
                case PlayerClass.Paladian:
                case PlayerClass.Ranger:
                    return "1D10";
                case PlayerClass.Barbarian:
                    return "1D12";
                default:
                    throw new System.Exception(string.Format("Unsupported PlayerClass value: [{0}]", playerClass.ToString()));
            }
        }
    }
}
