using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Model;
using Engine.Class;
using Engine.WordFormat;

namespace MidgardElite.NewPlayer
{
    public class PlayerStats
    {
        public static int str = 0;
        public static int dex = 0;
        public static int agi = 0;
        public static int con = 0;
        public static int pInt = 0;
        public static int wis = 0;
        public static int cha = 0;
        public static int hp = 0;
        public static int maxHp = 0;
        public static int mp = 0;
        public static int maxMp = 0;
        public static string hitDice = HitDice.GetHitDice(NameClassRace.className);

        public static void DetermineStats(ref string userInput)
        {
            str = CustomRand.NumberBetween(1, 18);
            dex = CustomRand.NumberBetween(1, 18);
            agi = CustomRand.NumberBetween(1, 18);
            con = CustomRand.NumberBetween(1, 18);
            pInt = CustomRand.NumberBetween(1, 18);
            wis = CustomRand.NumberBetween(1, 18);
            cha = CustomRand.NumberBetween(1, 18);

            DisplayResults(ref userInput);

        }

        public static void DisplayResults(ref string userInput)
        {
            Console.WriteLine("Your stats will be:");
            Console.WriteLine("Strength : " + str);
            Console.WriteLine("Dexterity : " + dex);
            Console.WriteLine("Constitution : " + con);
            Console.WriteLine("Intelligence : " + pInt);
            Console.WriteLine("Wisdom : " + wis);
            Console.WriteLine("Charisma : " + cha);
            Console.WriteLine("Keep these scores? Y/N:");
            userInput = Console.ReadLine();

            if (userInput.ToLower() == "n")
                DetermineStats(ref userInput);

            DetermineOtherStats();
        }

        public static void DetermineOtherStats()
        {
            maxHp = SplitWord.SplitDice(hitDice);
            hp = maxHp;
            maxMp = pInt * 10;
            mp = maxMp;
        }

        
    }
}
