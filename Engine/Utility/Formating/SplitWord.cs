﻿using System;
using System.Linq;

namespace Engine.Utility.Formating
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
                num = Random.NumberBetween(1, numSides);
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
