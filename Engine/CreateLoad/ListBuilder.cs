using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Engine.Model;

namespace Engine.CreateLoad
{
   public static class ListBuilder
    {
        public static void BuildLocationList()
        {
            using (var connection = new SqlConnection("Data Source = LAPTOP-9JPEH4UG; Initial Catalog = MidgardEliteWorld; Integrated Security = False"))
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Locations";
                    connection.Open();

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = (int.Parse(reader["Id"].ToString()));
                        string name = reader["Name"].ToString();
                        string description = reader["Description"].ToString();
                        int zone = (int.Parse(reader["Zone"].ToString()));
                        int xCord = (int.Parse(reader["XCord"].ToString()));
                        int yCord = (int.Parse(reader["YCord"].ToString()));
                        string climate = reader["Climate"].ToString();
                        string terrain = reader["Terrain"].ToString();
                        string effect = reader["Effect"].ToString();
                        string exits = reader["Exits"].ToString();

                        GameWorld._locations.Add(new Location(id, name, zone, xCord, yCord, description, climate, terrain, effect, exits));
                    }
                }
            }
        }
    }
}
