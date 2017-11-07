namespace Engine.Creatures.Players.Races
{
    public static class Elf
    {
        public static void ChangeStats(ref Creature creature)
        {
            creature.Dex += 2;
            creature.Int += 2;
            creature.Con += -2;
        }
    }
}
