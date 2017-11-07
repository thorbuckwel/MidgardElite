using Engine.Creatures.Players.Classes;
using Engine.Utility;
using Engine.Utility.Formating;

namespace Engine.Creatures.Players
{
    public class PlayerStats
    {
        public int str = 0;
        public int dex = 0;
        public int agi = 0;
        public int con = 0;
        public int pInt = 0;
        public int wis = 0;
        public int cha = 0;
        public int hp = 0;
        public int maxHp = 0;
        public int mp = 0;
        public int maxMp = 0;
        public string hitDice = "";

        public string Race { get; set; }
        public string Class { get; set; }

        public void DetermineStats()
        {
            str = Random.NumberBetween(1, 18);
            dex = Random.NumberBetween(1, 18);
            agi = Random.NumberBetween(1, 18);
            con = Random.NumberBetween(1, 18);
            pInt = Random.NumberBetween(1, 18);
            wis = Random.NumberBetween(1, 18);
            cha = Random.NumberBetween(1, 18);
        }

        public void DetermineOtherStats(string className)
        {
            hitDice = HitDice.GetHitDice(className);
            maxHp = SplitWord.SplitDice(hitDice);
            hp = maxHp;
            maxMp = pInt * 10;
            mp = maxMp;
        }
    }
}