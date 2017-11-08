namespace Engine.Creatures.Players.Races
{
    class Gnome
    {
        public static void ChangeStats(ref Creature creature)
        {
            creature.Constitution += 2;
            creature.Charisma += 2;
            creature.Strength += -2;
        }
    }
}
