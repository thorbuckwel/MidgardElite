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
using Engine.Sql;
using Engine.ViewModels;

namespace MidgardElite.CreateLoad
{
    public static class BuildPlayer
    {
        public static void BuildFromDatabase()
        {
            Console.WriteLine("What is your charater's name?");
            string userInput = Console.ReadLine();

            // retreive database names from Players table
            string connetionString = null;
            connetionString = SqlCommands.ConnectionString;

            using (var connection = new SqlConnection(connetionString))
            {
                using (var command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = SqlCommands.selectSinglePlayer;
                    command.Parameters.AddWithValue("@Name", userInput.ToLower());

                    #region Reader
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = (int.Parse(reader["Id"].ToString()));
                        string name = reader["Name"].ToString();
                        int zone = (int.Parse(reader["Zone"].ToString()));
                        string description = reader["Description"].ToString();
                        int xp = (int.Parse(reader["Xp"].ToString()));
                        int hp = (int.Parse(reader["Hp"].ToString()));
                        int maxHp = (int.Parse(reader["MaxHp"].ToString()));
                        int mp = (int.Parse(reader["MaxMp"].ToString()));
                        int maxMp = (int.Parse(reader["MaxMp"].ToString()));
                        int str = (int.Parse(reader["Str"].ToString()));
                        int dex = (int.Parse(reader["Dex"].ToString()));
                        int agi = (int.Parse(reader["Agi"].ToString()));
                        int con = (int.Parse(reader["Con"].ToString()));
                        int pInt = (int.Parse(reader["Int"].ToString()));
                        int wis = (int.Parse(reader["Wis"].ToString()));
                        int cha = (int.Parse(reader["Cha"].ToString()));
                        int ac = (int.Parse(reader["Ac"].ToString()));
                        int gold = (int.Parse(reader["Gold"].ToString()));
                        string raceName = reader["Race"].ToString();
                        string className = reader["Class"].ToString();
                        ObservableCollection<GameItem> inventory = null;      //reader["Inventory"].ToString();
                        int yCoord = (int.Parse(reader["YCoord"].ToString()));
                        int xCoord = (int.Parse(reader["XCoord"].ToString()));
                        bool isAlive = true;

                        #endregion
                        GameSession.CurrentPlayer = new Player(id, zone, name, raceName,  className, description, xp, hp, maxHp, mp, maxMp, str, dex, agi,
                                                                con, pInt, wis, cha, ac, isAlive, gold, inventory, xCoord, yCoord);
                    }

                }
                connection.Close();

            }
        }

        //public ObservableCollection<GameItem> MakeInventory(string inventoryString)
        //{
        //    char delim = ',';
        //    List<string> temp = inventoryString.Split(delim).ToList();
        //    ObservableCollection<GameItem> inventory;

        //    for (int i = 0; i < temp.Count(); i++)
        //    {
        //        inventory[i] = temp[i];
        //    }
        //}
    }
}
