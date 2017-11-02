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
    public static class BuildPlayer
    {      
            
            

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

        public static int GetID()
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
