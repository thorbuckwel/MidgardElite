namespace Engine.Creatures.Players.Races
{
    class Gnome
    {
        public static void ChangeStats(ref Creature creature)
        {
            creature.Con += 2;
            creature.Cha += 2;
            creature.Str += -2;
        }
    }
}
