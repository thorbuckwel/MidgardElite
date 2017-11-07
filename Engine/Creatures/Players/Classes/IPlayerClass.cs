namespace Engine.Creatures.Players.Classes
{
    internal interface IPlayerClass
    {
        int GetClassBaseAttackBonus(int playerLevel);

        int GetClassFortitudeModifier(int playerLevel);

        int GetClassReflexModifier(int playerLevel);

        int GetClassWillModifier(int playerLevel);
    }
}
