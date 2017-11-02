using System;
using System.Collections.Generic;
using Engine.Sql;
using System.Data.SqlClient;
using Engine.WordFormat;
using System.Linq;
using Engine.Enum;
using System.Text;
using System.Threading.Tasks;

namespace MidgardElite.NewPlayer
{
    public static class NameClassRace
    {
        public static string name = "";
        public static string className = "";
        public static string raceName = "";

        public static void GetName()
        {            
            bool hasName = true;
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
        }

        public static Boolean CheckName(string name)
        {
            bool has = false;
            List<String> names = new List<String>();
            string connetionString = null;
            connetionString = SqlCommands.ConnectionString;

            using (var connection = new SqlConnection(connetionString))
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = SqlCommands.SelectAllPlayer;
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

        public static void AssignClass(ref string userInput)
        {
            bool hasClass = false;

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

                if (Enum.IsDefined(typeof(ClassEnum), userInput))
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
                    hasRace = true;
                    raceName = userInput;
                    
                }
            }           
        }
    }
}
