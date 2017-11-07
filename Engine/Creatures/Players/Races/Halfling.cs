namespace Engine.Creatures.Players.Races
{
    class Halflings
    {
        public static void ChangeStats(ref Creature creature)
        {
            creature.Dex += 2;
            creature.Cha += 2;
            creature.Str += -2;
        }
    }
}
