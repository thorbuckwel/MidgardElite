using Engine.Utility.SQL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Engine.Creatures.Players
{
    public static class PlayerFactory
    {
        public static Player Create(PlayerData playerStats)
        {
            // Get last ID in Player table and then add 1
            int id = Id.DeterminePlayerId();

            return new Player(id, playerStats);
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

                        PlayerData existingPlayerData = new PlayerData()
                        {
                            //Player
                            Name = reader["Name"].ToString(),
                            Description = reader["Description"].ToString(),

                            Race = reader["Race"].ToString(),
                            Class = reader["Class"].ToString(),

                            //Location
                            Zone = int.Parse(reader["Zone"].ToString()),
                            xCoord = int.Parse(reader["XCoord"].ToString()),
                            yCoord = int.Parse(reader["YCoord"].ToString()),

                            //General
                            ExperiencePoints = int.Parse(reader["Xp"].ToString()),
                            Gold = int.Parse(reader["Gold"].ToString()),

                            IsAlive = true,

                            //Stats
                            HitPoints = int.Parse(reader["Hp"].ToString()),
                            MaxHitPoints = int.Parse(reader["MaxHp"].ToString()),

                            MagicPoints = int.Parse(reader["Mp"].ToString()),
                            MaxMagicPoints = int.Parse(reader["MaxMp"].ToString()),

                            Strength = int.Parse(reader["Str"].ToString()),
                            Dexterity = int.Parse(reader["Dex"].ToString()),
                            Agility = int.Parse(reader["Agi"].ToString()),
                            Constitution = int.Parse(reader["Con"].ToString()),
                            Intelligence = int.Parse(reader["Int"].ToString()),
                            Wisdom = int.Parse(reader["Wis"].ToString()),
                            Charisma = int.Parse(reader["Cha"].ToString()),

                            //Items and Equipment
                            ArmorClass = int.Parse(reader["Ac"].ToString()),
                            Inventory = null,
                        };
                        #endregion

                        existingPlayer = new Player(id, existingPlayerData);
                    }

                }
                connection.Close();

            }

            if (existingPlayer == null)
                throw new NullReferenceException(string.Format("A player with name: [{0}] could not be found in the database.", playerName));

            return existingPlayer;
        }
    }
}
