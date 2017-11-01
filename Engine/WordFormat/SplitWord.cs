using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Model;

namespace Engine.WordFormat
{
    public static class SplitWord
    {
        public static int SplitDice(string dice)
        {
            int numDice = 0;
            int numSides = 0;
            int num = 0;
            int result = 0;
            char delim = 'D';
            string[] tokens = dice.Split(delim);

            numDice = Int32.Parse(tokens[0]);
            numSides = Int32.Parse(tokens[1]);

            for (int d = 0; d < numDice; d++)
            {
                num = CustomRand.NumberBetween(1, numSides);
                result += num;
            }


            return result;
        }

        public static string FirstCharToUpper(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("ARGH!");
            return input.First().ToString().ToUpper() + input.Substring(1);
        }
    }
}
