using System;
using MidgardElite.Opening;
using MidgardElite.Commands;
using MidgardElite.Location;
using Engine.Session;
using Engine.Utility;
using Engine.Utility.SaveLoad;

namespace MidgardElite
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string userInput = "";
            Console.ForegroundColor = ConsoleColor.White;       // The text will be White.
            ListBuilder.BuildLocationList();            
            WelcomeScreen.Welcome(ref userInput);
            GameSession _gameSession = new GameSession();
            CurrentLocationClass.DisplayCurrentLocation();

            #region While loop
            //Infinite loop, until the user types "exit"

            while (true)
            {
                

                // Display a prompt, so the user knows to type something
                Console.Write(GameSession.CurrentPlayer.Hp + "/" + GameSession.CurrentPlayer.MaxHp + " Hp" + " >");
                
                // Wait for the user to type something, and press the <Enter> key
                userInput = Console.ReadLine();

                // If they typed a blank line, loop back and wait for input again
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    continue;
                }

                // Convert to lower-case, to make comparisons easier
                string cleanedInput = userInput.ToLower();

                // Now that the userInput as been saved and converted we need to do something with it.
                Commands.Command.CommandCase(userInput, GameSession.CurrentPlayer, _gameSession);

                // Save the current game data, and break out of the "while(true)" loop
                if (cleanedInput == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Saving character, will close when finished!");
                    SaveData.UpdatePlayer(GameSession.CurrentPlayer);
                    break;
                }

                // If the user typed something, try to determine what to do
                //ParseInput(cleanedInput, _gameSession);
            }
            #endregion
        }
                
        private void ParseInput(string input, GameSession _gameSession)
        {
            // Call the command class to figure out what to do
            Command.CommandCase(input, GameSession.currentPlayer, _gameSession);
        }

        //public event PropertyChangedEventHandler PropertyChanged;

        //protected virtual void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
    }
}

