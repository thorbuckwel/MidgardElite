namespace Engine.Creatures.Players.Races
{
    public static class Dwarf
    {
        public static void ChangeStats(ref Creature creature)
        {
            creature.Constitution += 2;
            creature.Wisdom += 2;
            creature.Charisma += -2;
        }
    }
}
