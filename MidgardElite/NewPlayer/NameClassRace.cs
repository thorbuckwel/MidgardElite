using System;
using System.Linq;
using Engine.Creatures.Players;
using Engine.Utility.Formating;

namespace MidgardElite.NewPlayer
{
    public static class NameClassRace
    {
        public static string name = "";
        public static string className = "";
        public static string raceName = "";

        public static void GetName()
        {            
            bool nameAlreadyTaken = true;
            while (nameAlreadyTaken == true)
            {
                Console.WriteLine("Give me your name.");
                Console.Write("> ");

                name = Console.ReadLine();
                name = SplitWord.FirstCharToUpper(name);
                nameAlreadyTaken = PlayerFactory.IsNameAvailable(name);

                if (nameAlreadyTaken == true)
                {
                    Console.WriteLine("Name already in use please choose another name.");
                }
                else
                {
                    Console.WriteLine("Good Name!");
                }
            }            
        }

        

        public static void AssignClass(ref string userInput)
        {
            bool hasClass = false;

            while (hasClass == false)
            {
                Console.WriteLine("Choose a Class");
                string _class = null;

                foreach (string c in Enum.GetNames(typeof(PlayerClass)))
                {
                    if (_class == null)
                        _class = c;
                    else
                        _class += ", " + c;
                }
                _class.ToArray();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("<" + _class + ">");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Class -  ");
                userInput = Console.ReadLine();

                if (!Enum.IsDefined(typeof(PlayerClass), userInput))
                {
                    Console.WriteLine(userInput + " is not a valid Class");
                }
                else
                {
                    Console.WriteLine(userInput + " is a good class");
                    hasClass = true;
                    className = userInput;
                }                
            }
        }

        public static void AssignRace(ref string userInput)
        {
            bool hasRace = false;

            while (hasRace == false)
            {
                Console.WriteLine("Choose a Race");
                string _race = null;

                foreach (string c in Enum.GetNames(typeof(PlayerRace)))
                {
                    if (_race == null)
                        _race = c;
                    else
                        _race += ", " + c;
                }

                _race.ToArray();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("<" + _race + ">");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Race -  ");
                userInput = Console.ReadLine();

                if (!Enum.IsDefined(typeof(PlayerRace), userInput))
                {
                    Console.WriteLine(userInput + " is not a valid Class");
                }
                else
                {
                    Console.WriteLine(userInput + " is a good class");
                    hasRace = true;
                    raceName = userInput;
                    
                }
            }           
        }
    }
}
