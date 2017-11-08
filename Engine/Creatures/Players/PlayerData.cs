using Engine.Utility.Formating;

namespace Engine.Creatures.Players
{
    public class PlayerData : CreatureData
    {
        public string HitDice = "";

        public string Race { get; set; }
        public string Class { get; set; }

        public void DetermineOtherStats(string className)
        {
            HitDice = Classes.HitDice.GetHitDice(className);
            MaxHitPoints = SplitWord.SplitDice(HitDice);
            HitPoints = MaxHitPoints;
            MaxMagicPoints = Intelligence * 10;
            MagicPoints = MaxMagicPoints;
        }
    }
}