using System;
using Engine.Model;
using Engine.ViewModels;
using Engine.Sql;
using Engine.WorldSave;


namespace MidgardElite.NewPlayer
{
    public static class NewPlayer
    {
        public static void MakePlayer(ref string userInput)
        {           
            // Get last ID in Player table and then add 1
            int id = Id.DeterminePlayerId();

            // Determine what kind of character the user wants
            NameClassRace.GetName();
            NameClassRace.AssignClass(ref userInput);
            NameClassRace.AssignRace(ref userInput);
            PlayerStats.DetermineStats(ref userInput);

            // Get a description
            string description = MakeDescription(ref userInput);

            // Get the starting value for all new players
            CommonStats.Start();

            GameSession.CurrentPlayer = new Player(id, CommonStats.zone, NameClassRace.name, NameClassRace.raceName, NameClassRace.className, description, CommonStats.xp, PlayerStats.hp, PlayerStats.maxHp,
                                                    PlayerStats.mp, PlayerStats.maxMp, PlayerStats.str, PlayerStats.dex, PlayerStats.agi, PlayerStats.con, PlayerStats.pInt, PlayerStats.wis,
                                                    PlayerStats.cha, CommonStats.ac, CommonStats.isAlive, CommonStats.gold, CommonStats.inventory, CommonStats.xCoord, CommonStats.yCoord);

            SaveData.SavePlayer(GameSession.CurrentPlayer);
        } 

        public static string MakeDescription(ref string userInput)
        {
            Console.WriteLine("Please write a description. (If you want to do this later type 'Skip'");
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "skip")
                return userInput;

            return userInput;
        }
    }
}
    

