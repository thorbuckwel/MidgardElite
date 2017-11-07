namespace Engine.Creatures.Players.Races
{
    public static class Elf
    {
        public static void ChangeStats(ref Creature creature)
        {
            creature.Dexterity += 2;
            creature.Intelligence += 2;
            creature.Constitution += -2;
        }
    }
}
