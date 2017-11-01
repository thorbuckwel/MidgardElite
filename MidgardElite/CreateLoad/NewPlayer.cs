using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using Engine.Enum;
using Engine.Model;
using Engine.ViewModels;
using Engine.WorldSave;
using Engine.WordFormat;
using Engine.Class;

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
                    validAnswer = true;
                    Console.WriteLine("What is your name?");
                    userInput = SplitWord.FirstCharToUpper(Console.ReadLine());
                    //Load.LoadGameData(userInput.ToLower());         // Go to the Load class and exacute the LoadGame method.
                }
                else if (userInput.ToLower() == "yes" || userInput.ToLower() == "y")
                {
                    validAnswer = true;
                    MakePlayer(ref userInput);                // Go to MakePLayer to create player. 
                }
                else
                {
                    Console.WriteLine("Not a valid answer.");
                }
            }
        }

        public static void MakePlayer(ref string userInput)
        {
            #region Variables
            int id = getID();
            string name = "";
            int zone = 0;
            int xCoord = 0;
            int yCoord = 0;
            string className = "";
            string raceName = "";
            string description = "";       
            int str = 0, dex = 0, agi = 0, con = 0, pInt = 0, wis = 0;
            int cha = 0, ac, gold, hp, mp, xp, maxHp = 0, maxMp = 0;
            bool isAlive;
            bool hasName = true;
            bool hasClass = false;
            bool hasRace = false;
            #endregion

            #region Name
            while (hasName == true)
            {
                Console.WriteLine("Give me your name.");
                Console.Write("> ");

                name = Console.ReadLine();
                name = SplitWord.FirstCharToUpper(name);
                hasName = CheckName(name);

                if (hasName == true)
                {
                    Console.WriteLine("Name already in use please choose another name.");
                }
                else
                {
                    Console.WriteLine("Good Name!");                    
                }
            }
            #endregion

            #region Class

            while (hasClass == false)
            {
                Console.WriteLine("Choose a Class");
                string _class = null;

                foreach (string c in Enum.GetNames(typeof(ClassEnum)))
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

                if (!Enum.IsDefined(typeof(ClassEnum), userInput))
                {
                    Console.WriteLine(userInput + " is not a valid Class");
                }
                else
                {
                    Console.WriteLine(userInput + " is a good class");
                    className = userInput;
                    hasClass = true;
                }
            }
            #endregion

            string hitDice = HitDice.GetHitDice(className);

            #region Race
            while (hasRace == false)
            {
                Console.WriteLine("Choose a Race");
                string _race = null;

                foreach (string c in Enum.GetNames(typeof(RaceEnum)))
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

                if (!Enum.IsDefined(typeof(RaceEnum), userInput))
                {
                    Console.WriteLine(userInput + " is not a valid Class");
                }
                else
                {
                    Console.WriteLine(userInput + " is a good class");
                    className = userInput;
                    hasRace = true;
                }
            }
            #endregion

            #region Description
            Console.WriteLine("Please write a description. (If you want to do this later type 'Skip'");
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "skip")
                description = userInput;
            #endregion

            #region Stats
            setStats(ref str, ref dex, ref agi, ref con, ref pInt, ref wis, ref cha, ref userInput);
            ac = 10;
            gold = 0;
            maxHp = SplitWord.SplitDice(hitDice);
            hp = maxHp;            
            mp = 0;
            xp = 0;
            #endregion

            isAlive = true;

            ObservableCollection<GameItem> inventory = new ObservableCollection<GameItem>();

            GameSession.CurrentPlayer = new Player(id, zone, name, raceName, className, description, xp, hp, maxHp, mp, maxMp, str, dex, agi, con, pInt, wis, cha, ac, isAlive,
                        gold, inventory, xCoord, yCoord);

            SaveData.SavePlayer(GameSession.CurrentPlayer);
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

        public static void setStats(ref int str, ref int dex, ref int agi, ref int con, ref int pInt, ref int wis, ref int cha, ref string userInput)
        {
            str = CustomRand.NumberBetween(1, 18);
            dex = CustomRand.NumberBetween(1, 18);
            agi = CustomRand.NumberBetween(1, 18);
            con = CustomRand.NumberBetween(1, 18);
            pInt = CustomRand.NumberBetween(1, 18);
            wis = CustomRand.NumberBetween(1, 18);
            cha = CustomRand.NumberBetween(1, 18);


            Console.WriteLine("Strength = " + str.ToString());
            Console.WriteLine("Dexterity = " + dex.ToString());
            Console.WriteLine("Constitution = " + con.ToString());
            Console.WriteLine("Intelligence = " + pInt.ToString());
            Console.WriteLine("Wisdom = " + wis.ToString());
            Console.WriteLine("Charisma = " + cha.ToString());
            Console.WriteLine("Agility = " + agi.ToString());

            Console.WriteLine("");
            Console.WriteLine("Keep these scores? >");
            userInput = Console.ReadLine();

            if (userInput.ToLower() == "no" )
                setStats(ref str, ref dex, ref agi, ref con, ref pInt, ref wis, ref cha, ref userInput);

        }

        public static int getID()
        {
            List<String> ids = new List<String>();
            int newID;
            int IDs = 0;

            using (var connection = new SqlConnection("Server = (local); Database = MidgardEliteWorld; Trusted_Connection = True;"))
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Players";
                    connection.Open();

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string dbId = reader["Id"].ToString();
                        ids.Add(dbId);
                    }
                    connection.Close();

                    int index = ids.Count - 1;
                    newID = Int32.Parse(ids[index]) + 1;
                    
                }              

                return newID;
            }
        }

        
    }
}
