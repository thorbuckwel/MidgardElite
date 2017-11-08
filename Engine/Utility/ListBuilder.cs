using Engine.Utility.SQL;
using Engine.Worlds;
using System.Data.SqlClient;

namespace Engine.Utility
{
    public static class ListBuilder
    {
        #region Build Location List
        public static void BuildLocationList()
        {
            string connetionString = null;
            connetionString = SqlCommands.ConnectionString;

            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                string sql = SqlCommands.selectAllLocation;
                cnn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    #region Reader
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = (int.Parse(reader["Id"].ToString()));
                        string name = reader["Name"].ToString();
                        string description = reader["Description"].ToString();
                        int zone = (int.Parse(reader["Zone"].ToString()));
                        int xCord = (int.Parse(reader["XCoord"].ToString()));
                        int yCord = (int.Parse(reader["YCoord"].ToString()));
                        string climate = reader["Climate"].ToString();
                        string terrain = reader["Terrain"].ToString();
                        string effect = reader["Effect"].ToString();
                        string exits = reader["Exits"].ToString();
                        string teleportOut = reader["TeleportOut"].ToString();
                        string teleportIn = reader["TeleportIn"].ToString();

                        #endregion
                        GameWorld._locations.Add(new Location(id, name, zone, xCord, yCord, description, climate, terrain, effect, exits, teleportOut, teleportIn));
                    }
                    
                }
                cnn.Close();
            }
        }
        #endregion
    }
}
