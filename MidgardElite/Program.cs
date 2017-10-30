using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;
using Engine.Model;
using Engine.CreateLoad;

namespace MidgardElite
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int x = 0;
            Console.ForegroundColor = ConsoleColor.Red;       // The text will be White.
            
            #region While loop
            // Infinite loop, until the user types "exit"

            
            //while (true)
            //{
            //    // Display a prompt, so the user knows to type something
            //    //Console.Write(Player._player.CurrentHitPoints + "/" + Player._player.MaxHitPoints + " Hp" + " >");
            //    if (x == 0)
            //    {
            //        ListBuilder.BuildLocationList();
            //        x = 1;
            //    }

            //    Console.Write("Test > ");
            //    // Wait for the user to type something, and press the <Enter> key
            //    string userInput = Console.ReadLine();

            //    // If they typed a blank line, loop back and wait for input again
            //    if (string.IsNullOrWhiteSpace(userInput))
            //    {
            //        continue;
            //    }

            //    // Convert to lower-case, to make comparisons easier
            //    string cleanedInput = userInput.ToLower();

            //    // Save the current game data, and break out of the "while(true)" loop
            //    if (cleanedInput == "exit")
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("Saving character, will close when finished!");
            //        //SaveData.SaveGameData(Player._player);
            //        break;
            //    }

            //    // If the user typed something, try to determine what to do
            //    //ParseInput(cleanedInput);
            //}
            #endregion
        }

        public static void Build()
        {
            ListBuilder.BuildLocationList();
        }
    }
}
