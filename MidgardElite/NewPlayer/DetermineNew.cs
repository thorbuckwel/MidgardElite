using System;
using Engine.Session;
using Engine.Creatures.Players;

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

                    // Build Player Class
                    Console.WriteLine("What is your charater's name?");
                    userInput = Console.ReadLine();
                    GameSession.CurrentPlayer = PlayerFactory.Load(playerName: userInput);
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
