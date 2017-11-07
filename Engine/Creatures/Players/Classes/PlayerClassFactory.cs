namespace Engine.Creatures.Players.Classes
{
    internal static class PlayerClassFactory
    {
        internal static IPlayerClass GetPlayerClass(string Class)
        {
            IPlayerClass playerClass = null;
            if (Class == "Barbarian")
            {
                playerClass = new Barbarian() as IPlayerClass;
            }
            else if (Class == "Bard")
            {
                playerClass = new Bard() as IPlayerClass;
            }
            else if (Class == "Cleric")
            {
                playerClass = new Cleric() as IPlayerClass;
            }
            else if (Class == "Druid")
            {
                playerClass = new Druid() as IPlayerClass;
            }
            else if (Class == "Fighter")
            {
                playerClass = new Fighter() as IPlayerClass;
            }
            else if (Class == "Monk")
            {
                playerClass = new Monk() as IPlayerClass;
            }
            else if (Class == "Paladin")
            {
                playerClass = new Paladin() as IPlayerClass;
            }
            else if (Class == "Ranger")
            {
                playerClass = new Ranger() as IPlayerClass;
            }
            else if (Class == "Rogue")
            {
                playerClass = new Rogue() as IPlayerClass;
            }
            else if (Class == "Sorcerer")
            {
                playerClass = new Sorcerer() as IPlayerClass;
            }
            else if (Class == "Wizard")
            {
                playerClass = new Wizard() as IPlayerClass;
            }

            return playerClass;
        }
    }
}
