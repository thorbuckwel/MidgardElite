using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MidgardElite.Words;
using System.Data.SqlClient;

namespace MidgardElite.CreateLoad
{
    public static class NewPlayer
    {
        public static void CreatePlayer()
        {
            string userInput;                   // To hold the user's input.
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
                    //validAnswer = true;
                    //Console.WriteLine("What is your name?");
                    //userInput = CapWord.FirstCharToUpper(Console.ReadLine());
                    //Load.LoadGameData(userInput.ToLower());         // Go to the Load class and exacute the LoadGame method.
                }
                else if (userInput.ToLower() == "yes" || userInput.ToLower() == "y")
                {
                    validAnswer = true;
                    MakePlayer();                // Go to CreatePlayer and exacute the CreatePlayerInst method. 
                }
                else
                {
                    Console.WriteLine("Not a valid answer.");
                }
            }
        }

        public static void MakePlayer()
        {
            string name;
            int zone = 0;
            string className;
            string raceName;
            string Description;
            int str, dex, agi, con, pInt, wis;
            int cha, ac, gold, hp, mp, xp;
            bool isAlive;
            bool has = true;

            while (has == true)
            {
                Console.WriteLine("Give me your name.");
                Console.Write("> ");
                name = Console.ReadLine();
                name = name.ToLower();
                has = CheckName(name);

                if (has == true)
                {
                    Console.WriteLine("Name already in use please choose another name.");
                }
                else
                {
                    Console.WriteLine("Good Name!");
                    // TODO: Another Method to get Race.
                }
            }


            //while (validClass == false)
            //{
            //    Console.WriteLine("What class would you like to be?");
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.Write("Warrior, Mage, Thief > ");
            //    className = Console.ReadLine().ToLower();
            //    Console.ForegroundColor = ConsoleColor.White;

            //    if (className == "warrior")
            //    {
            //        gold = 100;
            //        validClass = true;
            //    }
            //    else if (className == "mage")
            //    {
            //        gold = 150;
            //        validClass = true;
            //    }
            //    else if (className == "thief")
            //    {
            //        gold = 200;
            //        validClass = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not a valid class");
            //    }
            //}

            //while (validRace == false)
            //{
            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.WriteLine("What race would you like?");
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.Write("Human, Elf, Dwarf > ");
            //    raceName = Console.ReadLine().ToLower();

            //    if (raceName == "human")
            //    {
            //        validRace = true;
            //        hp = 100;
            //    }
            //    else if (raceName == "elf")
            //    {
            //        validRace = true;
            //        hp = 80;
            //    }
            //    else if (raceName == "dwarf")
            //    {
            //        validRace = true;
            //        hp = 120;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not a Valid entry.");
            //    }
            //}            

            //Console.ForegroundColor = ConsoleColor.White;
            //Player._player = new Player(name, CapWord.FirstCharToUpper(className), CapWord.FirstCharToUpper(raceName), gold, hp, hp, World.WeaponByID(103), false, true, faction, alignment);
            //Console.WriteLine("Creating character data, please wait!");
            //SaveData.SaveGameData(Player._player);

        }

        public static Boolean CheckName(string name)
        {
            bool has = false;
            List<String> names = new List<String>();

            using (var connection = new SqlConnection("Server = (local); Database = MidgardEliteWorld; Trusted_Connection = True;"))
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Players";
                    connection.Open();

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string dbName = reader["Name"].ToString();
                        names.Add(dbName);
                    }
                    connection.Close();
                }

                foreach (string n in names)
                {
                    if (n == name)
                        has = true;
                    else
                        has = false;
                }

                return has;
            }
        }
    }
}
