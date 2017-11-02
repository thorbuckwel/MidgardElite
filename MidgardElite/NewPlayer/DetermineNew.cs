using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.WordFormat;
using Engine.Model;

namespace MidgardElite.NewPlayer
{
    public static class DetermineNew
    {
        public static void DetermineIfNew(ref string userInput)
        {
            bool validAnswer = false;           // This will stay false until the user's answers yes or no.

            /**
             * This loop will stay going until a valid answer is recieved from 
             * the user.
             */
            while (validAnswer == false)
            {
                Console.WriteLine("Are you a new Player?");
                Console.Write("> ");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "no" || userInput.ToLower() == "n")
                {
                    validAnswer = true;
                    Console.WriteLine("What is your name?");
                    userInput = SplitWord.FirstCharToUpper(Console.ReadLine());
                    //Load.LoadGameData(userInput.ToLower());         // Go to the Load class and exacute the LoadGame method.
                }
                else if (userInput.ToLower() == "yes" || userInput.ToLower() == "y")
                {
                    validAnswer = true;
                    NewPlayer.MakePlayer(ref userInput);                // Go to MakePLayer to create player. 
                }
                else
                {
                    Console.WriteLine("Not a valid answer.");
                }
            }
        }
    }
}
