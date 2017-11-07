namespace Engine.Creatures.Players.Races
{
    class Halflings
    {
        public static void ChangeStats(ref Creature creature)
        {
            creature.Dexterity += 2;
            creature.Charisma += 2;
            creature.Strength += -2;
        }
    }
}
