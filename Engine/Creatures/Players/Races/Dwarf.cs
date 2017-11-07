namespace Engine.Creatures.Players.Races
{
    public static class Dwarf
    {
        public static void ChangeStats(ref Creature creature)
        {
            creature.Con += 2;
            creature.Wis += 2;
            creature.Cha += -2;
        }
    }
}
