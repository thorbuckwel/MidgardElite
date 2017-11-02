﻿using System;
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
            PlayerStats newPlayerInformation = new PlayerStats();

            // Get last ID in Player table and then add 1
            int id = Id.DeterminePlayerId();

            // Determine what kind of character the user wants
            NameClassRace.GetName();
            NameClassRace.AssignClass(ref userInput);
            NameClassRace.AssignRace(ref userInput);

            do
            {
                newPlayerInformation.DetermineStats();
                DisplayResults(newPlayerInformation);
                userInput = Console.ReadLine();
            } while (userInput.ToLower() == "n");


            newPlayerInformation.DetermineOtherStats(NameClassRace.className);

            // Get a description
            string description = MakeDescription(ref userInput);

            // Get the starting value for all new players
            CommonStats.Start();

            GameSession.CurrentPlayer = new Player(id, CommonStats.zone, NameClassRace.name, NameClassRace.raceName, NameClassRace.className, description, CommonStats.xp, newPlayerInformation,
                CommonStats.ac, CommonStats.isAlive, CommonStats.gold, CommonStats.inventory, CommonStats.xCoord, CommonStats.yCoord);

            SaveData.SavePlayer(GameSession.CurrentPlayer);
        }

        public static void DisplayResults(PlayerStats newPlayerInformation)
        {
            Console.WriteLine("Your stats will be:");
            Console.WriteLine("Strength : " + newPlayerInformation.str);
            Console.WriteLine("Dexterity : " + newPlayerInformation.dex);
            Console.WriteLine("Constitution : " + newPlayerInformation.con);
            Console.WriteLine("Intelligence : " + newPlayerInformation.pInt);
            Console.WriteLine("Wisdom : " + newPlayerInformation.wis);
            Console.WriteLine("Charisma : " + newPlayerInformation.cha);
            Console.WriteLine("Keep these scores? Y/N:");
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
