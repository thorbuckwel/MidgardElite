using Engine.Class;
using Engine.WordFormat;

namespace Engine.Model
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

        public void DetermineStats()
        {
            str = CustomRand.NumberBetween(1, 18);
            dex = CustomRand.NumberBetween(1, 18);
            agi = CustomRand.NumberBetween(1, 18);
            con = CustomRand.NumberBetween(1, 18);
            pInt = CustomRand.NumberBetween(1, 18);
            wis = CustomRand.NumberBetween(1, 18);
            cha = CustomRand.NumberBetween(1, 18);
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