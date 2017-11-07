using Engine.Items;
using Engine.Utility.SQL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Engine.Creatures.Players
{
    public static class PlayerFactory
    {
        public static Player Create(CreatureData creatureData, PlayerStats playerStats)
        {
            // Get last ID in Player table and then add 1
            int id = Id.DeterminePlayerId();

            return new Player(id, creatureData, playerStats);
        }

        /// <summary>
        /// Querries the database to see if the provided Name is available for use.
        /// </summary>
        /// <param name="wantedName"></param>
        /// <returns></returns>
        public static Boolean IsNameAvailable(string wantedName)
        {
            List<String> namesAlreadyInUse = new List<String>();

            using (var connection = new SqlConnection(SqlCommands.ConnectionString))
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = SqlCommands.SelectAllPlayer;
                    connection.Open();

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string dbName = reader["Name"].ToString();
                        namesAlreadyInUse.Add(dbName);
                    }
                    connection.Close();
                }

                return namesAlreadyInUse.Any(n => n.Equals(wantedName));
            }
        }

        public static Player Load(string playerName)
        {
            Player existingPlayer = null;
            // retreive database names from Players table
            string connetionString = SqlCommands.ConnectionString;

            using (var connection = new SqlConnection(connetionString))
            {
                using (var command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = SqlCommands.selectSinglePlayer;
                    command.Parameters.AddWithValue("@Name", playerName.ToLower());

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
                        System.Collections.ObjectModel.ObservableCollection<GameItem> inventory = null;      //reader["Inventory"].ToString();
                        int yCoord = (int.Parse(reader["YCoord"].ToString()));
                        int xCoord = (int.Parse(reader["XCoord"].ToString()));
                        bool isAlive = true;

                        #endregion
                        existingPlayer = new Player(id, zone, name, raceName, className, description, xp, hp, maxHp, mp, maxMp, str, dex, agi,
                                                                con, pInt, wis, cha, ac, isAlive, gold, inventory, xCoord, yCoord);
                    }

                }
                connection.Close();

            }

            if (existingPlayer == null)
                throw new NullReferenceException(string.Format("A player with [{0}] could not be found in the database.", playerName));

            return existingPlayer;
        }
    }
}
