using System;
using Engine.Session;
using Engine.Utility.SaveLoad;
using Engine.Creatures.Players;
using Engine.Creatures;

namespace MidgardElite.NewPlayer
{
    public static class NewPlayer
    {
        public static void MakePlayer(ref string userInput)
        {
            PlayerData newPlayerInformation = new PlayerData();

            // Determine what kind of character the user wants
            NameClassRace.GetName();
            NameClassRace.AssignClass(ref userInput);
            NameClassRace.AssignRace(ref userInput);

            do
            {
                newPlayerInformation.RollValuesForStats();
                DisplayResults(newPlayerInformation);
                userInput = Console.ReadLine();
            } while (userInput.ToLower() == "n");


            newPlayerInformation.DetermineOtherStats(NameClassRace.className);

            // Get a description
            newPlayerInformation.Description = MakeDescription(ref userInput);

            // Assign Name, Class and Race
            newPlayerInformation.Name = NameClassRace.name;
            
            newPlayerInformation.Race = NameClassRace.raceName;
            newPlayerInformation.Class = NameClassRace.className;

            GameSession.CurrentPlayer = PlayerFactory.Create(newPlayerInformation);
            
            SaveData.SavePlayer(GameSession.CurrentPlayer);
        }

        public static void DisplayResults(PlayerData newPlayerInformation)
        {
            Console.WriteLine("Your stats will be:");
            Console.WriteLine("Strength : " + newPlayerInformation.Strength);
            Console.WriteLine("Dexterity : " + newPlayerInformation.Dexterity);
            Console.WriteLine("Agility : " + newPlayerInformation.Agility);
            Console.WriteLine("Constitution : " + newPlayerInformation.Constitution);
            Console.WriteLine("Intelligence : " + newPlayerInformation.Intelligence);
            Console.WriteLine("Wisdom : " + newPlayerInformation.Wisdom);
            Console.WriteLine("Charisma : " + newPlayerInformation.Charisma);
            Console.WriteLine("Keep these scores? Y/N:");
        }

        public static string MakeDescription(ref string userInput)
        {
            Console.WriteLine("Please write a description. (If you want to do this later type 'Skip')");
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "skip")
                return userInput;

            return userInput;
        }
    }
}
